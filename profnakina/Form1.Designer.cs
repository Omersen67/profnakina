namespace profnakina
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
            this.Vfatura = new System.Windows.Forms.Button();
            this.Mhesabı = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Vfatura
            // 
            this.Vfatura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Vfatura.Location = new System.Drawing.Point(307, 302);
            this.Vfatura.Name = "Vfatura";
            this.Vfatura.Size = new System.Drawing.Size(111, 70);
            this.Vfatura.TabIndex = 0;
            this.Vfatura.Text = "Verilen Fatura";
            this.Vfatura.UseVisualStyleBackColor = true;
            this.Vfatura.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mhesabı
            // 
            this.Mhesabı.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mhesabı.Location = new System.Drawing.Point(307, 213);
            this.Mhesabı.Name = "Mhesabı";
            this.Mhesabı.Size = new System.Drawing.Size(111, 70);
            this.Mhesabı.TabIndex = 1;
            this.Mhesabı.Text = "Maliyet Hesabı";
            this.Mhesabı.UseVisualStyleBackColor = true;
            this.Mhesabı.Click += new System.EventHandler(this.Mhesabı_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(307, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "Alınan Fatura";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Mhesabı);
            this.Controls.Add(this.Vfatura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Vfatura;
        private Button Mhesabı;
        private Button button3;
    }
}