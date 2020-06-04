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
    public partial class PassCheck : Form
    {
        private string password = "admin";
        public PassCheck()
        {
            InitializeComponent();
        }

        private void PassCheck_Load(object sender, EventArgs e)
        {

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            ErrMsgBox.Text = "";

            if (PasswordEntering.Text.Equals(this.password))
            { 
                DialogResult = DialogResult.OK;
            }
            else
            {
                ErrMsgBox.Text = "Wrong password.";
            }
           
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                CheckButton_Click(null, null);
                return true;
            }
            else if (keyData == (Keys.Escape))
            {
                DialogResult = DialogResult.Cancel;
                return true;
            }
            else if (keyData == (Keys.F1))
            {
                Help helpWindow = new Help();
                helpWindow.Show();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
