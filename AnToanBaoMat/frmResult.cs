using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnToanBaoMat
{
    public partial class frmResult : Form
    {
        #region Fields
        List<string> _data;
        List<string> _result;
        #endregion

        #region Constructors

        public frmResult(List<string> data, List<string> result)
        {
            InitializeComponent();
            _data = data;
            _result = result;
            FillRichTextBox(_data, result);
        }
        public frmResult()
        {
            InitializeComponent();

        }

        #endregion

        #region Methods

        private void FillRichTextBox(List<string> data, List<string> result)
        {
       
            foreach (var item in _data)
            {
                rtbxData.AppendText(item);
            }
            foreach (var item in _result)
            {
                rtbxResult.AppendText(item);
            }
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
