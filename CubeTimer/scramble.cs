using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeTimer
{
    class Scramble
    {
        public String Generate()
        {
            String str = "";
            int pre_n1 = 6;
            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            for(int i=0; i<20; i++)
            {               
                int n1 = rnd.Next(6);
                int n2 = rnd.Next(10);

                if(n1 == pre_n1)
                {
                    i--;
                    continue;
                }
                else if(n1 == 0)              
                    str += "R";                
                else if(n1 == 1)
                    str += "L";
                else if (n1 == 2)
                    str += "U";
                else if (n1 == 3)
                    str += "D";
                else if (n1 == 4)
                    str += "F";
                else
                    str += "B";

                if (n2 <= 2)
                    str += "'";
                else if(n2 >= 7 && n2 <=9)
                    str += "2";

                if (i != 19)
                    str += " ";

                pre_n1 = n1;
            }

            return str;
        }

        public void Turn_U(Button[,] b_white, Button[,] b_orange, Button[,] b_green, Button[,] b_red, Button[,] b_blue)     //不小心寫成U'的做法
        {        
            Color corner = b_white[0, 0].BackColor;
            Color edge = b_white[0, 1].BackColor;

            b_white[0, 0].BackColor = b_white[2, 0].BackColor;      //處理頂面角塊
            b_white[2, 0].BackColor = b_white[2, 2].BackColor;
            b_white[2, 2].BackColor = b_white[0, 2].BackColor;
            b_white[0, 2].BackColor = corner;

            b_white[0, 1].BackColor = b_white[1, 0].BackColor;      //處理頂面邊塊
            b_white[1, 0].BackColor = b_white[2, 1].BackColor;
            b_white[2, 1].BackColor = b_white[1, 2].BackColor;
            b_white[1, 2].BackColor = edge;

            Color c1 = b_green[0, 0].BackColor;
            Color c2 = b_green[0, 1].BackColor;
            Color c3 = b_green[0, 2].BackColor;

            b_green[0, 0].BackColor = b_red[0, 0].BackColor;
            b_green[0, 1].BackColor = b_red[0, 1].BackColor;
            b_green[0, 2].BackColor = b_red[0, 2].BackColor;
            b_red[0, 0].BackColor = b_blue[0, 0].BackColor;
            b_red[0, 1].BackColor = b_blue[0, 1].BackColor;
            b_red[0, 2].BackColor = b_blue[0, 2].BackColor;
            b_blue[0, 0].BackColor = b_orange[0, 0].BackColor;
            b_blue[0, 1].BackColor = b_orange[0, 1].BackColor;
            b_blue[0, 2].BackColor = b_orange[0, 2].BackColor;
            b_orange[0, 0].BackColor = c1;
            b_orange[0, 1].BackColor = c2;
            b_orange[0, 2].BackColor = c3;
        }

        public void Turn_D(Button[,] b_yellow, Button[,] b_orange, Button[,] b_green, Button[,] b_red, Button[,] b_blue)
        {
            Color corner = b_yellow[0, 0].BackColor;
            Color edge = b_yellow[0, 1].BackColor;

            b_yellow[0, 0].BackColor = b_yellow[2, 0].BackColor;      //處理底面角塊
            b_yellow[2, 0].BackColor = b_yellow[2, 2].BackColor;
            b_yellow[2, 2].BackColor = b_yellow[0, 2].BackColor;
            b_yellow[0, 2].BackColor = corner;

            b_yellow[0, 1].BackColor = b_yellow[1, 0].BackColor;      //處理底面邊塊
            b_yellow[1, 0].BackColor = b_yellow[2, 1].BackColor;
            b_yellow[2, 1].BackColor = b_yellow[1, 2].BackColor;
            b_yellow[1, 2].BackColor = edge;

            Color c1 = b_green[2, 0].BackColor;
            Color c2 = b_green[2, 1].BackColor;
            Color c3 = b_green[2, 2].BackColor;

            b_green[2, 0].BackColor = b_orange[2, 0].BackColor;
            b_green[2, 1].BackColor = b_orange[2, 1].BackColor;
            b_green[2, 2].BackColor = b_orange[2, 2].BackColor;
            b_orange[2, 0].BackColor = b_blue[2, 0].BackColor;
            b_orange[2, 1].BackColor = b_blue[2, 1].BackColor;
            b_orange[2, 2].BackColor = b_blue[2, 2].BackColor;
            b_blue[2, 0].BackColor = b_red[2, 0].BackColor;
            b_blue[2, 1].BackColor = b_red[2, 1].BackColor;
            b_blue[2, 2].BackColor = b_red[2, 2].BackColor;
            b_red[2, 0].BackColor = c1;
            b_red[2, 1].BackColor = c2;
            b_red[2, 2].BackColor = c3;
        }

        public void Turn_R(Button[,] b_red, Button[,] b_green, Button[,] b_white, Button[,] b_blue, Button[,] b_yellow)
        {
            Color corner = b_red[0, 0].BackColor;
            Color edge = b_red[0, 1].BackColor;

            b_red[0, 0].BackColor = b_red[2, 0].BackColor;      //處理右面角塊
            b_red[2, 0].BackColor = b_red[2, 2].BackColor;
            b_red[2, 2].BackColor = b_red[0, 2].BackColor;
            b_red[0, 2].BackColor = corner;

            b_red[0, 1].BackColor = b_red[1, 0].BackColor;      //處理右面邊塊
            b_red[1, 0].BackColor = b_red[2, 1].BackColor;
            b_red[2, 1].BackColor = b_red[1, 2].BackColor;
            b_red[1, 2].BackColor = edge;

            Color c1 = b_green[0, 2].BackColor;
            Color c2 = b_green[1, 2].BackColor;
            Color c3 = b_green[2, 2].BackColor;

            b_green[0, 2].BackColor = b_yellow[0, 2].BackColor;
            b_green[1, 2].BackColor = b_yellow[1, 2].BackColor;
            b_green[2, 2].BackColor = b_yellow[2, 2].BackColor;
            b_yellow[0, 2].BackColor = b_blue[2, 0].BackColor;
            b_yellow[1, 2].BackColor = b_blue[1, 0].BackColor;
            b_yellow[2, 2].BackColor = b_blue[0, 0].BackColor;
            b_blue[2, 0].BackColor = b_white[0, 2].BackColor;
            b_blue[1, 0].BackColor = b_white[1, 2].BackColor;
            b_blue[0, 0].BackColor = b_white[2, 2].BackColor;
            b_white[0, 2].BackColor = c1;
            b_white[1, 2].BackColor = c2;
            b_white[2, 2].BackColor = c3;
        }

        public void Turn_L(Button[,] b_orange, Button[,] b_green, Button[,] b_white, Button[,] b_blue, Button[,] b_yellow)
        {
            Color corner = b_orange[0, 0].BackColor;
            Color edge = b_orange[0, 1].BackColor;

            b_orange[0, 0].BackColor = b_orange[2, 0].BackColor;      //處理左面角塊
            b_orange[2, 0].BackColor = b_orange[2, 2].BackColor;
            b_orange[2, 2].BackColor = b_orange[0, 2].BackColor;
            b_orange[0, 2].BackColor = corner;

            b_orange[0, 1].BackColor = b_orange[1, 0].BackColor;      //處理左面邊塊
            b_orange[1, 0].BackColor = b_orange[2, 1].BackColor;
            b_orange[2, 1].BackColor = b_orange[1, 2].BackColor;
            b_orange[1, 2].BackColor = edge;

            Color c1 = b_green[0, 0].BackColor;
            Color c2 = b_green[1, 0].BackColor;
            Color c3 = b_green[2, 0].BackColor;

            b_green[0, 0].BackColor = b_white[0, 0].BackColor;
            b_green[1, 0].BackColor = b_white[1, 0].BackColor;
            b_green[2, 0].BackColor = b_white[2, 0].BackColor;
            b_white[0, 0].BackColor = b_blue[2, 2].BackColor;
            b_white[1, 0].BackColor = b_blue[1, 2].BackColor;
            b_white[2, 0].BackColor = b_blue[0, 2].BackColor;
            b_blue[2, 2].BackColor = b_yellow[0, 0].BackColor;
            b_blue[1, 2].BackColor = b_yellow[1, 0].BackColor;
            b_blue[0, 2].BackColor = b_yellow[2, 0].BackColor;
            b_yellow[0, 0].BackColor = c1;
            b_yellow[1, 0].BackColor = c2;
            b_yellow[2, 0].BackColor = c3;
        }

        public void Turn_F(Button[,] b_green, Button[,] b_white, Button[,] b_red, Button[,] b_yellow, Button[,] b_orange)
        {
            Color corner = b_green[0, 0].BackColor;
            Color edge = b_green[0, 1].BackColor;

            b_green[0, 0].BackColor = b_green[2, 0].BackColor;      //處理前面角塊
            b_green[2, 0].BackColor = b_green[2, 2].BackColor;
            b_green[2, 2].BackColor = b_green[0, 2].BackColor;
            b_green[0, 2].BackColor = corner;

            b_green[0, 1].BackColor = b_green[1, 0].BackColor;      //處理前面邊塊
            b_green[1, 0].BackColor = b_green[2, 1].BackColor;
            b_green[2, 1].BackColor = b_green[1, 2].BackColor;
            b_green[1, 2].BackColor = edge;

            Color c1 = b_white[2, 0].BackColor;
            Color c2 = b_white[2, 1].BackColor;
            Color c3 = b_white[2, 2].BackColor;

            b_white[2, 0].BackColor = b_orange[2, 2].BackColor;
            b_white[2, 1].BackColor = b_orange[1, 2].BackColor;
            b_white[2, 2].BackColor = b_orange[0, 2].BackColor;
            b_orange[2, 2].BackColor = b_yellow[0, 2].BackColor;
            b_orange[1, 2].BackColor = b_yellow[0, 1].BackColor;
            b_orange[0, 2].BackColor = b_yellow[0, 0].BackColor;
            b_yellow[0, 2].BackColor = b_red[0, 0].BackColor;
            b_yellow[0, 1].BackColor = b_red[1, 0].BackColor;
            b_yellow[0, 0].BackColor = b_red[2, 0].BackColor;
            b_red[0, 0].BackColor = c1;
            b_red[1, 0].BackColor = c2;
            b_red[2, 0].BackColor = c3;
        }

        public void Turn_B(Button[,] b_blue, Button[,] b_white, Button[,] b_red, Button[,] b_yellow, Button[,] b_orange)
        {
            Color corner = b_blue[0, 0].BackColor;
            Color edge = b_blue[0, 1].BackColor;

            b_blue[0, 0].BackColor = b_blue[2, 0].BackColor;      //處理前面角塊
            b_blue[2, 0].BackColor = b_blue[2, 2].BackColor;
            b_blue[2, 2].BackColor = b_blue[0, 2].BackColor;
            b_blue[0, 2].BackColor = corner;

            b_blue[0, 1].BackColor = b_blue[1, 0].BackColor;      //處理前面邊塊
            b_blue[1, 0].BackColor = b_blue[2, 1].BackColor;
            b_blue[2, 1].BackColor = b_blue[1, 2].BackColor;
            b_blue[1, 2].BackColor = edge;

            Color c1 = b_white[0, 0].BackColor;
            Color c2 = b_white[0, 1].BackColor;
            Color c3 = b_white[0, 2].BackColor;

            b_white[0, 0].BackColor = b_red[0, 2].BackColor;
            b_white[0, 1].BackColor = b_red[1, 2].BackColor;
            b_white[0, 2].BackColor = b_red[2, 2].BackColor;
            b_red[0, 2].BackColor = b_yellow[2, 2].BackColor;
            b_red[1, 2].BackColor = b_yellow[2, 1].BackColor;
            b_red[2, 2].BackColor = b_yellow[2, 0].BackColor;
            b_yellow[2, 2].BackColor = b_orange[2, 0].BackColor;
            b_yellow[2, 1].BackColor = b_orange[1, 0].BackColor;
            b_yellow[2, 0].BackColor = b_orange[0, 0].BackColor;
            b_orange[2, 0].BackColor = c1;
            b_orange[1, 0].BackColor = c2;
            b_orange[0, 0].BackColor = c3;
        }
    }
}
