using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CourseWork
{
    public partial class MainForm : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();
        Database main = new Database();
        Database current = new Database();

        bool isAdmin;

        static Client[] array = new Client[10];

        public MainForm()
        {
            InitializeComponent();
            isAdmin = false;
            GoToMainButton.Visible = false;
            WorldInfo.RecieveWorldInfo();
            ofd.Filter = "JSON files(*.json)|*.json|All files(*.*)|*.*";
            sfd.Filter = "JSON files(*.json)|*.json|All files(*.*)|*.*";

            //string path = "C:\\Users\\Михаил\\Documents\\CourseWork\\db.json";
            //main.Deserialize(File.ReadAllText(path));
            //RefreshTable(main);
            foreach (Client client in main.ListOfClients)
            {
                WorldInfo.Claim(client.NumberOfContract);
            }

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AddClientForm = new AddClient();

            if (AddClientForm.ShowDialog() == DialogResult.OK)
            {
                main.AddClient(AddClientForm.NewClient);
                RefreshTable(main);
                WorldInfo.Claim(AddClientForm.NewClient.NumberOfContract);
            }
        }

        private void RefreshTable(Database db)
        {

            if (db.ListOfClients != null)
            {
                var table = new DataTable("Clients");

                var name = new DataColumn("Name");
                var address = new DataColumn("Address");
                var sum = new DataColumn("Sum of deposit");
                var contract = new DataColumn("Number of contract");
                var from = new DataColumn("From");
                var to = new DataColumn("To");

                table.Columns.Add(name);
                table.Columns.Add(address);
                table.Columns.Add(sum);
                table.Columns.Add(contract);
                table.Columns.Add(from);
                table.Columns.Add(to);

                foreach (Client client in db.ListOfClients)
                {
                    DataRow row = table.NewRow();
                    row["Name"] = client.Name.ToString();
                    row["Address"] = client.Address.ToString();
                    row["Sum of deposit"] = client.SumOfDeposit;
                    row["Number of contract"] = client.NumberOfContract;
                    row["From"] = client.ContractDate.ToString();
                    row["To"] = client.ContractDate.AddDays(client.DaysOfContractTerm).ToString();
                    table.Rows.Add(row);
                }
                ClientDataGrid.DataSource = table;
                current = db;
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Serialize(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.Cancel)
                return;
            string path = sfd.FileName;
            File.WriteAllText(path, main.Serialize());
        }

        private void DeserializeAndReplace(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            string path = ofd.FileName;
            main.Deserialize(File.ReadAllText(path));
            RefreshTable(main);

            WorldInfo.ClearClaimed();
            foreach (Client client in main.ListOfClients)
            {
                WorldInfo.Claim(client.NumberOfContract);
            }
        }

        private void DeserializeAndAppend(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            string path = ofd.FileName;
            main.DeserializeAppend(File.ReadAllText(path));
            RefreshTable(main);

            foreach (Client client in main.ListOfClients)
            {
                WorldInfo.Claim(client.NumberOfContract);
            }
        }

        private void SearchByName(string name)
        {
            Database temp = current.SearchByName(name);
            if (temp.ListOfClients.Count == 0)
            {
                MessageBox.Show("None was found.");
            }
            else
            {
                RefreshTable(temp);
                GoToMainButton.Visible = true;
            }
        }

        private void SearchByContarct(string contractNumber)
        {
            Database temp = current.SearchByContract(contractNumber);
            if (temp.ListOfClients.Count == 0)
            {
                MessageBox.Show("None was found.");
            }
            else
            {
                RefreshTable(temp);
                GoToMainButton.Visible = true;
            }
        }

        private void SearchByTerm(int daysOfContract)
        {
            Database temp = current.SearchByTerm(daysOfContract);
            if (temp.ListOfClients.Count == 0)
            {
                MessageBox.Show("None was found.");
            }
            else
            {
                RefreshTable(temp);
                GoToMainButton.Visible = true;
            }
        }

        private void SearchByDepositSum(int depositSum)
        {
            Database temp = current.SearchBySum(depositSum);
            if (temp.ListOfClients.Count == 0)
            {
                MessageBox.Show("None was found.");
            }
            else
            {
                RefreshTable(temp);
                GoToMainButton.Visible = true;
            }
        }

        private void DeleteByLastName(string name)
        {
            Database temp = main.DeleteByLastName(name);
            if (temp.ListOfClients.Count < main.ListOfClients.Count)
            {
                MessageBox.Show("Deleted");
                main = temp;
                RefreshTable(main);
            }
            else
            {
                MessageBox.Show("None was found. Try our brand new search by contract number.");
            }
        }
        private void DeleteByContract(string contractNumber)
        {
            Database temp = main.DeleteByContract(contractNumber);
            if (temp.ListOfClients.Count < main.ListOfClients.Count)
            {
                MessageBox.Show("Deleted");
                main = temp;
                RefreshTable(main);
            }
            else
            {
                MessageBox.Show("None was found");
            }
        }

        private void GoToMainButton_Click(object sender, EventArgs e)
        {
            RefreshTable(main);
            GoToMainButton.Visible = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            var SearchForm = new SearchForm("search");
            if (SearchForm.ShowDialog() == DialogResult.OK)
            {
                switch (SearchForm.SearchOption)
                {
                    case "Name":
                        SearchByName(SearchForm.SearchValue);
                        break;
                    case "Contract number":
                        SearchByContarct(SearchForm.SearchValue);
                        break;
                    case "Contract term":
                        SearchByTerm(SearchForm.SearchIntegerValue);
                        break;
                    case "Deposit sum":
                        SearchByDepositSum(SearchForm.SearchIntegerValue);
                        break;
                    default:
                        break;
                }

            }
        }

        private void DeleteTool_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                var SearchForm = new SearchForm("delete");
                if (SearchForm.ShowDialog() == DialogResult.OK)
                {
                    switch (SearchForm.SearchOption)
                    {
                        case "Last Name":
                            DeleteByLastName(SearchForm.SearchValue);
                            break;
                        case "Contract number":
                            DeleteByContract(SearchForm.SearchValue);
                            break;
                        default:
                            break;
                    }

                }
            }
            else
            {
                var PassCheckForm = new PassCheck();
                if (PassCheckForm.ShowDialog() == DialogResult.OK)
                {
                    isAdmin = true;
                    DeleteTool_Click(sender, e);
                }
            }
        }

        private void EditTool_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                var SearchForm = new SearchForm("edit");
                if (SearchForm.ShowDialog() == DialogResult.OK)
                {
                    bool isEdited = false;
                    for (int subject = 0; subject < main.ListOfClients.Count; subject++)
                    {
                        if (main.ListOfClients[subject].NumberOfContract.Equals(SearchForm.SearchValue))
                        {
                            var EditClient = new AddClient(main.ListOfClients[subject]);
                            if (EditClient.ShowDialog() == DialogResult.OK)
                            {
                                main.ListOfClients[subject] = EditClient.NewClient;
                                isEdited = true;
                                RefreshTable(main);
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    if (!isEdited)
                    {
                        MessageBox.Show("None was found");
                    }
                }
            }
            else
            {
                var PassCheckForm = new PassCheck();
                if (PassCheckForm.ShowDialog() == DialogResult.OK)
                {
                    isAdmin = true;
                    EditTool_Click(sender, e);
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                SearchButton_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


    }
}
