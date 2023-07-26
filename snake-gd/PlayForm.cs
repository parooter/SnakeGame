using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace snake_gd
{

    public partial class Play_form : Form
    {
        //----------------------------------------------------------------
        public static Socket socket;
        public static IPEndPoint ipep;

        //-------------------Connect C-S------------------------
        // ket noi client -- server

        public static bool CONNECT()
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            ipep = new IPEndPoint(ip, 8888);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try{ socket.Connect(ipep); }
            catch (SocketException ex)
            {
                return false;
            }
            return true;    
        }
        public static string ReceiveString(Socket soc)
        {
            byte[] buffer = new byte[1024];
            int bufferLength = soc.Receive(buffer);
            string data = Encoding.UTF8.GetString(buffer, 0, bufferLength);
            return data;
        }
        public static void SendString(Socket soc, string s)
        {
            byte[] data = Encoding.UTF8.GetBytes(s);
            soc.Send(data, data.Length, SocketFlags.None);
        }
        static List<Snake> ReceiveList(Socket soc) //hàm để nhận nguyên list con rắn từ server
        {
            byte[] buffer = new byte[4096];
            int bufferLength = soc.Receive(buffer);
            byte[] rec = new byte[bufferLength];
            Array.Copy(buffer, rec, bufferLength);
            List<Snake> s;
            string json = Encoding.UTF8.GetString(rec, 0, bufferLength);
            s = JsonConvert.DeserializeObject<List<Snake>>(json);   
            return s;
        }

        //-----------------------------------------------------------------------------------//

        PictureBox moiPicmap;
        //--------------------------------------Moi-----------------------------------------//
        private Point RandMoi()         //ham random toa do moi
        {
            //nhận tọa độ x y từ phía server
            string toado = ReceiveString(socket);

            string[] t=toado.Split(' ');
            int x, y;
            x = Convert.ToInt32(t[0]);
            y = Convert.ToInt32(t[1]);
            return new Point(x, y);
        }

        private void TaoMoi()       
        {
            Point moiPosition = RandMoi();            
            moiPicmap = new PictureBox();                    //tao picturebox moi cho moi

            moiPicmap.Location = moiPosition;               //cho vi tri cua moi nay = vi tri random
            moiPicmap.Size = new Size(12, 12);              //tren picturebox moi nen la phai dung moiPicmap
            moiPicmap.BackColor = Color.Red;
            picMap.Controls.Add(moiPicmap);     
        }

        //can lay toa do cua khung picturebox... 
        private void PicMapPosition()
        {
            picMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;      //vien cua khung picmap
        }

        //thiet ke an moi 
        private void AnMoi()
        {
            string moiLoc = moiPicmap.Location.X.ToString() + " " + moiPicmap.Location.Y.ToString();
            //gửi cho server
            SendString(socket,moiLoc);

            //nhận tín hiệu từ server
            string rec=ReceiveString(socket);
            if (rec=="true") //nếu tín hiệu nhận được là true
            {
                picMap.Controls.Remove(moiPicmap);
                snakes=ReceiveList(socket); //nhan list snake moi
                SendString(socket, " "); //reply lai cho server

                string score = ReceiveString(socket);// Nhận điểm số
                lbscore.Text = score.ToString(); // Hiển thị điểm số           

                // Vẽ lại rắn
                Draw();
                TaoMoi();
            }
            
        }
        private void btplay_Click(object sender, EventArgs e)
        {
            stateGame = true;       //bat trang thai game

            //gửi tín hiệu cho server
            SendString(socket, "start");
            
            // Nhận rắn từ server
            List<Snake> s = ReceiveList(socket);
            snakes = s;

            Draw();             //ve
            int sX = snakes[snakes.Count - 1].X,
                sY = snakes[snakes.Count - 1].Y; //lấy tọa độ cái đuôi con rắn trước khi nó di chuyển

            GameRun();
            TaoMoi();
            AnMoi();
            ReDraw(sX, sY);
            timer1.Start();
            btplay.Enabled = false;     //tat trang thai cua nut, ko nhan duoc nua 
        }

        private void Play_form_KeyDown(object sender, KeyEventArgs e)   // nhan phim 
        {
            if (e.KeyCode == Keys.A  && KeyPress!="right")
            {
                KeyPress = "left";
            }
            if (e.KeyCode == Keys.D && KeyPress != "left")
            {
                KeyPress = "right";
            }
            if (e.KeyCode == Keys.W && KeyPress != "down")
            {
                KeyPress = "up";
            }
            if (e.KeyCode == Keys.S && KeyPress != "up")
            {
                KeyPress = "down";
            }
        }
        public Play_form()
        {
            InitializeComponent();

            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox1.DrawItem += ComboBoxDrawItem;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            // Add items to the ComboBox
            comboBox1.Items.Add(new SnakeColor("Xanh tím", Color.BlueViolet));
            comboBox1.Items.Add(new SnakeColor("Vàng", Color.Yellow));
            comboBox1.Items.Add(new SnakeColor("Cam", Color.Orange));
            comboBox1.Items.Add(new SnakeColor("Hồng", Color.Pink));
            comboBox1.Items.Add(new SnakeColor("Xanh dương", Color.Blue));
            comboBox1.Items.Add(new SnakeColor("Xanh lá", Color.Green));

            comboBox1.SelectedIndex = 0;
        }

        
        string KeyPress = "right";
        Color snakeC=Color.BlueViolet;

        List<Snake> snakes = new List<Snake>(); //Độ dài con rắn chứ không phải nhiều con rắn (1)
        
        //----------------Ve-----------------//
        private void Draw() // Tô màu con rắn (2)  -- ve con ran len picturebox
        {
            Graphics canvas = picMap.CreateGraphics();
            Brush snakeColour;
            for (int i = 0; i < snakes.Count; i++)
            {
                //snakeColour = Brushes.BlueViolet;   //mau con ran
                snakeColour = new SolidBrush(snakeC);
                canvas.FillEllipse(snakeColour, new Rectangle(snakes[i].X * 5, snakes[i].Y * 5, 15, 15));
            }
        }

        private void ReDraw(int x, int y) // Tô cái đuôi con rắn lại thành màu nền sau khi nó di chuyển
        {
            Graphics canvas = picMap.CreateGraphics();
            Brush snakeColour;
            snakeColour = new SolidBrush(Color.White);  // to lai mau duoi con ran di qua thanh mau trang           
            canvas.FillEllipse(snakeColour, new Rectangle(x* 5, y * 5, 15, 15));   //hinh tron dau con ran 15,15
            snakeColour = new SolidBrush(snakeC);   //mau con ran
            canvas.FillEllipse(snakeColour, new Rectangle(snakes[snakes.Count - 1].X * 5, snakes[snakes.Count - 1].Y * 5, 15, 15));
        }
        //-------------Gamerun---------------
        public void GameRun()
        {
            //gửi keypress cho server
            SendString(socket, KeyPress);
            //kiểm tra xem có nhận thông báo kết thúc hay k
            string check = ReceiveString(socket);

            if (check == "end")
            {                
                HetGame();                
            }
            else if (check == "continue")
            {
                //vì code GameRun làm thay đổi tới List snakes, nên chỉ cần nhận list mới là xong 
                List<Snake> s = ReceiveList(socket);
                snakes = s;
                //vẽ lại rắn
                Draw();
            } 
        }
        bool snakedie = true;
        public void HetGame()
        {
            timer1.Stop();
            snakedie = false;
            this.Hide();
            this.Close();            

            string EndScore= ReceiveString(socket);
            FormResult formResult = new FormResult(EndScore);            
            formResult.ShowDialog();
        }
        private void Play_form_Load(object sender, EventArgs e)
        {
            PicMapPosition();
        }
        private void timer1_Tick(object sender, EventArgs e) // Code không bao giờ dừng
        {
            
            int sX = snakes[snakes.Count - 1].X,
                sY = snakes[snakes.Count - 1].Y;//lấy tọa độ cái đuôi con rắn trước khi nó di chuyển

            GameRun();
            if (!snakedie)  //rắn chết thì đừng chạy 2 cái dưới nữa
                return;

            AnMoi();
            ReDraw(sX,sY);
        }

        private void btquit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bthowplay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dùng A,D,W,S điều khiển rắn ăn mồi!", "  Snake Game Rule");
        }
             
        //-----------------Pause Button--------------
        bool stateGame = false;    //trang thai game
        private void btpau_Click(object sender, EventArgs e)
        {
            if (stateGame == true)
            {
                btpau.Text = "| |";
                timer1.Stop();                                         
                stateGame = false;  //dat lai stategame=false
            }
            else
            {
                stateGame = true;   //dat lai stategame=true
                btpau.Text = "▶";
                // tiếp tục game ở đây, ví dụ:
                timer1.Start();            
            }
        }
        private void ComboBoxDrawItem(object sender, DrawItemEventArgs e)
        {
            // Check if the item is valid
            if (e.Index < 0)
                return;

            // Get the ComboBox and the item at the specified index
            ComboBox comboBox = (ComboBox)sender;
            SnakeColor item = (SnakeColor)comboBox.Items[e.Index];

            // Set the background color of the item
            e.DrawBackground();
            e.Graphics.FillRectangle(new SolidBrush(item.Color), e.Bounds);

            // Draw the text of the item
            e.Graphics.DrawString(item.Text, comboBox.Font, Brushes.Black, e.Bounds.X, e.Bounds.Y);

            // Draw a focus rectangle if needed
            e.DrawFocusRectangle();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SnakeColor item = (SnakeColor)comboBox1.SelectedItem;
            snakeC = item.Color;
        }
    }    
}
