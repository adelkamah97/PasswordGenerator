namespace PasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pswlen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Sym = new System.Windows.Forms.CheckBox();
            this.Lower = new System.Windows.Forms.CheckBox();
            this.Num = new System.Windows.Forms.CheckBox();
            this.Upper = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Copybtn = new System.Windows.Forms.Button();
            this.gnrtbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(281, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Generator";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pswlen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Sym);
            this.groupBox1.Controls.Add(this.Lower);
            this.groupBox1.Controls.Add(this.Num);
            this.groupBox1.Controls.Add(this.Upper);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 340);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Options :";
            // 
            // pswlen
            // 
            this.pswlen.Location = new System.Drawing.Point(213, 282);
            this.pswlen.Name = "pswlen";
            this.pswlen.Size = new System.Drawing.Size(57, 39);
            this.pswlen.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password Length";
            // 
            // Sym
            // 
            this.Sym.AutoSize = true;
            this.Sym.Location = new System.Drawing.Point(21, 232);
            this.Sym.Name = "Sym";
            this.Sym.Size = new System.Drawing.Size(122, 36);
            this.Sym.TabIndex = 12;
            this.Sym.Text = "Symbols";
            this.Sym.UseVisualStyleBackColor = true;
            // 
            // Lower
            // 
            this.Lower.AutoSize = true;
            this.Lower.Location = new System.Drawing.Point(21, 116);
            this.Lower.Name = "Lower";
            this.Lower.Size = new System.Drawing.Size(220, 36);
            this.Lower.TabIndex = 11;
            this.Lower.Text = "Lowercase Letters";
            this.Lower.UseVisualStyleBackColor = true;
            // 
            // Num
            // 
            this.Num.AutoSize = true;
            this.Num.Location = new System.Drawing.Point(21, 174);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(131, 36);
            this.Num.TabIndex = 10;
            this.Num.Text = "Numbers";
            this.Num.UseVisualStyleBackColor = true;
            // 
            // Upper
            // 
            this.Upper.AutoSize = true;
            this.Upper.Location = new System.Drawing.Point(21, 58);
            this.Upper.Name = "Upper";
            this.Upper.Size = new System.Drawing.Size(222, 36);
            this.Upper.TabIndex = 9;
            this.Upper.Text = "Uppercase Letters";
            this.Upper.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Hacen Samra", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(333, 218);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 85);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Copybtn
            // 
            this.Copybtn.BackColor = System.Drawing.Color.Aqua;
            this.Copybtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Copybtn.FlatAppearance.BorderSize = 0;
            this.Copybtn.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Copybtn.Location = new System.Drawing.Point(679, 235);
            this.Copybtn.Name = "Copybtn";
            this.Copybtn.Size = new System.Drawing.Size(99, 50);
            this.Copybtn.TabIndex = 7;
            this.Copybtn.Text = "Copy";
            this.Copybtn.UseVisualStyleBackColor = false;
            this.Copybtn.Click += new System.EventHandler(this.Copybtn_Click);
            // 
            // gnrtbtn
            // 
            this.gnrtbtn.BackColor = System.Drawing.Color.Black;
            this.gnrtbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gnrtbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gnrtbtn.Location = new System.Drawing.Point(243, 475);
            this.gnrtbtn.Name = "gnrtbtn";
            this.gnrtbtn.Size = new System.Drawing.Size(293, 69);
            this.gnrtbtn.TabIndex = 8;
            this.gnrtbtn.Text = "Generate";
            this.gnrtbtn.UseVisualStyleBackColor = false;
            this.gnrtbtn.Click += new System.EventHandler(this.gnrtbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.gnrtbtn);
            this.Controls.Add(this.Copybtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator 1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button Copybtn;
        private Button gnrtbtn;
        private CheckBox Sym;
        private CheckBox Lower;
        private CheckBox Num;
        private CheckBox Upper;
        private TextBox pswlen;
        private Label label2;
    }
}