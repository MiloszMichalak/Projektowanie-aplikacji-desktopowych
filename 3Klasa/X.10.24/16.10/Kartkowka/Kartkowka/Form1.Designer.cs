namespace Kartkowka
{
    partial class Form1
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
            this.number1 = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.blad = new System.Windows.Forms.Label();
            this.sprawdz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(182, 32);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(100, 22);
            this.number1.TabIndex = 0;
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(444, 32);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(100, 22);
            this.number2.TabIndex = 1;
            // 
            // blad
            // 
            this.blad.AutoSize = true;
            this.blad.Location = new System.Drawing.Point(291, 94);
            this.blad.Name = "blad";
            this.blad.Size = new System.Drawing.Size(0, 16);
            this.blad.TabIndex = 2;
            // 
            // sprawdz
            // 
            this.sprawdz.Location = new System.Drawing.Point(313, 152);
            this.sprawdz.Name = "sprawdz";
            this.sprawdz.Size = new System.Drawing.Size(75, 23);
            this.sprawdz.TabIndex = 3;
            this.sprawdz.Text = "button1";
            this.sprawdz.UseVisualStyleBackColor = true;
            this.sprawdz.Click += new System.EventHandler(this.sprawdz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sprawdz);
            this.Controls.Add(this.blad);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.Label blad;
        private System.Windows.Forms.Button sprawdz;
    }
}

