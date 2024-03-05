using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace listbox
{
    public partial class Form1 : Form
    {

          
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList dizi = new ArrayList();

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void texdegerbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            //tex boxta yazdığım itemin bana listboxta kaçıncı indexte olduğunu verecek o yüzden array kullandım
            listBox.Items.Add(texdegerbox.Text);
            dizi.Add(texdegerbox.Text);
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            string sildeger= listBox.SelectedItem.ToString();
            listBox.Items.Remove(sildeger);
           
        }

        private void bulbtn_Click(object sender, EventArgs e)
        { 
            int seçilenitem=listBox.SelectedIndex;
            MessageBox.Show("listbox eleman sayısı : " + listBox.Items.Count.ToString()+"  "+"kaçıncı index  "+seçilenitem);
        }

        private void temizlebtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void indexbulbtn_Click(object sender, EventArgs e)
        {
            string diziindex= texdegerbox.Text;
            int indexyakalama=dizi.IndexOf(diziindex);
            MessageBox.Show(indexyakalama + "  'ıncı indextinde");
        }
    }
}
