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

namespace mulasztasokGUI_20241210
{
    public partial class Form1 : Form
    {
        List<Mulasztas> lista = new List<Mulasztas>();
        string elsosor;
        void betoltes()
        {
            lista.Clear();
            FileStream fs = new FileStream("..\\..\\src\\szeptember.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            elsosor = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Mulasztas m = new Mulasztas(sr.ReadLine());
                lista.Add(m);
                dgvadatok.Rows.Add(m.Nev, m.Osztaly, m.Hanyadika, m.Igazolt, m.Neigazolt, m.NapiHianyzasSzamolas());
                rtbadatok.Text = rtbadatok.Text+m.Nev+";"+m.Osztaly+";"+m.Hanyadika+";"+m.Igazolt+";"+m.Neigazolt+";"+m.NapiHianyzasSzamolas()+"\n";
            }
            sr.Close();
            fs.Close();
            int max = 0;
            for(int i = 0; i < lista.Count; i++)
            {
                if(lista[i].NapiHianyzasSzamolas() > max)
                {
                    max = lista[i].NapiHianyzasSzamolas();
                }
            }
            for(int i = 0; i < lista.Count; i++)
            {
                if (lista[i].NapiHianyzasSzamolas() == max)
                {
                    rtbtanulok.Text = rtbtanulok.Text + lista[i].Nev + "\n";
                }
            }
            lboraksz.Text = "Órák száma: " + max.ToString();

            for(int i =0; i < 30; i++)
            {
                cbhanyadik.Items.Add(i+1).ToString();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            betoltes();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(txigazolt.Text.Length > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txigazolt.Text);
                }
                catch
                {
                    MessageBox.Show("Egész számot adjon meg", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txigazolt.Clear();
                    txigazolt.Focus();
                }

            }
        }

        private void txnemigaolt_TextChanged(object sender, EventArgs e)
        {
            if (txnemigaolt.Text.Length > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txnemigaolt.Text);
                }
                catch
                {
                    MessageBox.Show("Egész számot adjon meg", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txnemigaolt.Clear();
                    txnemigaolt.Focus();
                }

            }
        }
    }
}
