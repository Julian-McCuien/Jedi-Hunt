namespace Jedi_Hunt
{
    partial class GameSummary
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
            this.flowLayoutPanelItems = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTryAgain = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanelItems
            // 
            this.flowLayoutPanelItems.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelItems.Location = new System.Drawing.Point(84, 47);
            this.flowLayoutPanelItems.Name = "flowLayoutPanelItems";
            this.flowLayoutPanelItems.Size = new System.Drawing.Size(738, 565);
            this.flowLayoutPanelItems.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Star Jedi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "items Collected";
            // 
            // btnTryAgain
            // 
            this.btnTryAgain.AutoSize = true;
            this.btnTryAgain.BackColor = System.Drawing.Color.Transparent;
            this.btnTryAgain.Font = new System.Drawing.Font("Star Jedi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTryAgain.ForeColor = System.Drawing.Color.Yellow;
            this.btnTryAgain.Location = new System.Drawing.Point(90, 615);
            this.btnTryAgain.Name = "btnTryAgain";
            this.btnTryAgain.Size = new System.Drawing.Size(243, 35);
            this.btnTryAgain.TabIndex = 2;
            this.btnTryAgain.Text = "click to continue";
            this.btnTryAgain.Click += new System.EventHandler(this.btnTryAgain_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Star Jedi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Yellow;
            this.btnBack.Location = new System.Drawing.Point(677, 615);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 35);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Main Menu";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GameSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jedi_Hunt.Properties.Resources.starwarsgalaxies;
            this.ClientSize = new System.Drawing.Size(924, 661);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTryAgain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelItems);
            this.Name = "GameSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Summary";
            this.Load += new System.EventHandler(this.GameSummary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnTryAgain;
        private System.Windows.Forms.Label btnBack;
    }
}