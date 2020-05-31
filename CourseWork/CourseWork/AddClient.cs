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
using System.Windows.Forms.VisualStyles;
using System.Windows.Input;

namespace CourseWork
{
    public partial class AddClient : Form
    {
        private Client newClient = new Client();
        internal Client NewClient { get => newClient; set => newClient = value; }

        public AddClient()
        {
            InitializeComponent();
            foreach (Country country in WorldInfo.Countries)
            {
                CountrySelection.Items.Add(country.name);
                // CountrySelection.AutoCompleteCustomSource.Add(country.name);
            }
            CountrySelection.SelectedItem = "Ukraine";
            NumberOfContractTextBox.Text = newClient.NumberOfContract;
        }

        public AddClient(Client oldClient)
        {
            InitializeComponent();
            foreach (Country country in WorldInfo.Countries)
            {
                CountrySelection.Items.Add(country.name);
            }
            NumberOfContractTextBox.Text = oldClient.NumberOfContract;
            FirstNameTextBox.Text = oldClient.Name.FirstName;
            MiddleNameTextBox.Text = oldClient.Name.MiddleName;
            LastNameTextBox.Text = oldClient.Name.LastName;
            StreetTextBox.Text = oldClient.Address.Street;
            CityTextBox.Text = oldClient.Address.City;
            StateTextBox.Text = oldClient.Address.State;
            CountrySelection.Text = oldClient.Address.Country;
            newClient.ContractDate = oldClient.ContractDate;
            SumOfDepositTextBox.Text = oldClient.SumOfDeposit.ToString();
            TermOfContractTextBox.Text = oldClient.DaysOfContractTerm.ToString();
            AddClientButton.Text = "Edit";
            
        }


        private void AddClientButton_Click(object sender, EventArgs e)
        {
            ErrMsgBox.Text = ""; // clear error box

            try
            {
                if (FirstNameTextBox.Text.Length == 0 || MiddleNameTextBox.Text.Length == 0 || LastNameTextBox.Text.Length == 0)
                {
                    ErrMsgBox.Text = "Please fill all name fields";
                    return;
                }

                if (StreetTextBox.Text.Length == 0 || CityTextBox.Text.Length == 0 || StateTextBox.Text.Length == 0)
                {
                    ErrMsgBox.Text = "Please fill all address fields";
                    return;
                }

                Name name = new Name(FirstNameTextBox.Text, MiddleNameTextBox.Text, LastNameTextBox.Text);
                Address address = new Address(CountrySelection.Text, StateTextBox.Text, CityTextBox.Text, StreetTextBox.Text);
                //address += (CountrySelection.Text.Length > 0 ? CountrySelection.Text + ", " : "");
                //address += (StateTextBox.Text.Length > 0 ? StateTextBox.Text + ", " : "");
                //address += (CityTextBox.Text.Length > 0 ? CityTextBox.Text + ", " : "");
                //address += StreetTextBox.Text;
                string numberOfContract = NumberOfContractTextBox.Text;
                int sumOfDeposit = Int32.Parse(SumOfDepositTextBox.Text);
                int termOfContract = Int32.Parse(TermOfContractTextBox.Text);

                if (sumOfDeposit <= 0 || termOfContract <= 0)
                {
                    ErrMsgBox.Text = "Values cannot be negative";
                    return;
                }

                newClient = new Client(name, address, numberOfContract, sumOfDeposit, newClient.ContractDate, termOfContract);
                DialogResult = DialogResult.OK;
            }
            catch (Exception exc)
            {
                ErrMsgBox.Text = exc.Message;
            }

        }

        private void AddClient_Load(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                AddClientButton_Click(null, null);
                return true;
            }
           else if (keyData == (Keys.Escape))
            {
                DialogResult = DialogResult.Cancel;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //public Client EditClient(Client oldClient)
        //{
        //    Client temp = oldClient;


        //    return temp;
        //}
    }
}
