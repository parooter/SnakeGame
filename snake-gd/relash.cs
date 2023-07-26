using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake_gd
{
    public partial class relash : Form
    {
        public relash()
        {
            InitializeComponent();
        }
    
        private void btPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();
            
            btPlay.FlatAppearance.BorderColor = Color.Blue;
            btPlay.FlatAppearance.BorderSize = 2;

            
            //gọi qua play-form
            Play_form play_Form = new Play_form();
            play_Form.ShowDialog();

            this.Close();
        }
          
        private void btquit_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Close();   
            
        }

        private void bthow_Click(object sender, EventArgs e)
        {
            //dung messagebox để hiển thị hướng dẫn chơi
            MessageBox.Show("Dùng A,D,W,S điều khiển rắn ăn mồi!", " Snake Game Rule");

        }

        private void btconnect_Click(object sender, EventArgs e)
        {
            //connect to server
            
            bool state=Play_form.CONNECT();

            //dieu kien khi ma connect dc toi server --> thong bao
            if(state)
            {
                MessageBox.Show("Kết nối thành công! \n"+
                    "Đã kết nối đến Server Snake Game!");
            }
            else
            {
                MessageBox.Show("Kết nối thất bại! \n" +
                    "Vui lòng kết nối lại!");
            }

            
        }

        private void relash_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
