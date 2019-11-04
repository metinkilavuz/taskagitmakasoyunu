namespace TasMakasKagitOyunu
{
    partial class Form3
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
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnd
            // 
            this.lblEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnd.ForeColor = System.Drawing.Color.Black;
            this.lblEnd.Location = new System.Drawing.Point(241, 155);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(319, 59);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "label1";
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(331, 259);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(132, 36);
            this.btnPlayAgain.TabIndex = 2;
            this.btnPlayAgain.Text = "Tekrar Oyna";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.btnPlayAgain);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}