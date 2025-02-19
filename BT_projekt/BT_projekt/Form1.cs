using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_projekt
{
    public partial class Form1 : Form
    {
        bool valasz1 = false;
        bool valasz2 = false;
        bool valasz3 = false;
        bool valasz4 = false;
        bool valasz5 = false;
        bool valasz6 = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnbelep.Enabled=false;
            textBox1.Enabled=false;
           
                      
            check1tru.Click += change1;
            check2tru.Click += change2;
            check3tru.Click += change3;

            check1fal.Click += change1;
            check2fal.Click += change2;
            check3fal.Click += change3;

            txb1.TextChanged += vizsgal;
            txb2.TextChanged += vizsgal;

            check1tru.Click += vizsgal;
            check2tru.Click += vizsgal;
            check3tru.Click += vizsgal;

            check1fal.Click += vizsgal;
            check2fal.Click += vizsgal;
            check3fal.Click += vizsgal;

        }
        private void change1(object sender, EventArgs e)
        {

            if (check1tru == sender)
            {
                check1fal.Checked = false;
               
            }
            else check1tru.Checked = false;
            if (check1fal.Checked || check1tru.Checked) valasz3 = true;
            else valasz3 = false;

        }
        private void change2(object sender, EventArgs e)
        {

            if (check2tru == sender)
            {
                check2fal.Checked = false;
            }
            else check2tru.Checked = false;

            if (check2fal.Checked || check2tru.Checked) valasz4 = true;
            else valasz4 = false;
        }
        private void change3(object sender, EventArgs e)
        {

            if (check3tru == sender)
            {
                check3fal.Checked = false;
            }
            else check3tru.Checked = false;
            if (check3fal.Checked || check3tru.Checked) valasz5 = true;
            else valasz5 = false;
        }
        private void vizsgal(object sender, EventArgs e)
        {
            if (txb1.Text != "") { valasz1 = true; }
            if (txb2.Text != "") { valasz2 = true; }

            if ((check3tru.Checked && check2fal.Checked) || (check1tru.Checked && check3tru.Checked))
            {
                valasz6 = false;
            }else valasz6= true;
            if (valasz1 && valasz2 && valasz3 && valasz4 && valasz5 && valasz6)
            {
                btnbelep.Enabled = true;
            }
            else btnbelep.Enabled = false;
        }

        private void btnbelep_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("docs.txt",true))
            {

                sw.WriteLine($"{txb1.Text} {txb2.Text} {check1tru.Checked} {check2tru.Checked} {check3tru.Checked}");
                
            }
        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }
    }
}
