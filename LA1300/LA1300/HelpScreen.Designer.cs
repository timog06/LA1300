namespace LA1300
{
    partial class HelpScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpScreen));
            this.lblTempHelp = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTempHelp
            // 
            this.lblTempHelp.AutoSize = true;
            this.lblTempHelp.Location = new System.Drawing.Point(12, 9);
            this.lblTempHelp.Name = "lblTempHelp";
            this.lblTempHelp.Size = new System.Drawing.Size(515, 200);
            this.lblTempHelp.TabIndex = 0;
            this.lblTempHelp.Text = resources.GetString("lblTempHelp.Text");
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(417, 560);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 33);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // HelpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 605);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTempHelp);
            this.Name = "HelpScreen";
            this.Text = "HelpScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTempHelp;
        private Button btnClose;
    }
}