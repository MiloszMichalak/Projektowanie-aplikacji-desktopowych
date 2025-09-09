namespace Reszta
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
            kwotaDoZaplaty = new Label();
            zaplacone = new TextBox();
            reszta = new Label();
            Zaplac = new Button();
            SuspendLayout();
            // 
            // kwotaDoZaplaty
            // 
            kwotaDoZaplaty.AutoSize = true;
            kwotaDoZaplaty.Location = new Point(45, 25);
            kwotaDoZaplaty.Name = "kwotaDoZaplaty";
            kwotaDoZaplaty.Size = new Size(46, 16);
            kwotaDoZaplaty.TabIndex = 0;
            kwotaDoZaplaty.Text = "Kwota: ";
            // 
            // zaplacone
            // 
            zaplacone.Location = new Point(208, 29);
            zaplacone.Name = "zaplacone";
            zaplacone.Size = new Size(100, 23);
            zaplacone.TabIndex = 1;
            // 
            // reszta
            // 
            reszta.AutoSize = true;
            reszta.Location = new Point(148, 206);
            reszta.Name = "reszta";
            reszta.Size = new Size(37, 16);
            reszta.TabIndex = 2;
            reszta.Text = "label1";
            // 
            // Zaplac
            // 
            Zaplac.Location = new Point(224, 75);
            Zaplac.Name = "Zaplac";
            Zaplac.Size = new Size(75, 23);
            Zaplac.TabIndex = 3;
            Zaplac.Text = "Zaplac";
            Zaplac.UseVisualStyleBackColor = true;
            Zaplac.Click += Zaplac_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Zaplac);
            Controls.Add(reszta);
            Controls.Add(zaplacone);
            Controls.Add(kwotaDoZaplaty);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label kwotaDoZaplaty;
        private TextBox zaplacone;
        private Label reszta;
        private Button Zaplac;
    }
}
