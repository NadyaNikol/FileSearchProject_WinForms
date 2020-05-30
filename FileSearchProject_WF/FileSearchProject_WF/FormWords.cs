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

namespace FileSearchProject_WF
{
    public partial class FormWords : Form
    {
        List<string> words = null;
        public FormWords(List<string> w)
        {
            InitializeComponent();
            words = w;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtbWord.Text))
            {
                listBoxWords.Items.Add(txtbWord.Text);
                words.Add(txtbWord.Text);
                txtbWord.Text = "";
            }
        }

        private async void btnFromFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog of = new OpenFileDialog())
            {
                of.Filter = "(*.txt)|*.txt";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(of.FileName))
                    {
                        while (sr.Read() > 0)
                        {
                            string word = await sr.ReadLineAsync();

                            if (word != "")
                            {
                                listBoxWords.Items.Add(word);
                                words.Add(word);
                            }
                        }
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxWords.SelectedIndex != -1)
            {
                words.RemoveAt(listBoxWords.SelectedIndex);
                listBoxWords.Items.RemoveAt(listBoxWords.SelectedIndex);
            }
        }
    }
}
