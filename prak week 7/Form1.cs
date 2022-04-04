using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prak_week_7
{
    public partial class FormPandaQuiz : Form
    {
        public FormPandaQuiz()
        {
            InitializeComponent();
        }
        public static List<char> alpha = new List<char>();
        public static int urutan = 0;
        public static int[] urutanHur = new int[2];
        public static int[] urutanHur2 = new int[2];
        public static int cekHur = 0;
        public static int cekHur2 = 0;
        private void FormPandaQuiz_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                for (char a = 'A'; a <= 'Z'; a++)
                {
                    alpha.Add(a);
                    urutan++;
                }
            }
        }
       
        private void textBoxInputHur_TextChanged(object sender, EventArgs e)
        {
            if (textBoxInputKal.Text.ToUpper().Contains(textBoxInputHur.Text.ToUpper()))
            {
                for (int i = 0; i < 2; i++)
                {
                    for (char a = 'A'; a <= 'Z'; a++)
                    {
                        if (textBoxInputHur.Text.ToUpper() == a.ToString())
                        {
                            urutanHur[i] = cekHur;
                        }
                        cekHur++;
                    }
                    cekHur = 0;
                }
            }
            else
            {
                MessageBox.Show("Tidak ada huruf tersebut di kalimat");
                textBoxInputHur.Clear();
            }
        }

        private void textBoxInputHur2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxInputKal.Text.ToUpper().Contains(textBoxInputHur.Text.ToUpper()))
            {
                for (int i = 0; i < 2; i++)
                {
                    for (char a = 'A'; a <= 'Z'; a++)
                    {
                        if (textBoxInputHur2.Text.ToUpper() == a.ToString())
                        {
                            urutanHur2[i] = cekHur2;
                        }
                        cekHur2++;
                    }
                    cekHur2 = 0;
                }
            }
            else
            {
                MessageBox.Show("Tidak ada huruf tersebut di kalimat");
                textBoxInputHur2.Clear();
            }
        }
        public static int selisihUrutanMore = 0;
        public static int selisihUrutanLess = 0;
        public static int[] valueTiapHuruf = new int[100];
        public static int[] valueOutput = new int[100];
        public static string[] isiOutput = new string[100];
        public static char[] inputArray = new char[100];
        public static string output;
       
        private void buttonKonfirm_Click(object sender, EventArgs e)
        {
            inputArray = textBoxInputKal.Text.ToUpper().ToArray();
            if (urutanHur[0] > urutanHur2[0])
            {
                selisihUrutanLess = urutanHur[0] - urutanHur2[0];
            }
            /*else if (urutanHur[1] > urutanHur2[1])
            {
                selisihUrutanLess = urutanHur[1] - urutanHur2[1];
            }*/
            else if (urutanHur2[0] > urutanHur[0])
            {
                selisihUrutanMore = urutanHur2[0] - urutanHur[0];
            }
            /*else if (urutanHur2[1] > urutanHur[1])
            {
                selisihUrutanMore = urutanHur2[1] - urutanHur[1];
            }*/

            for (int s = 0; s < textBoxInputKal.Text.Length; s++)
            {
                //cek tiap huruf di arrayInput, valuenya berapa
                for (char a = 'A'; a <= 'Z'; a++)
                {
                    //jika huruf arrayInput ke s sama dengan a
                    if (inputArray[s] == a)
                    {
                        valueTiapHuruf[s] = alpha.IndexOf(a);
                    }
                }
            }
            //mazz
            //valueTiapHuruf: [1] = 13; [2] = 4; [3] = 25; [4] = 25 etc
            //textboxinputhur = Z, urutanHur[0] = 25, urutanHur[1] = 51
            //textBoxInpurHur2 = M, urutanHur2[0] = 13, urutanHur2[1] = 39
            //urutanHur < urutanHur2, selisihUrutanMore = 13
            //ubah value ke alphabet
            //isiOutput[i], valueOutput[i]
            for (int i = 0; i < textBoxInputKal.Text.Length; i++)
            {
                if (valueTiapHuruf[i] < selisihUrutanLess)
                {
                    valueOutput[i] = valueTiapHuruf[i] - selisihUrutanLess + 26;
                }
                else if (urutanHur[0] > urutanHur2[0])
                {
                    valueOutput[i] = valueTiapHuruf[i] - selisihUrutanLess;
                }
                else if (valueTiapHuruf[i] >= selisihUrutanMore)
                {
                    valueOutput[i] = valueTiapHuruf[i] + selisihUrutanMore - 26;
                }
                else if (urutanHur2[0] > urutanHur[0])
                {
                    valueOutput[i] = valueTiapHuruf[i] + selisihUrutanMore;
                }
            }

            for (int i = 0; i < textBoxInputKal.Text.Length; i++)
            {
                for (char a = 'A'; a <= 'Z'; a++)
                {
                    if (alpha.IndexOf(a) == valueOutput[i])
                    {
                        isiOutput[i] = a.ToString();
                    }
                }
                output += isiOutput[i];
            }
            labelOutput.Text = output;
        }
    }
}
