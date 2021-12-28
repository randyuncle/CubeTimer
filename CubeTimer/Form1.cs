using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            scramble.Text = sc.Generate();
            scramble.Location = new Point((Width - scramble.Width) / 2, 12);
            L_time.Location = new Point((Width - L_time.Width) / 2, (Height - L_time.Height) / 2 - 75);   
            //有關location的東西純粹是為了調整成績的位置
        }
        
        bool timing = false;
        private DateTime startTime;
        Scramble sc = new Scramble();
        public Button[,] B_orange = new Button[3, 3];
        public Button[,] B_green = new Button[3, 3];
        public Button[,] B_red = new Button[3, 3];
        public Button[,] B_blue = new Button[3, 3];
        public Button[,] B_white = new Button[3, 3];
        public Button[,] B_yellow = new Button[3, 3];

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    B_orange[i, j] = new Button();
                    B_orange[i, j].SetBounds(370 + j * 30, 530 + i * 30, 30, 30);
                    B_orange[i, j].BackColor = Color.Orange;
                    B_orange[i, j].Enabled = false;
                    Controls.Add(B_orange[i, j]);

                    B_green[i, j] = new Button();
                    B_green[i, j].SetBounds(480 + j * 30, 530 + i * 30, 30, 30);
                    B_green[i, j].BackColor = Color.Green;
                    B_green[i, j].Enabled = false;
                    Controls.Add(B_green[i, j]);

                    B_red[i, j] = new Button();
                    B_red[i, j].SetBounds(590 + j * 30, 530 + i * 30, 30, 30);
                    B_red[i, j].BackColor = Color.Red;
                    B_red[i, j].Enabled = false;
                    Controls.Add(B_red[i, j]);

                    B_blue[i, j] = new Button();
                    B_blue[i, j].SetBounds(700 + j * 30, 530 + i * 30, 30, 30);
                    B_blue[i, j].BackColor = Color.Blue;
                    B_blue[i, j].Enabled = false;
                    Controls.Add(B_blue[i, j]);

                    B_white[i, j] = new Button();
                    B_white[i, j].SetBounds(480 + j * 30, 420 + i * 30, 30, 30);
                    B_white[i, j].BackColor = Color.White;
                    B_white[i, j].Enabled = false;
                    Controls.Add(B_white[i, j]);

                    B_yellow[i, j] = new Button();
                    B_yellow[i, j].SetBounds(480 + j * 30, 640 + i * 30, 30, 30);
                    B_yellow[i, j].BackColor = Color.Yellow;
                    B_yellow[i, j].Enabled = false;
                    Controls.Add(B_yellow[i, j]);
                }
            }
            ShowScramble();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeElapsed = DateTime.Now - startTime;
            L_time.Text = timeElapsed.TotalSeconds.ToString("0.00");
            if(timeElapsed.Seconds >= 10)
            {
                L_time.Location = new Point((Width - L_time.Width) / 2, (Height - L_time.Height) / 2 - 75);
            }
            if(timeElapsed.Minutes >= 1)
            {
                L_time.Text = timeElapsed.Minutes.ToString() + ":" + timeElapsed.Seconds.ToString("00") + "." + (timeElapsed.Milliseconds / 10).ToString("00");
                L_time.Location = new Point((Width - L_time.Width) / 2, (Height - L_time.Height) / 2 - 75);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (timing)
                return;
            L_time.Text = "0.00";
            L_time.ForeColor = Color.Green;
            L_time.Location = new Point((Width - L_time.Width) / 2, (Height - L_time.Height) / 2 - 75);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            L_time.ForeColor = Color.Black;
            if (!timing)
            {
                startTime = DateTime.Now;
                timer1.Start();
                timing = true;
            }
            else
            {
                timer1.Stop();
                timing = false;
                scramble.Text = sc.Generate();
                scramble.Location = new Point((Width - scramble.Width) / 2, 12);
                Rebuild();
                ShowScramble();
            }        
        }

        /**
         * 登出(到登入畫面)
         */ 
        private void B_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void B_guide_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            scramble.Focus();
        }

        private void B_change_Click(object sender, EventArgs e)
        {
            scramble.Text = sc.Generate();
            scramble.Location = new Point((Width - scramble.Width) / 2, 12);
            Rebuild();
            ShowScramble();
            scramble.Focus();
        }

        public void ShowScramble()
        {
            String[] str = scramble.Text.Split(' ');
            foreach(string c in str)
            {
                if (c == "U")
                    sc.Turn_U(B_white, B_orange, B_green, B_red, B_blue);
                else if (c == "U'")
                    for (int i = 0; i < 3; i++)
                        sc.Turn_U(B_white, B_orange, B_green, B_red, B_blue);
                else if (c == "U2")
                    for (int i = 0; i < 2; i++)
                        sc.Turn_U(B_white, B_orange, B_green, B_red, B_blue);
                else if(c == "D")
                    sc.Turn_D(B_yellow, B_orange, B_green, B_red, B_blue);
                else if(c == "D'")
                    for (int i = 0; i < 3; i++)
                        sc.Turn_D(B_yellow, B_orange, B_green, B_red, B_blue);
                else if (c == "D2")
                    for (int i = 0; i < 2; i++)
                        sc.Turn_D(B_yellow, B_orange, B_green, B_red, B_blue);
                else if(c == "R")
                    sc.Turn_R(B_red, B_green, B_white, B_blue, B_yellow);
                else if (c == "R'")
                    for (int i = 0; i < 3; i++)
                        sc.Turn_R(B_red, B_green, B_white, B_blue, B_yellow);
                else if (c == "R2")
                    for (int i = 0; i < 2; i++)
                        sc.Turn_R(B_red, B_green, B_white, B_blue, B_yellow);
                else if (c == "L")
                    sc.Turn_L(B_orange, B_green, B_white, B_blue, B_yellow);
                else if (c == "L'")
                    for (int i = 0; i < 3; i++)
                        sc.Turn_L(B_orange, B_green, B_white, B_blue, B_yellow);
                else if (c == "L2")
                    for (int i = 0; i < 2; i++)
                        sc.Turn_L(B_orange, B_green, B_white, B_blue, B_yellow);
                else if (c == "F")
                    sc.Turn_F(B_green, B_white, B_red, B_yellow, B_orange);
                else if (c == "F'")
                    for (int i = 0; i < 3; i++)
                        sc.Turn_F(B_green, B_white, B_red, B_yellow, B_orange);
                else if (c == "F2")
                    for (int i = 0; i < 2; i++)
                        sc.Turn_F(B_green, B_white, B_red, B_yellow, B_orange);
                else if (c == "B")
                    sc.Turn_B(B_blue, B_white, B_red, B_yellow, B_orange);
                else if (c == "B'")
                    for (int i = 0; i < 3; i++)
                        sc.Turn_B(B_blue, B_white, B_red, B_yellow, B_orange);
                else if (c == "B2")
                    for (int i = 0; i < 2; i++)
                        sc.Turn_B(B_blue, B_white, B_red, B_yellow, B_orange);
            }
        }

        public void Rebuild()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    B_orange[i, j].BackColor = Color.Orange;
                    B_green[i, j].BackColor = Color.Green;
                    B_red[i, j].BackColor = Color.Red;
                    B_blue[i, j].BackColor = Color.Blue;
                    B_white[i, j].BackColor = Color.White;
                    B_yellow[i, j].BackColor = Color.Yellow;
                }
            }
        }

        private void B_logo_Click(object sender, EventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
            scramble.Focus();
        }

        private void VisitLink()
        {
            System.Diagnostics.Process.Start("https://cstimer.net/");
        }

        private void B_show_Click(object sender, EventArgs e)
        {
            if(B_show.Text == "顯示")
            {
                B_show.Text = "隱藏";
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        B_orange[i, j].Visible = true;
                        B_green[i, j].Visible = true;
                        B_red[i, j].Visible = true;
                        B_blue[i, j].Visible = true;
                        B_white[i, j].Visible = true;
                        B_yellow[i, j].Visible = true;
                    }
                }
            }
            else
            {
                B_show.Text = "顯示";
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        B_orange[i, j].Visible = false;
                        B_green[i, j].Visible = false;
                        B_red[i, j].Visible = false;
                        B_blue[i, j].Visible = false;
                        B_white[i, j].Visible = false;
                        B_yellow[i, j].Visible = false;
                    }
                }
            }
            scramble.Focus();
        }
    }
}
