namespace TODO2
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
            this.name = new System.Windows.Forms.TextBox();
            this.man = new System.Windows.Forms.RadioButton();
            this.Woman = new System.Windows.Forms.RadioButton();
            this.about = new System.Windows.Forms.RichTextBox();
            this.save = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 1;
            this.name.Text = "Imie";
            // 
            // man
            // 
            this.man.AutoSize = true;
            this.man.Location = new System.Drawing.Point(13, 41);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(54, 20);
            this.man.TabIndex = 2;
            this.man.TabStop = true;
            this.man.Text = "Man";
            this.man.UseVisualStyleBackColor = true;
            // 
            // Woman
            // 
            this.Woman.AutoSize = true;
            this.Woman.Location = new System.Drawing.Point(12, 68);
            this.Woman.Name = "Woman";
            this.Woman.Size = new System.Drawing.Size(75, 20);
            this.Woman.TabIndex = 3;
            this.Woman.TabStop = true;
            this.Woman.Text = "Woman";
            this.Woman.UseVisualStyleBackColor = true;
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(12, 94);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(100, 96);
            this.about.TabIndex = 5;
            this.about.Text = "";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(13, 197);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 6;
            this.save.Text = "Zapisz";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(13, 227);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 7;
            this.close.Text = "Zamknij";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(13, 257);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(99, 23);
            this.show.TabIndex = 8;
            this.show.Text = "Pokaz liste";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show);
            this.Controls.Add(this.close);
            this.Controls.Add(this.save);
            this.Controls.Add(this.about);
            this.Controls.Add(this.Woman);
            this.Controls.Add(this.man);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.RadioButton man;
        private System.Windows.Forms.RadioButton Woman;
        private System.Windows.Forms.RichTextBox about;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button show;
    }
}

