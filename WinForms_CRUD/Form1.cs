using System.Data;
using WinForms_CRUD.Repositories;

namespace WinForms_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ReadClients();
        }


        private void ReadClients()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Phone");
            dataTable.Columns.Add("Date");


            var repo = new ClientRepositories();
            var clients = repo.GetClients();

            foreach (var client in clients)
            {
                var row = dataTable.NewRow();

                row["ID"] = client.id;
                row["Name"] = client.firstname + " " + client.lastname;
                row["Email"] = client.email;
                row["Phone"] = client.phone;
                row["Date"] = client.createdAt;

                dataTable.Rows.Add(row);
            }

            this.clientsTable.DataSource = dataTable;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            CreateEditForm form = new CreateEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadClients();
            }
        }

        private void edtClient_Click(object sender, EventArgs e)
        {
            var val = this.clientsTable.SelectedRows[0].Cells[0].Value.ToString();

            if (val == null || val.Length == 0) return;

            int clientId = int.Parse(val);

            var repo = new ClientRepositories();
            var clients = repo.GetClient(clientId);

            if (clients == null) return;

            CreateEditForm form = new CreateEditForm();

            form.EditClient(clients);

            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadClients();
            }




        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var val = this.clientsTable.SelectedRows[0].Cells[0].Value.ToString();

            if (val == null || val.Length == 0) return;

            int clientId = int.Parse(val);

            DialogResult dialogResult = MessageBox.Show("Are you Sure?","Delete Client", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No) { 
                return;
            }

            var repo = new ClientRepositories();
            repo.DeleteClient(clientId);

            ReadClients();


        }
    }
}
