namespace LetterGame
{
    partial class frmMain
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
            this.lblLetter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLetter
            // 
            this.lblLetter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 200F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter.Location = new System.Drawing.Point(0, 0);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(621, 441);
            this.lblLetter.TabIndex = 0;
            this.lblLetter.Text = "lblLetter";
            this.lblLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 441);
            this.Controls.Add(this.lblLetter);
            this.Name = "frmMain";
            this.Text = "Letter Game";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMain_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLetter;
    }
}

