namespace Cobrinha
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PnTela = new System.Windows.Forms.Panel();
            this.LbPontos = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnTela
            // 
            this.PnTela.Location = new System.Drawing.Point(9, 90);
            this.PnTela.Name = "PnTela";
            this.PnTela.Size = new System.Drawing.Size(428, 428);
            this.PnTela.TabIndex = 0;
            // 
            // LbPontos
            // 
            this.LbPontos.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbPontos.Location = new System.Drawing.Point(9, 40);
            this.LbPontos.Name = "LbPontos";
            this.LbPontos.Size = new System.Drawing.Size(424, 47);
            this.LbPontos.TabIndex = 1;
            this.LbPontos.Text = "PONTOS: 0";
            this.LbPontos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(445, 24);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.iniciarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 80;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 522);
            this.Controls.Add(this.LbPontos);
            this.Controls.Add(this.PnTela);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobrinha";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CliqueTecla);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PnTela;
        private Label LbPontos;
        private MenuStrip Menu;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem iniciarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Timer Timer;
    }
}