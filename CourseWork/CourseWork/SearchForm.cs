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

namespace CourseWork
{
    public partial class SearchForm : Form
    {
        private string searchOption, searchValue;
        int searchIntegerValue;
        byte mode;

        public string SearchOption { get => searchOption; }
        public string SearchValue { get => searchValue; }
        public int SearchIntegerValue { get => searchIntegerValue; }

        public SearchForm(string mode)
        {
            InitializeComponent();
            if (mode.ToLower().Equals("search"))
            {
                this.mode = 0;
                HintLabel.Text = "";
                for (int i = 0; i <= WorldInfo.SearchOptions.GetUpperBound(0); i++)
                {
                    SearchOptionComboBox.Items.Add(WorldInfo.SearchOptions[i, 0]);
                }

                SearchOptionComboBox.SelectedIndex = 0;
            }
            else if (mode.ToLower().Equals("delete"))
            {
                this.mode = 1;
                HintLabel.Text = "";
                ConfirmButton.Text = "Delete";
                HeaderLabel.Text = "Delete by";
                for (int i = 0; i <= WorldInfo.DeleteOptions.GetUpperBound(0); i++)
                {
                    SearchOptionComboBox.Items.Add(WorldInfo.DeleteOptions[i, 0]);
                }

                SearchOptionComboBox.SelectedIndex = 0;
            }
            else if (mode.ToLower().Equals("edit"))
            {
                this.mode = 2;
                HintLabel.Text = "";
                ConfirmButton.Text = "Edit";
                HeaderLabel.Text = "Enter the exact";
                for (int i = 0; i <= WorldInfo.EditOptions.GetUpperBound(0); i++)
                {
                    SearchOptionComboBox.Items.Add(WorldInfo.EditOptions[i, 0]);
                }
                SearchOptionComboBox.SelectedIndex = 0;
                SearchValueTextBox.TabIndex = 1;
                SearchOptionComboBox.TabIndex = 5;
            }

        }


        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void SearchOptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                switch (SearchOptionComboBox.SelectedIndex)
                {
                    case 0:
                        HintLabel.Text = WorldInfo.SearchOptions[0, 1];
                        break;
                    case 1:
                        HintLabel.Text = WorldInfo.SearchOptions[1, 1];
                        break;
                    case 2:
                        HintLabel.Text = WorldInfo.SearchOptions[2, 1];
                        break;
                    case 3:
                        HintLabel.Text = WorldInfo.SearchOptions[3, 1];
                        break;
                    default:
                        break;
                }
            }
            else if (mode == 1)
            {
                switch (SearchOptionComboBox.SelectedIndex)
                {
                    case 0:
                        HintLabel.Text = WorldInfo.DeleteOptions[0, 1];
                        break;
                    case 1:
                        HintLabel.Text = WorldInfo.DeleteOptions[1, 1];
                        break;
                    default:
                        break;
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SearchOptionComboBox.SelectedItem.Equals("Contract term") || SearchOptionComboBox.SelectedItem.Equals("Deposit sum"))
                {
                    bool isCorrect = Int32.TryParse(SearchValueTextBox.Text, out searchIntegerValue);
                    if (isCorrect)
                    {
                        searchOption = SearchOptionComboBox.Text;
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        ErrMsgBox.Text = "Please, enter integer value";
                    }
                }
                else
                {
                    searchOption = SearchOptionComboBox.Text;
                    searchValue = SearchValueTextBox.Text;
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception exc)
            {
                ErrMsgBox.Text = exc.Message;
            }

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                SearchButton_Click(null, null);
                return true;
            }
            else if (keyData == (Keys.Escape))
            {
                DialogResult = DialogResult.Cancel;
                return true;
            }
          
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
