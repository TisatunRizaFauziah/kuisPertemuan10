using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kuisPertemuan10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double temp1;
        double temp2;
        double hasil;
        char lambang;

        private void txthasil_TextChanged(object sender, EventArgs e)

        { 
            temp1=Convert.ToDouble(txtangka1.Text);
            temp2=Convert.ToDouble(txtangka2.Text);
            Button btnOP = (Button)sender;

            if (lambang == '+')
            {
                hasil = temp1 + temp2;
            }
            else if (lambang == '-')
            {
                hasil = temp1 - temp2;
            }
            else if (lambang == ':')
            {
                hasil = temp1 / temp2;
            }
            else if (lambang == '*')
            {
                hasil = temp1 * temp2;
            }
           
        }

        
    }
}
