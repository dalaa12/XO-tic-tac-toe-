using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe__X_O_
{
    public partial class Frm_OnePlayer : Form
    {
        public Frm_OnePlayer()
        {
            InitializeComponent();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Main frm = new Frm_Main();
            frm.Show();
        }
        List<Guna.UI2.WinForms.Guna2Button> buttons;
        Random rand = new Random();
        int My_Score = 0;
        int Bot_Score = 0;
        void Loadbuttons()
        {
            buttons = new List<Guna.UI2.WinForms.Guna2Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
        }
        void Wineffect(Guna.UI2.WinForms.Guna2Button b1, Guna.UI2.WinForms.Guna2Button b2, Guna.UI2.WinForms.Guna2Button b3)
        {
            b1.ForeColor = Color.Red;
            b2.ForeColor = Color.Red;
            b3.ForeColor = Color.Red;
            if (b1.Text == "X")
            {
                My_Score++;
                lbl1.Text = My_Score.ToString();
            }
            else
            {
                Bot_Score++;
                lbl2.Text = Bot_Score.ToString();
            }
        }
        bool win = false;
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
        private void Frm_OnePlayer_Load(object sender, EventArgs e)
        {
            foreach (Control c in Guna2PanelOfButtons.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                    c.Click += new System.EventHandler(Btn_click);
                }
            }
            Loadbuttons();
        }
        public void Btn_click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;
            if (btn.Text.Equals(""))
            {
                btn.Text = "X";
                btn.ForeColor = Color.FromArgb(192, 255, 192);
                buttons.Remove(btn);
                GetTheWinner();
                Move.Start();
            }
        }

        private void Move_Tick(object sender, EventArgs e)
        {
            if (buttons.Count > 0 && win == false)
            {
                int index = rand.Next(buttons.Count);
                if (buttons[index].Text == "")
                {
                    buttons[index].ForeColor = Color.FromArgb(255, 255, 192);
                    buttons[index].Text = "O";
                    buttons.RemoveAt(index);
                    GetTheWinner();
                    Move.Stop();
                }
            }
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Loadbuttons();
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
