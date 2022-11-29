namespace LA1300
{
    partial class GameScreen
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
            this.lblTempGame = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTempGame
            // 
            this.lblTempGame.AutoSize = true;
            this.lblTempGame.Location = new System.Drawing.Point(611, 234);
            this.lblTempGame.Name = "lblTempGame";
            this.lblTempGame.Size = new System.Drawing.Size(92, 20);
            this.lblTempGame.TabIndex = 0;
            this.lblTempGame.Text = "GameScreen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1205, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadStart);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 628);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTempGame);
            this.Name = "GameScreen";
            this.Text = "GameScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTempGame;
        private Button button1;
    }
}