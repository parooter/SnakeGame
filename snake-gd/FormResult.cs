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
    public partial class FormResult : Form
    {
        public FormResult()
        {
            InitializeComponent();
        }
        public FormResult(string score)
        {
            InitializeComponent();
            lbscore.Text = score;
        }

        private void btquit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {                  
            this.Hide();
            //this.Close();

            Play_form play_Form = new Play_form();
            play_Form.ShowDialog();

            this.Close();
        }
    }
}
