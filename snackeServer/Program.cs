using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Timers;
using Newtonsoft.Json;
using System.Threading;

namespace snackeServer
{
    internal class Program
    {
        public static Socket socket;
        public static IPEndPoint ipep;
        public static Socket client;
        public static int score;

        static Thread irc;
        static Thread irc2;
        static Thread sls;
        static Thread ps;

        static List<Snake> snakes = new List<Snake>(); //Độ dài con rắn chứ không phải nhiều con rắn (1)

        public static string ReceiveString(Socket soc)
        {
            byte[] buffer = new byte[1024];            
            try
            {
                int bufferLength = soc.Receive(buffer);
                string data = Encoding.UTF8.GetString(buffer, 0, bufferLength);
                return data;
            }
            catch (SocketException se)
            {
                Console.WriteLine("Người chơi ngắt kết nối. " + se.Message);
                //bật thread server listen state và tắt hết các process khác đi
                ThreadStart thrs = () => ServerListenState();
                sls = new Thread(new ThreadStart(thrs));
                sls.Start();

                ps.Abort();
                irc.Abort();
                irc2.Abort();                
            }
            return null;                       
        }
        public static void SendString(Socket soc, string s)
        {
            byte[] data = Encoding.UTF8.GetBytes(s);
            try
            {
                soc.Send(data, data.Length, SocketFlags.None);
            }
            catch (SocketException se)
            {
                Console.WriteLine("Người chơi ngắt kết nối. " + se.Message);
                //bật thread server listen state và tắt hết các process khác đi
                ThreadStart thrs = () => ServerListenState();
                sls = new Thread(new ThreadStart(thrs));
                sls.Start();
                ps.Abort();
                irc.Abort();
                irc2.Abort();                
            }            
        }
        public static void SendList(Socket soc, List<Snake> s)
        {
            byte[] data;
            string json = JsonConvert.SerializeObject(s);
            data = Encoding.UTF8.GetBytes(json);           
            try
            {
                soc.Send(data, data.Length, SocketFlags.None);
            }
            catch (SocketException se)
            {
                Console.WriteLine("Người chơi ngắt kết nối. " + se.Message);
                //bật thread server listen state và tắt hết các process khác đi
                ThreadStart thrs = () => ServerListenState();
                sls = new Thread(new ThreadStart(thrs));
                sls.Start();
                ps.Abort();
                irc.Abort();
                irc2.Abort();                
            }
        }
        private static void RandMoi()         //ham random toa do moi
        {
            Random randmoi = new Random();
            int x = randmoi.Next(5, 80) * 5;
            int y = randmoi.Next(5, 80) * 5;
            string toado = x.ToString() + " " + y.ToString();

            //gui x,y
            SendString(client, toado);

        }
        private static void TaoMoi()
        {
            RandMoi();
        }
        private static void AnMoi()
        {
            string[] moiLoc = ReceiveString(client).Split(' '); //nhan toa do picmap tu client

            int MoiPicmapX = Convert.ToInt32(moiLoc[0]);
            int MoiPicmapY = Convert.ToInt32(moiLoc[1]);
            if (snakes[0].X > MoiPicmapX / 5 - 2 && snakes[0].X < MoiPicmapX / 5 + 2 &&
                snakes[0].Y > MoiPicmapY / 5 - 2 && snakes[0].Y < MoiPicmapY / 5 + 2) // Nếu đầu rắn trùng với mồi
            {
                //gửi tín hiệu ăn mồi tới client
                SendString(client, "true");
                //xử lí ăn mồi
                Snake abc = new Snake { X = snakes[snakes.Count - 1].X, Y = snakes[snakes.Count - 1].Y };
                snakes.Add(abc);

                SendList(client, snakes);
                string relist = ReceiveString(client);//nhan reply

                score += 10; // Cập nhật điểm số
                SendString(client, score.ToString()); // Gửi điểm số

                Console.WriteLine("Rắn ăn mồi!");
                Console.WriteLine("Điểm hiện tại: " + score);

                // Vẽ lại rắn
                TaoMoi();
            }
            else
            {
                //gửi tín hiệu k ăn mồi tới client
                SendString(client, "false");
            }
        }
        public static void GameRun()
        {
            //nhận keypress từ client
            string KeyPress = ReceiveString(client);

            for (int i = snakes.Count - 1; i >= 0; i--)   //count-1
            {
                if (i == 0)
                {
                    switch (KeyPress)
                    {
                        case "right":
                            snakes[i].X++;   //X: ngang
                            break;
                        case "left":
                            snakes[i].X--;
                            break;
                        case "up":
                            snakes[i].Y--;  //Y: doc
                            break;
                        case "down":
                            snakes[i].Y++;
                            break;
                        default:
                            break;
                    }
                    //code con rắn hẹo
                    //đụng tường
                    int maxX = /*picMap.Size.Width/5*/113,  //chia 5 (116,81) vì vẽ rắn * 5 pixel 
                        maxY = /*picMap.Size.Height/5*/79;
                    if (snakes[0].X < 0 || snakes[0].Y < 0 || snakes[0].X > maxX || snakes[0].Y > maxY)
                    {
                        //gửi tín hiệu kết thúc cho client

                        SendString(client, "end");
                        HetGame();
                        irc.Abort();
                        break;
                    }
                    //dung than
                    for (int j = 2; j < snakes.Count; j++)
                    {
                        if (snakes[0].X == snakes[j].X && snakes[0].Y == snakes[j].Y)
                        {
                            SendString(client, "end");
                            HetGame();
                            irc.Abort();
                            break;
                        }
                    }
                }
                else
                {
                    snakes[i].X = snakes[i - 1].X;
                    snakes[i].Y = snakes[i - 1].Y;
                }
            }
            //gửi tín hiệu chơi tiếp
            SendString(client, "continue");
            //gửi list snake mới cho client
            SendList(client, snakes);
            Thread.Sleep(10);
        }

        public static void HetGame()
        {
            Console.WriteLine("Rắn thăng thiên!");
            Console.WriteLine("Tổng điểm: "+ score);
            //gửi điểm
            SendString(client, score.ToString());
            ThreadStart p = () => ResetGame();
            irc2 = new Thread(new ThreadStart(p));
            irc2.Start();
        }

        public static void Timer1() // Code không bao giờ dừng
        {
            while (true)
            {
                GameRun();
                AnMoi();
                Thread.Sleep(100);
            }
        }
        static void ResetGame()
        {
            
            snakes.Clear();
            score = 0;
            string s = ReceiveString(client);
            if (s == "start")
            {
                Console.WriteLine("Chơi lại.");
                Snake abc = new Snake { X = 10, Y = 5 };
                Snake abcd = new Snake { X = 11, Y = 5 };
                Snake abcde = new Snake { X = 12, Y = 5 };
                Snake abcdef = new Snake { X = 13, Y = 5 };
                Snake abcdefg = new Snake { X = 14, Y = 5 };
                snakes.Add(abcdefg);
                snakes.Add(abcdef);
                snakes.Add(abcde);
                snakes.Add(abcd);
                snakes.Add(abc);
                SendList(client, snakes);
                GameRun();
                TaoMoi();
                AnMoi();
                ThreadStart p = () => Timer1();
                irc = new Thread(new ThreadStart(p));
                irc.Start();
                irc2.Abort();
            }
        }
        static void ServerListenState()
        {
            socket.Listen(10);
            Console.WriteLine("Server đang đợi...");

            client = socket.Accept();
            Console.WriteLine("Người chơi đã kết nối.");

            ThreadStart p = () => PlayState() ;
            ps = new Thread(new ThreadStart(p));
            ps.Start();

            sls.Abort();
        }
        static void PlayState()
        {
            //nhận tín hiệu chơi từ client
            string s = ReceiveString(client);
            if (s == "start")
            {
                Console.WriteLine("Bắt đầu.");
                snakes.Clear();
                score = 0;
                //button play_clicked
                Snake abc = new Snake { X = 10, Y = 5 }; // Tạo thân con rắn
                Snake abcd = new Snake { X = 11, Y = 5 };
                Snake abcde = new Snake { X = 12, Y = 5 };
                Snake abcdef = new Snake { X = 13, Y = 5 };
                Snake abcdefg = new Snake { X = 14, Y = 5 };
                snakes.Add(abcdefg);
                snakes.Add(abcdef);
                snakes.Add(abcde);
                snakes.Add(abcd);
                snakes.Add(abc);

                //gửi con rắn đi
                SendList(client, snakes);

                GameRun();
                TaoMoi();
                AnMoi();
                
                ThreadStart p = () => Timer1();
                irc = new Thread(new ThreadStart(p));
                irc.Start();
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Server";
            Console.OutputEncoding = Encoding.Unicode;
            IPAddress ip = IPAddress.Any;
            ipep = new IPEndPoint(ip, 8888);

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(ipep);

            ThreadStart thrs = () => ServerListenState();
            sls = new Thread(new ThreadStart(thrs));
            sls.Start();
        }
    }
}
