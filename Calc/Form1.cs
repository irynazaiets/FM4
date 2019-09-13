using System;
using System.Windows.Forms;



namespace Calc
{
    public partial class Form1 : Form
    {
        
        bool flag = false;
        double a,b,c;
        bool znak = true;
        double resault = 0;
        string operation = "";
        bool enter_value = false;
        
        


        /*private void Start()
        {
           
                
                button19.Enabled = button18.Enabled =
                button20.Enabled =
                button1.Enabled = button10.Enabled = button11.Enabled =
                button2.Enabled = button3.Enabled = button4.Enabled =
                button5.Enabled = button6.Enabled = button7.Enabled =
                button9.Enabled = button8.Enabled =
                button12.Enabled = button13.Enabled = button14.Enabled = 
                button15.Enabled = button16.Enabled = button17.Enabled = false;
            button22.Enabled = button21.Enabled = true;
        }
        private void Start2()
        {
            

                button19.Enabled = button18.Enabled =
                button20.Enabled =  
                button1.Enabled = button10.Enabled = button11.Enabled =
                button2.Enabled = button3.Enabled = button4.Enabled =
                button5.Enabled = button6.Enabled = button7.Enabled =
                button9.Enabled = button8.Enabled =
                button12.Enabled = button13.Enabled = button14.Enabled =
                button15.Enabled = button16.Enabled = button17.Enabled = true;
            button22.Enabled = button21.Enabled = false;
        }
        */
        public Form1()
        {
            InitializeComponent();
            button21.Enabled = true;
            label4.Text = "0";
            //this.dateTimePicker3.ValueChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1_DateChanged);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 349;
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width= 349;
            //Start2();
            
        }

        private void geometryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 688;
           // Start();

        }

        private void Button_Click(object sender, EventArgs e)
        {
            
            if ((textBox1.Text == "0") || (enter_value))
                textBox1.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label4.Text = "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";

            if (textBox2.Text.Length > 0)
                textBox2.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            if (textBox2.Text == "")
                textBox2.Text = "0";

            if (textBox3.Text.Length > 0)
                textBox3.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            if (textBox3.Text == "")
                textBox3.Text = "0";

            if (textBox4.Text.Length > 0)
                textBox4.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            if (textBox4.Text == "")
                textBox4.Text = "0";
        }

        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            resault = double.Parse(textBox1.Text);
            textBox1.Text = "";
            label4.Text = System.Convert.ToString(resault+Convert.ToDouble(label4.Text)) + " " + operation;

        }

        private void button21_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox2.Text);
            b = double.Parse(textBox3.Text);
            c = double.Parse(textBox4.Text);

            double p = Perimetr() / 2;

            textBox6.Text = Math.Sqrt(p*(p-a)*(p-b)*(p-c)).ToString();
        }


        private double Perimetr()
        {
            return a + b + c;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label4.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (flag == true)
            {
                textBox1.Text = "0";
               flag = false;
            }
            
            
        }

        private void Form1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((int)e.KeyChar < 48 && (int)e.KeyChar != 46 || (int)e.KeyChar > 57)
            {
                
                
                e.Handled = true;
                flag = true;              
            }
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label4.Text = "0";
            switch (operation)
            {
                case "+":
                    textBox1.Text = (resault + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resault - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resault * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resault / double.Parse(textBox1.Text)).ToString();
                    break;
                
            }
            enter_value = true;
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            /*
            var selectedDate1 = dateTimePicker3.Value.CompareTo(dateTimePicker4.Value).ToString();
            Console.WriteLine(selectedDate1);
            */

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button19_Click(this,null);
            
            else if (e.KeyCode == Keys.Enter)
               button19_Click(this, null);
            else if (e.KeyCode == Keys.Enter)
                button19_Click(this, null);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
