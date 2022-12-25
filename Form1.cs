using System;
namespace Calculator
{
    public partial class Form1 : Form
    {
        double result = 0; 
        string calc = "";
        int opCheck = 0;
        string firstNum = " ";
        string secNum = " ";
        string line = " ";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // button click for the numbers
        private void button_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;

            if (textBox.Text == "0" || opCheck == 1)
            {
                textBox.Clear();
            }
         
            opCheck = 0;
           
            if(but.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text =  textBox.Text + but.Text;
                }
            }

            else
            {
                textBox.Text =  textBox.Text + but.Text;
                secNum = "" + textBox.Text;
 
            }
          
            // changing the focus from other buttons
            label1.Focus(); 
   
        }

        // Clears the text box back to zero - button click for C and CE
        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            result = 0;
            history.Text = "";
        }


        // Performs equality
        private void math_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            if (result != 0)
            {
                equal.PerformClick();
                calc = but.Text;
                history.Text = result + " " + calc;
                opCheck = 1;
            }

            else
            { 
                calc = but.Text;
                result = Convert.ToDouble(textBox.Text);
                opCheck = 1;
                history.Text = result + " " + calc;
                
            }
            firstNum = " " + result;
        }
            

        // Math operators
        private void button21_Click(object sender, EventArgs e)
        {
            history.Text = "";

            if (calc == "+")
            {
             
                textBox.Text = (result + Convert.ToDouble(textBox.Text)).ToString();

            }
            if (calc == "-")
            {
                textBox.Text = (result - Convert.ToDouble(textBox.Text)).ToString();

            }

            if (calc == "x")

                textBox.Text = (result * Convert.ToDouble(textBox.Text)).ToString();


            if (calc == "/")

                textBox.Text = (result / Convert.ToDouble(textBox.Text)).ToString();


            if (calc == "sqr")

                textBox.Text = Math.Sqrt(result).ToString();


            if (calc == "%")

                textBox.Text = (result / 100).ToString();

            if (calc == "1/x")

                textBox.Text = (1 / result).ToString();

            if (calc == "x^2")
                textBox.Text = (result * result).ToString();


            if (calc == "+/-")

                textBox.Text = (-1 * result).ToString();

            // works continously
            result = Convert.ToDouble(textBox.Text);

            line = firstNum + " " + calc + " " + secNum + " " + " = " + result;
            listBox1.Items.Add(line);
            calc = "";

        }

        // keyboard events
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar.ToString() == ".")

                dot.PerformClick();
            if (e.KeyChar.ToString() == "0")
            
                zero.PerformClick();
            
            if (e.KeyChar.ToString() == "1")
            
                one.PerformClick();
            
            if (e.KeyChar.ToString() == "2")
            
                two.PerformClick();

            if (e.KeyChar.ToString() == "3")
            
                three.PerformClick();
            
            if (e.KeyChar.ToString() == "4")
            
                four.PerformClick();
            
            if (e.KeyChar.ToString() == "5")
            
                five.PerformClick();

            if (e.KeyChar.ToString() == "6")
            
                six.PerformClick();
            
            if (e.KeyChar.ToString() == "7")
            
                seven.PerformClick();
            
            if (e.KeyChar.ToString() == "8")
            
                eight.PerformClick();
            
            if (e.KeyChar.ToString() == "9")
            
                nine.PerformClick();
            
            if (e.KeyChar.ToString() == "=")
            
                equal.PerformClick();
            
            if (e.KeyChar.ToString() == "+")
            
                plus.PerformClick();
            
            if (e.KeyChar.ToString() == "-")
            
                sub.PerformClick();
            
            if (e.KeyChar.ToString() == "x" || e.KeyChar.ToString() == "*")
            
                multi.PerformClick();
            
            if (e.KeyChar.ToString() == "/")
            
                div.PerformClick();
            if(e.KeyChar.ToString() ==  "Backspace")
                remove.PerformClick();
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            
                equal.PerformClick();
           
            if(e.KeyCode == Keys.Delete)
                remove.PerformClick();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
                delete.PerformClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int stLen = textBox.TextLength;
            textBox.Text = textBox.Text.Substring(0, stLen - 1);
            if(textBox.Text.Length == 0)
            {
                textBox.Text = "0";
                history.Text = "";
            }

         
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
           // listBox1.DisplayMember = "History is cleared";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}