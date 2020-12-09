namespace Stone_Age_Game
{
    partial class GameStart
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
            this.label1 = new System.Windows.Forms.Label();
            this.contBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your game has started! Please arrange yourselves \r\n in the order you wish to play" +
    " and continue...";
            // 
            // contBtn
            // 
            this.contBtn.Location = new System.Drawing.Point(123, 111);
            this.contBtn.Name = "contBtn";
            this.contBtn.Size = new System.Drawing.Size(75, 23);
            this.contBtn.TabIndex = 1;
            this.contBtn.Text = "Continue";
            this.contBtn.UseVisualStyleBackColor = true;
            this.contBtn.Click += new System.EventHandler(this.contBtn_Click);
            // 
            // GameStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 179);
            this.Controls.Add(this.contBtn);
            this.Controls.Add(this.label1);
            this.Name = "GameStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Started!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button contBtn;
    }
}