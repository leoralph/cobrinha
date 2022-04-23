using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Cobrinha
{
    internal class Jogo
    {
        public Keys Direction { get; set; }
        public Keys Arrow { get; set; }
        private Timer Timer { get; set; }
        private Label LbPontos { get; set; }
        private Panel PnTela { get; set; }
        private int Pontos { get; set; }

        private List<Comida> Comidas = new List<Comida>();
        private Cobra Cobra;
        private Bitmap OffScreenBitmap;
        private Graphics BitmapGraph;
        private Graphics ScreenGraph;
        public Jogo(ref Timer timer, ref Label label, ref Panel panel)
        {
            PnTela = panel;
            Timer = timer;
            LbPontos = label;
            OffScreenBitmap = new Bitmap(428, 428);
            Cobra = new Cobra();
            Direction = Keys.Left;
            Comidas.Add(new Comida());
            Arrow = Direction;
        }

        public void StartGame()
        {
            Cobra.Reset();
            Comidas[0].createFood();
            Direction = Keys.Left;
            BitmapGraph = Graphics.FromImage(OffScreenBitmap);
            ScreenGraph = PnTela.CreateGraphics();
            Timer.Enabled = true;
        }

        public void Tick()
        {
            if (
                (Arrow == Keys.Left && Direction != Keys.Right) ||
                (Arrow == Keys.Right && Direction != Keys.Left) ||
                (Arrow == Keys.Up && Direction != Keys.Down) ||
                (Arrow == Keys.Down && Direction != Keys.Up)
            ) {
                Direction = Arrow;
            }

            switch (Direction)
            {
                case Keys.Left:
                    Cobra.Left();
                    break;
                case Keys.Right:
                    Cobra.Right();
                    break;
                case Keys.Up:
                    Cobra.Up();
                    break;
                case Keys.Down:
                    Cobra.Down();
                    break;
            }

            BitmapGraph.Clear(Color.White);

            for (int i = 0; i < Comidas.Count; i++)
            {
                BitmapGraph.FillEllipse(new SolidBrush(Color.Red), (Comidas[i].Location.X * 15), (Comidas[i].Location.Y * 15), 15, 15);
            }
            bool GameOver = false;

            for (int i = 0; i < Cobra.Length; i++)
            {
                if (i == 0)
                {
                    BitmapGraph.FillEllipse(new SolidBrush(ColorTranslator.FromHtml("#000")), (Cobra.Location[i].X * 15), (Cobra.Location[i].Y * 15), 15, 15);
                } else
                {
                    BitmapGraph.FillEllipse(new SolidBrush(ColorTranslator.FromHtml("#4F4F4F")), (Cobra.Location[i].X * 15), (Cobra.Location[i].Y * 15), 15, 15);
                }

                if (Cobra.Location[i] == Cobra.Location[0] && i > 0)
                {
                    GameOver = true;
                }
            }

            ScreenGraph.DrawImage(OffScreenBitmap, 0, 0);

            CheckCollision();

            if (GameOver)
            {
                this.GameOver();
            }
        }
        public void CheckCollision()
        {
            for (int i = 0; i < Comidas.Count; i++)
            {
                if (Cobra.Location[i] == Comidas[i].Location)
                {
                    Cobra.Comer();
                    Comidas[i].createFood();
                    Pontos++;
                    if (Pontos % 10 == 0)
                    {
                        Comidas.Add(new Comida());
                        Comidas.Last().createFood();
                    }
                    if (Pontos % 15 == 0 && Timer.Interval < 40)
                    {
                        Timer.Interval -= 6;
                    }
                    LbPontos.Text = $"PONTOS: {Pontos}";
                }
            }
        }

        public void GameOver()
        {
            Timer.Enabled = false;
            BitmapGraph.Dispose();
            ScreenGraph.Dispose();
            Pontos = 0;
            Timer.Interval = 80;
            Comidas.RemoveRange(1, Comidas.Count-1);
            LbPontos.Text = "PONTOS: 0";
            MessageBox.Show("GAME OVER!");
        }
    }

}
