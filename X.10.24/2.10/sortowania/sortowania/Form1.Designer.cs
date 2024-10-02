namespace sortowania
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
            this.bubble = new System.Windows.Forms.RadioButton();
            this.hoare = new System.Windows.Forms.RadioButton();
            this.lomuto = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ileLiczb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.liczby = new System.Windows.Forms.Label();
            this.losuj = new System.Windows.Forms.Button();
            this.sort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bubble
            // 
            this.bubble.AutoSize = true;
            this.bubble.Location = new System.Drawing.Point(6, 21);
            this.bubble.Name = "bubble";
            this.bubble.Size = new System.Drawing.Size(96, 20);
            this.bubble.TabIndex = 0;
            this.bubble.TabStop = true;
            this.bubble.Text = "Bubble sort";
            this.bubble.UseVisualStyleBackColor = true;
            // 
            // hoare
            // 
            this.hoare.AutoSize = true;
            this.hoare.Location = new System.Drawing.Point(6, 47);
            this.hoare.Name = "hoare";
            this.hoare.Size = new System.Drawing.Size(91, 20);
            this.hoare.TabIndex = 1;
            this.hoare.TabStop = true;
            this.hoare.Text = "Hoare sort";
            this.hoare.UseVisualStyleBackColor = true;
            // 
            // lomuto
            // 
            this.lomuto.AutoSize = true;
            this.lomuto.Location = new System.Drawing.Point(6, 73);
            this.lomuto.Name = "lomuto";
            this.lomuto.Size = new System.Drawing.Size(97, 20);
            this.lomuto.TabIndex = 2;
            this.lomuto.TabStop = true;
            this.lomuto.Text = "Lomuto sort";
            this.lomuto.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bubble);
            this.groupBox1.Controls.Add(this.lomuto);
            this.groupBox1.Controls.Add(this.hoare);
            this.groupBox1.Location = new System.Drawing.Point(57, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ileLiczb
            // 
            this.ileLiczb.Location = new System.Drawing.Point(57, 32);
            this.ileLiczb.Name = "ileLiczb";
            this.ileLiczb.Size = new System.Drawing.Size(100, 22);
            this.ileLiczb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ile liczb";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // liczby
            // 
            this.liczby.AutoSize = true;
            this.liczby.Location = new System.Drawing.Point(57, 61);
            this.liczby.Name = "liczby";
            this.liczby.Size = new System.Drawing.Size(51, 16);
            this.liczby.TabIndex = 6;
            this.liczby.Text = "Liczby: ";
            // 
            // losuj
            // 
            this.losuj.Location = new System.Drawing.Point(57, 81);
            this.losuj.Name = "losuj";
            this.losuj.Size = new System.Drawing.Size(75, 23);
            this.losuj.TabIndex = 7;
            this.losuj.Text = "losuj";
            this.losuj.UseVisualStyleBackColor = true;
            this.losuj.Click += new System.EventHandler(this.losuj_Click);
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(57, 253);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(75, 23);
            this.sort.TabIndex = 8;
            this.sort.Text = "Sortuj";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.losuj);
            this.Controls.Add(this.liczby);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ileLiczb);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton bubble;
        private System.Windows.Forms.RadioButton hoare;
        private System.Windows.Forms.RadioButton lomuto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ileLiczb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label liczby;
        private System.Windows.Forms.Button losuj;
        private System.Windows.Forms.Button sort;
    }
}

