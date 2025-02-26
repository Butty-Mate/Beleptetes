using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace TT_BM_Belepteto_rendszer
{
    public partial class Beléptető_Rendszer : Form
    {
        public Beléptető_Rendszer()
        {
            InitializeComponent();
            textBox1.Text = "Gipsz Jakab";
            textBox2.Text = "123456BB";
            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
            textBox1.Enter += txtNev_Enter;
            textBox1.Leave += txtNev_Leave;
            textBox2.Enter += txtSzemelyiSzam_Enter;
            textBox2.Leave += txtSzemelyiSzam_Leave;
            textBox1.TextChanged += EllenorizMezoket;
            textBox2.TextChanged += EllenorizMezoket;
            checkBox1.CheckedChanged += CheckBox_CheckedChanged;
            checkBox2.CheckedChanged += CheckBox_CheckedChanged;
            checkBox3.CheckedChanged += CheckBox_CheckedChanged;
            checkBox4.CheckedChanged += CheckBox_CheckedChanged;
            checkBox5.CheckedChanged += CheckBox_CheckedChanged;
            checkBox6.CheckedChanged += CheckBox_CheckedChanged;
            button1.Enabled = false;
        }

        private void txtNev_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Gipsz Jakab")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void txtNev_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Gipsz Jakab";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void txtSzemelyiSzam_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "123456BB")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void txtSzemelyiSzam_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "123456BB";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedCheckBox = sender as CheckBox;


            if (clickedCheckBox == checkBox1 && checkBox1.Checked)
                checkBox2.Checked = false;
            else if (clickedCheckBox == checkBox2 && checkBox2.Checked)
                checkBox1.Checked = false;


            if (clickedCheckBox == checkBox3 && checkBox3.Checked)
                checkBox4.Checked = false;
            else if (clickedCheckBox == checkBox4 && checkBox4.Checked)
                checkBox3.Checked = false;

            if (clickedCheckBox == checkBox5 && checkBox5.Checked)
                checkBox6.Checked = false;
            else if (clickedCheckBox == checkBox6 && checkBox6.Checked)
                checkBox5.Checked = false;

            EllenorizMezoket(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Kérjük, mérje meg a stresszszintet a belépés előtt!");
                return;
            }

            string nev = textBox1.Text;
            string szemelyiSzam = textBox2.Text;
            bool vezet = checkBox1.Checked;
            bool betoltotte18 = checkBox3.Checked;
            bool iszik = checkBox5.Checked;

            if (!betoltotte18 && iszik)
            {
                MessageBox.Show("Nem vagy elég idős az alkoholfogyasztáshoz.");
                return;
            }

            if (vezet && iszik)
            {
                MessageBox.Show("Nem ihat alkoholt, ha vezet.");
                return;
            }

            MessageBox.Show("Belépés engedélyezve.");
            MentesFajlba(nev, szemelyiSzam, vezet, betoltotte18, iszik);
            MezokTorlese();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random veletlen = new Random();
            int stresszint = veletlen.Next(0, 101);
            textBox3.Text = stresszint.ToString();
            textBox3.Visible = true;

            if (stresszint > 60)
            {
                textBox3.ForeColor = Color.Red;
            }
            else
            {
                textBox3.ForeColor = Color.Green;
            }
        }

        private void MentesFajlba(string nev, string szemelyiSzam, bool vezet, bool betoltotte18, bool iszik)
        {

            string nevKod = "10101";
            string szemelyiSzamKod = "10010";
            string vezetKod = "11011";
            string betoltotte18Kod = "11100";
            string iszikKod = "11111";
            string gyanusSzemelyKod = "11101"; 


            string nevBináris = SzovegToBináris(nev);
            string szemelyiSzamBináris = SzovegToBináris(szemelyiSzam);


            string vezetBináris = vezet ? "1" : "0";
            string betoltotte18Bináris = betoltotte18 ? "1" : "0";
            string iszikBináris = iszik ? "1" : "0";

            bool gyanusSzemely = int.Parse(textBox3.Text) > 60;
            string gyanusSzemelyBináris = gyanusSzemely ? "1" : "0";


            /**
            Adatstruktúra magyarázata:
            -----------------
            - Név: 10101 - A felhasználó neve bináris formában.
            - Személyi igazolvány: 10010 - A személyi igazolvány száma bináris formában.
            - Vezet: 11011 - Logikai érték: 1 (igen) vagy 0 (nem).
            - Betöltötte a 18-at: 11100 - Logikai érték: 1 (igen) vagy 0 (nem).
            - Iszik: 11111 - Logikai érték: 1 (igen) vagy 0 (nem).
            - Gyanús személy: 11101 - Logikai érték: 1 (igen) vagy 0 (nem). Ha a stresszszint > 60, akkor 1, egyébként 0.
            ---------------------
            - A szöveges adatok karakterenként bináris formába kerülnek átalakításra.
            - Minden adat külön sorba kerül, és személyenként két üres sor választja el az adatokat.
            - Az új adatok a régi fájlhoz kerülnek hozzáadásra.
             **/
            string tartalom = $"{nevKod}{nevBináris}\n" +
                             $"{szemelyiSzamKod}{szemelyiSzamBináris}\n" +
                             $"{vezetKod}{vezetBináris}\n" +
                             $"{betoltotte18Kod}{betoltotte18Bináris}\n" +
                             $"{iszikKod}{iszikBináris}\n" +
                             $"{gyanusSzemelyKod}{gyanusSzemelyBináris}\n\n\n"; 


            File.AppendAllText("adat.txt", tartalom);
        }

        private void MezokTorlese()
        {
            textBox1.Text = "Gipsz Jakab";
            textBox2.Text = "123456BB";
            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            textBox3.Text = " ";
            textBox3.Visible = false;
        }

        private void EllenorizMezoket(object sender, EventArgs e)
        {

            bool nevHelyes = textBox1.Text != "Gipsz Jakab" &&
                            !string.IsNullOrWhiteSpace(textBox1.Text) &&
                            textBox1.Text.Contains(" ") &&
                            textBox1.Text.Trim().Split(' ').Length >= 2;
            bool szemelyiSzamHelyes = Regex.IsMatch(textBox2.Text, @"^\d{6}[A-Za-z]{2}$");


            bool vezetHelyes = checkBox1.Checked || checkBox2.Checked;
            bool betoltotte18Helyes = checkBox3.Checked || checkBox4.Checked;
            bool iszikHelyes = checkBox5.Checked || checkBox6.Checked;


            bool iszikEngedelyezett = (!checkBox5.Checked || (checkBox3.Checked && !checkBox1.Checked));

            button1.Enabled = nevHelyes && szemelyiSzamHelyes && vezetHelyes && betoltotte18Helyes && iszikHelyes && iszikEngedelyezett;
        }

        private string SzovegToBináris(string szoveg)
        {
            string bináris = "";
            foreach (char karakter in szoveg)
            {
                bináris += Convert.ToString(karakter, 2).PadLeft(8, '0');
            }
            return bináris.Trim();
        }
    }
}