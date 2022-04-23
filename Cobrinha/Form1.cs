namespace Cobrinha
{
    public partial class Form1 : Form
    {
        Jogo Jogo;
        public Form1()
        {
            InitializeComponent();
            Jogo = new Jogo(ref Timer, ref LbPontos, ref PnTela);
        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jogo.StartGame();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Jogo.Tick();
        }

        private void CliqueTecla(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                Jogo.Arrow = e.KeyCode;
            }
        }
    }
}