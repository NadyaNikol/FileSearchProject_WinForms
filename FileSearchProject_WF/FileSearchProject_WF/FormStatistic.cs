using FileSearchProject_WF.Model;
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
    public partial class FormStatistic : Form
    {
        List<Statistic> listStatistic = null;

        public FormStatistic(List<Statistic> listStatistic)
        {
            InitializeComponent();

            this.listStatistic = listStatistic;

            dataGridViewStatistic.DataSource = listStatistic;
            dataGridViewStatistic.Columns["Id"].Visible = false;
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            FormTopWords asf = new FormTopWords();
            asf.Show();
        }
    }
}
