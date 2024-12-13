using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_CRUD.Models;
using WinForms_CRUD.Repositories;

namespace WinForms_CRUD
{
    public partial class CreateEditForm : Form
    {
        public CreateEditForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;

        }

        private int clientId = 0;

        public void EditClient(Client client)
        {
            this.Text = "Edit Client";
            this.lbTitle.Text = "Edit Client";

            this.lbId.Text = "" + client.id;
            this.tbFirstName.Text = client.firstname;
            this.tbLastName.Text = client.lastname;
            this.tbEmail.Text = client.email;
            this.tbPhone.Text = client.phone;
            this.tbAddress.Text = client.address;

            this.clientId = client.id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Client client = new Client();
           
            client.id = (int)clientId;

            client.firstname = this.tbFirstName.Text;
            client.lastname = this.tbLastName.Text;
            client.email = this.tbEmail.Text;
            client.phone = this.tbPhone.Text;
            client.address = this.tbAddress.Text;



            var repo = new ClientRepositories();

            if (clientId != 0)
            {
                
                repo.UpdateClient(client);
            }
            else
            {  
              
                repo.CreateClient(client);
            }

            this.DialogResult = DialogResult.OK;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
