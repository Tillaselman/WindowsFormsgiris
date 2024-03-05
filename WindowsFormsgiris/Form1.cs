using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsgiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ortalama = ((Convert.ToDouble(textboxnot1.Text)*0.3) + (Convert.ToDouble(textBoxnot2.Text)*0.7)) ;
            hesaplananort.Text = ortalama.ToString();
        }
    }
}
