using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_String_Variables_in_CSharp.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStrings_Click(object sender, EventArgs e)
        {
            string firstName = txtBox.Text;
            const string YourNameIs = "Your name is: ";
            string name = YourNameIs + firstName;
            lblYourNameIs.Text = name;
            txtYourNameIs.Text = name;
            //MessageBox.Show(name);            
        }
    }
}
