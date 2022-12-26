namespace Calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.history = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 35);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "%";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.math_Click);
            // 
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.remove.Location = new System.Drawing.Point(132, 121);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(55, 35);
            this.remove.TabIndex = 1;
            this.remove.TabStop = false;
            this.remove.Text = "C";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.button3_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(72, 121);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(55, 35);
            this.clear.TabIndex = 2;
            this.clear.TabStop = false;
            this.clear.Text = "CE";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button3_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete.Location = new System.Drawing.Point(192, 121);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(55, 35);
            this.delete.TabIndex = 3;
            this.delete.TabStop = false;
            this.delete.Text = "del";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button4_Click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.div.Location = new System.Drawing.Point(192, 162);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(55, 35);
            this.div.TabIndex = 7;
            this.div.TabStop = false;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.math_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(72, 162);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 35);
            this.button6.TabIndex = 6;
            this.button6.TabStop = false;
            this.button6.Text = "x^2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.math_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(133, 162);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 35);
            this.button7.TabIndex = 5;
            this.button7.TabStop = false;
            this.button7.Text = "sqr";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.math_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(11, 162);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 35);
            this.button8.TabIndex = 4;
            this.button8.TabStop = false;
            this.button8.Text = "1/x";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.math_Click);
            // 
            // multi
            // 
            this.multi.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multi.Location = new System.Drawing.Point(192, 203);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(55, 35);
            this.multi.TabIndex = 11;
            this.multi.TabStop = false;
            this.multi.Text = "x";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.math_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eight.Location = new System.Drawing.Point(72, 203);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(55, 35);
            this.eight.TabIndex = 10;
            this.eight.TabStop = false;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.button_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nine.Location = new System.Drawing.Point(132, 203);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(55, 35);
            this.nine.TabIndex = 9;
            this.nine.TabStop = false;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.button_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.ControlLight;
            this.seven.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seven.Location = new System.Drawing.Point(12, 203);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(55, 35);
            this.seven.TabIndex = 8;
            this.seven.TabStop = false;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.button_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sub.Location = new System.Drawing.Point(192, 244);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(55, 35);
            this.sub.TabIndex = 15;
            this.sub.TabStop = false;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.math_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.five.Location = new System.Drawing.Point(72, 244);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(55, 35);
            this.five.TabIndex = 14;
            this.five.TabStop = false;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.button_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.six.Location = new System.Drawing.Point(132, 244);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(55, 35);
            this.six.TabIndex = 13;
            this.six.TabStop = false;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.button_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.four.Location = new System.Drawing.Point(12, 244);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(55, 35);
            this.four.TabIndex = 12;
            this.four.TabStop = false;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.button_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plus.Location = new System.Drawing.Point(192, 285);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(55, 35);
            this.plus.TabIndex = 19;
            this.plus.TabStop = false;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.math_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.two.Location = new System.Drawing.Point(72, 285);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(55, 35);
            this.two.TabIndex = 18;
            this.two.TabStop = false;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.button_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.three.Location = new System.Drawing.Point(132, 285);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(55, 35);
            this.three.TabIndex = 17;
            this.three.TabStop = false;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.button_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.one.Location = new System.Drawing.Point(12, 285);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(55, 35);
            this.one.TabIndex = 16;
            this.one.TabStop = false;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.button_Click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equal.Location = new System.Drawing.Point(192, 325);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(55, 35);
            this.equal.TabIndex = 23;
            this.equal.TabStop = false;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.button21_Click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zero.Location = new System.Drawing.Point(72, 325);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(55, 35);
            this.zero.TabIndex = 22;
            this.zero.TabStop = false;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.button_Click);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dot.Location = new System.Drawing.Point(132, 325);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(55, 35);
            this.dot.TabIndex = 21;
            this.dot.TabStop = false;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.button_Click);
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button24.Location = new System.Drawing.Point(12, 325);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(55, 35);
            this.button24.TabIndex = 20;
            this.button24.TabStop = false;
            this.button24.Text = "+/-";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.math_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.Location = new System.Drawing.Point(15, 67);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(232, 31);
            this.textBox.TabIndex = 24;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.SystemColors.ControlLight;
            this.history.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.history.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.history.Location = new System.Drawing.Point(29, 25);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(200, 21);
            this.history.TabIndex = 25;
            this.history.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 364);
            this.Controls.Add(this.history);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.one);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.five);
            this.Controls.Add(this.six);
            this.Controls.Add(this.four);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.div);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(280, 420);
            this.MinimumSize = new System.Drawing.Size(280, 420);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button delete;
        private Button div;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button multi;
        private Button eight;
        private Button nine;
        private Button seven;
        private Button sub;
        private Button five;
        private Button six;
        private Button four;
        private Button plus;
        private Button two;
        private Button three;
        private Button one;
        private Button equal;
        private Button zero;
        private Button dot;
        private Button button24;
        private TextBox textBox;
        private Label history;
        private Button remove;
        private Button clear;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
    }
}