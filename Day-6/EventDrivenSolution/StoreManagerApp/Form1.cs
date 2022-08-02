using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, EventArgs e)
        {
            string email = this.textBox1.Text;
            string password = this.textBox2.Text;
            if(email =="ravi.tambade@transflower.in" && password == "seed")
            {
                MessageBox.Show("Valid User");
            }
            else
            {

            }
        }
    }
}
