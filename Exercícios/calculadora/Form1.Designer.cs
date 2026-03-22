namespace calculadora
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
            this.result = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.i = new System.Windows.Forms.Button();
            this.v = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(12, 12);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(403, 68);
            this.result.TabIndex = 0;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.c);
            this.groupBox1.Controls.Add(this.div);
            this.groupBox1.Controls.Add(this.mult);
            this.groupBox1.Controls.Add(this.sub);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.i);
            this.groupBox1.Controls.Add(this.v);
            this.groupBox1.Controls.Add(this.n0);
            this.groupBox1.Controls.Add(this.n9);
            this.groupBox1.Controls.Add(this.n8);
            this.groupBox1.Controls.Add(this.n7);
            this.groupBox1.Controls.Add(this.n6);
            this.groupBox1.Controls.Add(this.n5);
            this.groupBox1.Controls.Add(this.n4);
            this.groupBox1.Controls.Add(this.n3);
            this.groupBox1.Controls.Add(this.n2);
            this.groupBox1.Controls.Add(this.n1);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(6, 129);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(75, 23);
            this.c.TabIndex = 16;
            this.c.Text = "CE";
            this.c.UseVisualStyleBackColor = true;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(289, 129);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 23);
            this.div.TabIndex = 15;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(289, 100);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(75, 23);
            this.mult.TabIndex = 14;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(289, 71);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 23);
            this.sub.TabIndex = 13;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(289, 42);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 12;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // i
            // 
            this.i.Location = new System.Drawing.Point(87, 158);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(75, 23);
            this.i.TabIndex = 11;
            this.i.Text = "=";
            this.i.UseVisualStyleBackColor = true;
            this.i.Click += new System.EventHandler(this.i_Click);
            // 
            // v
            // 
            this.v.Location = new System.Drawing.Point(168, 129);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(75, 23);
            this.v.TabIndex = 10;
            this.v.Text = ",";
            this.v.UseVisualStyleBackColor = true;
            // 
            // n0
            // 
            this.n0.Location = new System.Drawing.Point(87, 129);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(75, 23);
            this.n0.TabIndex = 9;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // n9
            // 
            this.n9.Location = new System.Drawing.Point(168, 100);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(75, 23);
            this.n9.TabIndex = 8;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n8
            // 
            this.n8.Location = new System.Drawing.Point(87, 100);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(75, 23);
            this.n8.TabIndex = 7;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n7
            // 
            this.n7.Location = new System.Drawing.Point(6, 100);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(75, 23);
            this.n7.TabIndex = 6;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n6
            // 
            this.n6.Location = new System.Drawing.Point(168, 71);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(75, 23);
            this.n6.TabIndex = 5;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // n5
            // 
            this.n5.Location = new System.Drawing.Point(87, 71);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(75, 23);
            this.n5.TabIndex = 4;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(6, 71);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(75, 23);
            this.n4.TabIndex = 3;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(168, 42);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(75, 23);
            this.n3.TabIndex = 2;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(87, 42);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(75, 23);
            this.n2.TabIndex = 1;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n1
            // 
            this.n1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.n1.Location = new System.Drawing.Point(6, 42);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(75, 23);
            this.n1.TabIndex = 0;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 368);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.result);
            this.Name = "Form1";
            this.Text = "calculadora";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button v;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button i;
        private System.Windows.Forms.Button button1;
    }
}

