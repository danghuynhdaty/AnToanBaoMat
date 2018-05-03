using AnToanBaoMat.Algorithms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AnToanBaoMat
{
    public partial class frmMain : Form
    {
        #region fields

        private List<string> _data;
        private List<string> _result;
        #endregion
        #region Constructor

        public frmMain()
        {
            _data = new List<string>();
            _result = new List<string>();
            InitializeComponent();
            cbxProgress.SelectedIndex = 0;
            cbxAlgorithm.SelectedIndex = 0;
        }
        #endregion

        #region Methods

        private void btnExcute_Click(object sender, EventArgs e)
        {
            ExcuteAlgorithm();
            this.Hide();
            frmResult f = new frmResult(_data, _result);
            f.ShowDialog();
            this.Show();
        }

        private void ExcuteAlgorithm()
        {
            _result = new List<string>();
            int algor = cbxAlgorithm.SelectedIndex;
            int progress = cbxProgress.SelectedIndex;

            switch (algor)
            {
                case 0:
                    int key = int.Parse(rtbxKey.Text);
                    if (progress == 0)
                    {
                        foreach (var item in _data)
                        {
                            _result.Add(Ceasar.Encipher(item, key));
                        }
                    }
                    else
                    {
                        foreach (var item in _data)
                        {
                            _result.Add(Ceasar.Decipher(item, key));
                        }
                    }
                    break;
                case 1:
                    string khoa = rtbxKey.Text;
                    if(progress == 0)
                    {
                        foreach(var item in _data)
                        {
                            _result.Add(Playfair.PlayfairEncryption(item,khoa));
                        }
                    }
                    else
                    {
                        foreach(var item in _data)
                        {
                            _result.Add(Playfair.PlayfairDecryption(item, khoa));
                        }
                    }
                    break;
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            StreamReader reader = new StreamReader(myStream);
                            string file = Path.GetFileName(openFileDialog1.FileName);
                            string path = Path.GetFullPath(file);
                            lblFileName.Text = file;

                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                line += "\n";
                                _data.Add(line);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        #endregion

       
    }
}