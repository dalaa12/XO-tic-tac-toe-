namespace Tic_Tac_Toe__X_O_
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btnOnePlayer_Click(object sender, EventArgs e)
        {
            Frm_OnePlayer Frm = new Frm_OnePlayer();
            Frm.Show();
            this.Hide();
        }
        private void btnTwoPlayers_Click(object sender, EventArgs e)
        {
            Frm_TwoPlayers frm = new Frm_TwoPlayers();
            frm.Show();
            this.Hide();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}