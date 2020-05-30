using FileSearchProject_WF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace FileSearchProject_WF
{

    public partial class FormMain : Form
    {
        List<string> words = null;
        List<Statistic> listStatistic = null;
        List<TopWords> listAbridget = null;
        ForbiddenWordsContext db = null;


        string pathFoundFiles = @"D:\for copy\";

        public FormMain()
        {
            InitializeComponent();

            db = new ForbiddenWordsContext();

            Task task = Task.Run(() => FillDriveNodes());

            toolTip1.SetToolTip(this.btnSave, "Select a folder and click");
        }

        private void FillDriveNodes()
        {
            treeViewDirections.Nodes.Clear();

            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    if (drive.Name != @"C:\")
                    {
                        TreeNode driveNode = new TreeNode(drive.Name);
                        driveNode.Tag = drive;
                        GetChildNode(driveNode, drive.Name);

                        UpdateTreeView(driveNode);
                    }
                }
            }
            catch (Exception) { }
        }

        private void UpdateTreeView(TreeNode tn)
        {
            if (treeViewDirections.InvokeRequired)
                treeViewDirections.Invoke(new Action<TreeNode>(UpdateTreeView), tn);
            else
                treeViewDirections.Nodes.Add(tn);
        }


        private void GetChildNode(TreeNode tn, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);

                if (dirs.Length == 0) return;

                foreach (string dir in dirs)
                {
                    TreeNode dirNode = new TreeNode();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    dirNode.Tag = dir;

                    GetChildNode(dirNode, dir);
                    tn.Nodes.Add(dirNode);
                }

            }
            catch (Exception) { }
        }

        private void btnWords_Click(object sender, EventArgs e)
        {
            words = new List<string>();
            FormWords fw = new FormWords(words);
            fw.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TreeNode tn = treeViewDirections.SelectedNode;
            pathFoundFiles = tn.FullPath;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (treeViewDirections.SelectedNode != null)
            {

                progressBarSearch.Value = 0;
                listBoxFiles.Items.Clear();
                btnShowStatistics.Visible = false;
                progressBarSearch.Visible = true;
                lblFiles.Visible = true;

                TreeNode tn = treeViewDirections.SelectedNode;
                DirectoryInfo di = new DirectoryInfo(tn.FullPath);

                Task taskSearch = Task.Run(() =>
                {
                    listStatistic = new List<Statistic>();
                    listAbridget = new List<TopWords>();

                    Search(di);

                    if (listStatistic.Count > 0)
                        UpdateButton(true);

                    Task task = Task.Run(() =>
                    {
                        try
                        {
                            db.statisticClass.AddRange(listStatistic);
                            db.TopWords.AddRange(listAbridget);
                            db.SaveChanges();
                        }
                        catch (Exception) { }
                    });
                });
            }
        }

        private void UpdateButton(bool b)
        {
            if (btnShowStatistics.InvokeRequired)
                btnShowStatistics.Invoke(new Action<bool>(UpdateButton), b);

            else btnShowStatistics.Visible = b;
        }

        private void Search(DirectoryInfo di)
        {
            try
            {
                DirectoryInfo[] directories = di.GetDirectories();

                foreach (DirectoryInfo dir in directories)
                    Search(dir);

                if (directories.Count() == 0 || di.GetFiles().Count() > 0)
                {
                    if((di.GetFiles().Count() / 2 * 100) < 100)
                    UpdateProgressBar(di.GetFiles().Count() / 2 * 100);

                    else
                        UpdateProgressBar(100);

                    FileInfo[] files = di.GetFiles();

                    foreach (FileInfo file in files)
                    {
                        bool IsFind = false;
                        int countWordsFound = 0;
                        FileInfo fi = null;

                        string[] str = File.ReadAllLines(file.FullName);

                        UpdateLable(file.FullName);

                        foreach (string word in words)
                        {
                            IsFind = false;

                            for (int i = 0; i < str.Count(); i++)
                            {

                                if (Regex.IsMatch(str[i], word))
                                {
                                    str[i] = str[i].Replace(word, "*******");
                                    string[] wordsStr = str[i].Split(new char[] { ' ', '!', ',', '?' }, StringSplitOptions.RemoveEmptyEntries);

                                    countWordsFound += wordsStr.Where(w => w == "*******").Count();

                                    IsFind = true;
                                }
                            }

                            if (IsFind)
                            {
                                fi = new FileInfo(file.FullName);

                                UpdateList(file.FullName);

                                File.Copy(fi.FullName, pathFoundFiles + fi.Name, true);

                                listStatistic.Add(new Statistic(word, file.FullName, (int)fi.Length, countWordsFound, countWordsFound));
                                listAbridget.Add(new TopWords(word, countWordsFound));

                                if (!Directory.Exists(pathFoundFiles + "newFiles\\"))
                                    Directory.CreateDirectory(pathFoundFiles + "newFiles");

                                using (FileStream fs = new FileStream(pathFoundFiles + "newFiles\\" + Path.GetFileNameWithoutExtension(file.Name) + DateTime.Now.Second + ".txt", FileMode.OpenOrCreate))
                                {
                                    byte[] b = Encoding.ASCII.GetBytes(FullTextInString(str));
                                    fs.Write(b, 0, b.Length);
                                }
                            }
                        }

                    }
                    return;
                    
                }
            }
            catch (Exception) { }
        }

        private void UpdateList(string text)
        {
            if (listBoxFiles.InvokeRequired)
                listBoxFiles.Invoke(new Action<string>(UpdateList), text);

            else
                listBoxFiles.Items.Add(text);
        }


        private void UpdateLable(string text)
        {
            if (lblNameFiles.InvokeRequired)
                lblNameFiles.Invoke(new Action<string>(UpdateLable), text);

            else
                lblNameFiles.Text = text;
        }

        private void UpdateProgressBar(int v)
        {
            if (progressBarSearch.InvokeRequired)
                progressBarSearch.Invoke(new Action<int>(UpdateProgressBar), v);

            else
                progressBarSearch.Value += v;
        }

        private string FullTextInString(string[] str)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Count(); i++)
            {
                sb.AppendLine(str[i]);
            }

            return sb.ToString();
        }


        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            lblPathSave.Text = pathFoundFiles;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            lblPathSave.Text = "";
        }

        private void btnShowStatistics_Click(object sender, EventArgs e)
        {
            FormStatistic fs = new FormStatistic(listStatistic);
            fs.Show();
        }
    }
}
