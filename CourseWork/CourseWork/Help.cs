using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Help : Form
    {
        private static string[] FAQ;
        public Help()
        {
            InitializeComponent();
            GeneralBtn_Click(null, null);
        }

        private void GeneralBtn_Click(object sender, EventArgs e)
        {
            HelpRichTextBox.Text = WorldInfo.FAQ[0];
        }

        private void AddClientBtn_Click(object sender, EventArgs e)
        {
            HelpRichTextBox.Text = WorldInfo.FAQ[1];
        }

        private void RemoveClientBtn_Click(object sender, EventArgs e)
        {
            HelpRichTextBox.Text = WorldInfo.FAQ[2];
        }

        private void EditClientBtn_Click(object sender, EventArgs e)
        {
            HelpRichTextBox.Text = WorldInfo.FAQ[3];
        }

        private void ImpExpBtn_Click(object sender, EventArgs e)
        {
            HelpRichTextBox.Text = WorldInfo.FAQ[4];
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            HelpRichTextBox.Text = WorldInfo.FAQ[5];
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                DialogResult = DialogResult.Cancel;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
