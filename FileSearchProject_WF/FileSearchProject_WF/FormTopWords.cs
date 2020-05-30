using FileSearchProject_WF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearchProject_WF
{
    public partial class FormTopWords : Form
    {
        ForbiddenWordsContext db = new ForbiddenWordsContext();
        public FormTopWords()
        {
            InitializeComponent();

            dataGridViewAbridgedStatistic.DataSource = db.TopWords.GroupBy(a => a.Word).Select(a => new
            {
                word = a.Key,
                sumWords = a.Sum(ab=>ab.CountWords)
            }).OrderByDescending(s=>s.sumWords).ToList();
        }
    }
}
