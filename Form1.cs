using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FM1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int valueInTextBox = int.Parse(inputNumberTB.Text);
                int pointX = 30;
                int pointY = 40;
                this.Controls.Clear();
                for (int i = 0; i < valueInTextBox; i++)
                {
                    TextBox a = new TextBox();
                    Label b = new Label();
                    a.Name = "textbox" + i.ToString();
                    b.Name = "textbox" + i.ToString();
                    a.Location = new Point(pointX, pointY);
                    b.Location = new Point(pointX, pointY);
                    this.Controls.Add(a);
                    this.Controls.Add(b);
                    this.Show();
                    pointY += 20;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }
            
        }
    }
}
