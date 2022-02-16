using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsForWebService2022_A.ServiceReferenceCogut;

namespace WindowsFormsForWebService2022_A
{
    public partial class Form1 : Form
    {
        WebService2022_ASoapClient client;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new WebService2022_ASoapClient();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            int first_num = Convert.ToInt32(textBox1.Text);
            int second_num = Convert.ToInt32(textBox2.Text);
                        
            int response = client.add(first_num, second_num);
            MessageBox.Show("Addition is: " + response);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int first_num = Convert.ToInt32(textBox1.Text);
            int second_num = Convert.ToInt32(textBox2.Text);

            int response = client.subtract(first_num, second_num);
            MessageBox.Show("Subtraction is: " + response);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int first_num = Convert.ToInt32(textBox1.Text);
            int second_num = Convert.ToInt32(textBox2.Text);

            int response = client.multiply(first_num, second_num);
            MessageBox.Show("Multiplication is: " + response);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int first_num = Convert.ToInt32(textBox1.Text);
            int second_num = Convert.ToInt32(textBox2.Text);

            int response = client.divide(first_num, second_num);
            MessageBox.Show("division is: " + response);
        }

        
    }
}
