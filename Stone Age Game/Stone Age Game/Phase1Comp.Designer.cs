namespace Stone_Age_Game
{
    partial class Phase1Comp
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
            this.p1Cont = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // p1Cont
            // 
            this.p1Cont.Location = new System.Drawing.Point(136, 116);
            this.p1Cont.Name = "p1Cont";
            this.p1Cont.Size = new System.Drawing.Size(75, 23);
            this.p1Cont.TabIndex = 0;
            this.p1Cont.Text = "Continue";
            this.p1Cont.UseVisualStyleBackColor = true;
            this.p1Cont.Click += new System.EventHandler(this.p1Cont_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "This is the end of phase 1. When you are ready,\r\n press continue to begin phase 2" +
    " of the game...";
            // 
            // Phase1Comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 177);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p1Cont);
            this.Name = "Phase1Comp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phase 1 Complete!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button p1Cont;
        private System.Windows.Forms.Label label1;
    }
}