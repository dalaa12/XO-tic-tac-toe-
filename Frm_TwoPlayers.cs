using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe__X_O_
{
    public partial class Frm_TwoPlayers : Form
    {
        public Frm_TwoPlayers()
        {
            InitializeComponent();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Main frm = new Frm_Main();
            frm.Show();
        }
        int xo = 0;
        int Player1 = 0;
        int Player2 = 0;
        bool win = false;
        void Wineffect(Guna.UI2.WinForms.Guna2Button b1, Guna.UI2.WinForms.Guna2Button b2, Guna.UI2.WinForms.Guna2Button b3)
        {
            b1.ForeColor = Color.AliceBlue;
            b2.ForeColor = Color.AliceBlue;
            b3.ForeColor = Color.AliceBlue;
            if (b1.Text == "X")
            {
                Player1++;
                Lbl1.Text = Player1.ToString();
            }
            else
            {
                Player2++;
                Lbl2.Text = Player2.ToString();
            }
        }
        void GetTheWinner()
        {
            if (btn1.Text != "" && btn1.Text == btn2.Text && btn1.Text == btn3.Text)
            {
                Wineffect(btn1, btn2, btn3);
                win = true;
            }
            if (btn4.Text != "" && btn4.Text == btn5.Text && btn4.Text == btn6.Text)
            {
                Wineffect(btn4, btn5, btn6);
                win = true;
            }
            if (btn7.Text != "" && btn7.Text == btn8.Text && btn7.Text == btn9.Text)
            {
                Wineffect(btn7, btn8, btn9);
                win = true;
            }
            if (btn1.Text != "" && btn1.Text == btn4.Text && btn1.Text == btn7.Text)
            {
                Wineffect(btn1, btn4, btn7);
                win = true;
            }
            if (btn2.Text != "" && btn2.Text == btn5.Text && btn2.Text == btn8.Text)
            {
                Wineffect(btn2, btn5, btn8);
                win = true;
            }
            if (btn3.Text != "" && btn3.Text == btn6.Text && btn3.Text == btn9.Text)
            {
                Wineffect(btn3, btn6, btn9);
                win = true;
            }
            if (btn1.Text != "" && btn1.Text == btn5.Text && btn1.Text == btn9.Text)
            {
                Wineffect(btn1, btn5, btn9);
                win = true;
            }
            if (btn3.Text != "" && btn3.Text == btn5.Text && btn3.Text == btn7.Text)
            {
                Wineffect(btn3, btn5, btn7);
                win = true;
            }
        }
        private void Frm_TwoPlayers_Load(object sender, EventArgs e)
        {
            foreach (Control c in Guna2PanelOfButtons.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                    c.Click += new System.EventHandler(Btn_click);
                }
            }
        }
        void Btn_click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;
            if (btn.Text.Equals(""))
            {
                if (xo % 2 == 0)
                {
                    btn.Text = "X";
                    btn.ForeColor = Color.FromArgb(192, 255, 192);
                    GetTheWinner();
                }
                else
                {
                    btn.Text = "O";
                    btn.ForeColor = Color.FromArgb(255, 255, 192);
                    GetTheWinner();
                }
                xo++;
            }
        }
        private void btnOnePlayer_Click(object sender, EventArgs e)
        {
            xo = 0;
            win = false;
            foreach (Control c in Guna2PanelOfButtons.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                    c.Text = "";
                }
            }
        }
    }
}
