using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIApp
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Form theForm=new Form();
            theForm.Load += TheForm_Load;
            theForm.KeyDown += TheForm_KeyDown;
            Application.Run(theForm);  
        }

        private static void TheForm_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyValue.ToString());
        }

        private static void TheForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form is getting loaded");
        }
    }
}
