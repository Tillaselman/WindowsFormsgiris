using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabcontrolwinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        //tab control nesnesi form üzerinde bizlere sekmeler verir
        //tab control nesnesinin çerçevesine tıklayıp Dock bölümüne gelip tab controlu formun içinde istediğimiz yere alabiliriz
        //form nesnesinin boyutlarını startta kitlemek istiyorsak -formborderstyle_fixedtoolwindow- dememiz yeterli


    }
}
