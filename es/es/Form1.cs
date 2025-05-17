using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace es
{
    public partial class Form1 : Form
    {
        string[] parole = new string[200];
        int tentativi = 0;
        public Form1()
        {
            InitializeComponent();
            string elenco = @"parole.txt";
            using (StreamReader sr = new StreamReader(elenco))
            {
                int cont = 0;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    parole[cont] = line;
                    cont++;
                }
            }
            Random rand = new Random(Environment.TickCount);
            int num = rand.Next(0, 200);
            MessageBox.Show("La parola è: " + parole[num]);
            displaypar(parole[num], "");
        }

        private void displaypar(string parola, string lettereindovinate)
        {
            parola = parola.ToUpper();
            string lett1 = parola[0].ToString();

            int c = 0;
                for (int i = 1; i < parola.Length - 1; i++)
                {
                    lett1 += "_ ";
                }

            char[] lettind = lettereindovinate.ToCharArray();
            char[] temp = lett1.ToCharArray();

            for (int i = 1; i < parola.Length; i++)
            {
                if (parola[i] == lettereindovinate[c])
                {
                    temp = lettereindovinate;
                }
            }
            /*}
            else
            {
                for(int i = 0; i < lettereindovinate.Length; i++)
                {
                    for(int j = 1; j < parola.Length - 1; i++)
                    {
                        if()
                        {

                        }
                    }
                }
            }*/
            lett1 += parola[parola.Length - 1].ToString();
            lbl_parola.Text = lett1;
        }

        private bool controlla(string tentativo)
        {
            string guess = lbl_parola.Text;
            string lettereindovinate = "";
            if (tentativo != guess)
            {
                for(int i = 1; i < guess.Length - 1; i ++)
                {
                    if (tentativo[i] == guess[i])
                    {
                        lettereindovinate += tentativo[i].ToString();
                    }
                }
                tentativi++;
                displaypar(guess, lettereindovinate);
                return false;
            } else
            {
                return true;
            }
        }

        private void btn_guess_Click(object sender, EventArgs e)
        {
            string tentativo = txt_guess.Text.ToUpper();

            if(controlla(tentativo))
            {
                MessageBox.Show($"Hai indovinato la parola in {tentativi}");
            }
        }
    }
}
