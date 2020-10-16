using Microsoft.SqlServer.Server;
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

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        //egy óra nem tudom mi után cska sikerült fel rakni azt a repo file-t githubra...
        //VS850048: The specified region: CUS is not supported by the current instance.
        //akkor még sem
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHozzaAd_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string filename = "MentettRegisztracio.txt";
            try
            {
                using (var sw = new StreamWriter(filename))
                {

                    sw.WriteLine(textBoxName.Text);
                    sw.WriteLine(dateTimePicker1.Value);
                    if (radioButtonF.Checked)
                    {
                        sw.WriteLine("férfi");
                    }
                    else if (radioButtonN.Checked)
                    {
                        sw.WriteLine("Nő");
                    }
                    else
                    {
                        Console.WriteLine("A nem nincs megadva, mentés nem tud végig futni!");
                    }

                    sw.WriteLine();
                    sw.WriteLine();


                    sw.WriteLine();
                    foreach (var item in listBoxHobbik.Items)
                    {
                        sw.WriteLine(item);
                    }
                }

            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message + "hiba a mentés sorás");

            }
        }

        private void buttonBe_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }


            string filename = openFileDialog1.FileName;
            try
            {
                using (var sr = new StreamReader(filename))
                {

                    listBoxHobbik.Items.Clear();
                    while (!sr.EndOfStream)
                    {
                        listBoxHobbik.Items.Add(sr.ReadLine());
                    }
                }

            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message + "hiba a megnyitás sorás");

            }
        }

        private void buttonUseDateTimePicker_Click(object sender, EventArgs e)
        {
         //   textBoxSzulDatum.Text = format (dateTimePicker1.Value,"yyyy.MM.dd");
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
