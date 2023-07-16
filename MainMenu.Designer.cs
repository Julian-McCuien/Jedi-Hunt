namespace Jedi_Hunt
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Label();
            this.btnCredits = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Label();
            this.btnLoadGame = new System.Windows.Forms.Label();
            this.btnoptions = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.lblTitle4 = new System.Windows.Forms.Label();
            this.picTieFighter = new System.Windows.Forms.PictureBox();
            this.tmrTieFighter = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTieFighter)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnCredits);
            this.panel1.Controls.Add(this.btnNewGame);
            this.panel1.Controls.Add(this.btnLoadGame);
            this.panel1.Controls.Add(this.btnoptions);
            this.panel1.Location = new System.Drawing.Point(1, 565);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 84);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Star Jedi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Aqua;
            this.btnExit.Location = new System.Drawing.Point(801, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 52);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // btnCredits
            // 
            this.btnCredits.AutoSize = true;
            this.btnCredits.BackColor = System.Drawing.Color.Transparent;
            this.btnCredits.Font = new System.Drawing.Font("Star Jedi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredits.ForeColor = System.Drawing.Color.Aqua;
            this.btnCredits.Location = new System.Drawing.Point(631, 12);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(164, 52);
            this.btnCredits.TabIndex = 10;
            this.btnCredits.Text = "Credits";
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            this.btnCredits.MouseLeave += new System.EventHandler(this.btnCredits_MouseLeave);
            this.btnCredits.MouseHover += new System.EventHandler(this.btnCredits_MouseHover);
            // 
            // btnNewGame
            // 
            this.btnNewGame.AutoSize = true;
            this.btnNewGame.BackColor = System.Drawing.Color.Transparent;
            this.btnNewGame.Font = new System.Drawing.Font("Star Jedi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.Aqua;
            this.btnNewGame.Location = new System.Drawing.Point(3, 12);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(204, 52);
            this.btnNewGame.TabIndex = 6;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            this.btnNewGame.MouseLeave += new System.EventHandler(this.btnNewGame_MouseLeave);
            this.btnNewGame.MouseHover += new System.EventHandler(this.btnNewGame_MouseHover);
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.AutoSize = true;
            this.btnLoadGame.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadGame.Font = new System.Drawing.Font("Star Jedi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadGame.ForeColor = System.Drawing.Color.Aqua;
            this.btnLoadGame.Location = new System.Drawing.Point(222, 12);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(229, 52);
            this.btnLoadGame.TabIndex = 7;
            this.btnLoadGame.Text = "Load Game";
            this.btnLoadGame.MouseLeave += new System.EventHandler(this.btnLoadGame_MouseLeave);
            this.btnLoadGame.MouseHover += new System.EventHandler(this.btnLoadGame_MouseHover);
            // 
            // btnoptions
            // 
            this.btnoptions.AutoSize = true;
            this.btnoptions.BackColor = System.Drawing.Color.Transparent;
            this.btnoptions.Font = new System.Drawing.Font("Star Jedi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoptions.ForeColor = System.Drawing.Color.Aqua;
            this.btnoptions.Location = new System.Drawing.Point(457, 12);
            this.btnoptions.Name = "btnoptions";
            this.btnoptions.Size = new System.Drawing.Size(168, 52);
            this.btnoptions.TabIndex = 9;
            this.btnoptions.Text = "options";
            this.btnoptions.Click += new System.EventHandler(this.btnoptions_Click);
            this.btnoptions.MouseLeave += new System.EventHandler(this.btnoptions_MouseLeave);
            this.btnoptions.MouseHover += new System.EventHandler(this.btnoptions_MouseHover);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Star Jedi", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitle.Location = new System.Drawing.Point(210, 52);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(485, 128);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Jedi Hunt";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Font = new System.Drawing.Font("Star Jedi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitle2.Location = new System.Drawing.Point(361, 151);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(218, 52);
            this.lblTitle2.TabIndex = 2;
            this.lblTitle2.Text = "Star Wars";
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle3.Font = new System.Drawing.Font("Star Jedi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle3.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitle3.Location = new System.Drawing.Point(325, 170);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(24, 26);
            this.lblTitle3.TabIndex = 3;
            this.lblTitle3.Text = "A";
            // 
            // lblTitle4
            // 
            this.lblTitle4.AutoSize = true;
            this.lblTitle4.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle4.Font = new System.Drawing.Font("Star Jedi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle4.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitle4.Location = new System.Drawing.Point(574, 170);
            this.lblTitle4.Name = "lblTitle4";
            this.lblTitle4.Size = new System.Drawing.Size(103, 26);
            this.lblTitle4.TabIndex = 4;
            this.lblTitle4.Text = "Fan Game";
            // 
            // picTieFighter
            // 
            this.picTieFighter.BackColor = System.Drawing.Color.Transparent;
            this.picTieFighter.Image = global::Jedi_Hunt.Properties.Resources.tiefighter_removebg_preview;
            this.picTieFighter.Location = new System.Drawing.Point(1, 229);
            this.picTieFighter.Name = "picTieFighter";
            this.picTieFighter.Size = new System.Drawing.Size(173, 102);
            this.picTieFighter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTieFighter.TabIndex = 5;
            this.picTieFighter.TabStop = false;
            // 
            // tmrTieFighter
            // 
            this.tmrTieFighter.Interval = 10;
            this.tmrTieFighter.Tick += new System.EventHandler(this.tmrTieFighter_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jedi_Hunt.Properties.Resources.starwarsgalaxies;
            this.ClientSize = new System.Drawing.Size(924, 661);
            this.Controls.Add(this.picTieFighter);
            this.Controls.Add(this.lblTitle4);
            this.Controls.Add(this.lblTitle3);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.border);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTieFighter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Label lblTitle4;
        private System.Windows.Forms.Label btnNewGame;
        private System.Windows.Forms.Label btnCredits;
        private System.Windows.Forms.Label btnoptions;
        private System.Windows.Forms.Label btnLoadGame;
        private System.Windows.Forms.PictureBox picTieFighter;
        private System.Windows.Forms.Timer tmrTieFighter;
        private System.Windows.Forms.Label btnExit;
    }
}