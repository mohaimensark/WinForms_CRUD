namespace WinForms_CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnAddClient = new Button();
            btnDelete = new Button();
            edtClient = new Button();
            clientsTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)clientsTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(1160, 35);
            label1.TabIndex = 0;
            label1.Text = "List of Clients";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddClient
            // 
            btnAddClient.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddClient.ForeColor = SystemColors.HotTrack;
            btnAddClient.Location = new Point(33, 72);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(128, 37);
            btnAddClient.TabIndex = 1;
            btnAddClient.Text = "Add Client";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(1063, 72);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 43);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // edtClient
            // 
            edtClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            edtClient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edtClient.Location = new Point(901, 72);
            edtClient.Name = "edtClient";
            edtClient.Size = new Size(126, 43);
            edtClient.TabIndex = 3;
            edtClient.Text = "Edit Client";
            edtClient.UseVisualStyleBackColor = true;
            edtClient.Click += edtClient_Click;
            // 
            // clientsTable
            // 
            clientsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clientsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsTable.Location = new Point(33, 139);
            clientsTable.MultiSelect = false;
            clientsTable.Name = "clientsTable";
            clientsTable.RowHeadersVisible = false;
            clientsTable.RowHeadersWidth = 51;
            clientsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientsTable.Size = new Size(1160, 496);
            clientsTable.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 671);
            Controls.Add(clientsTable);
            Controls.Add(edtClient);
            Controls.Add(btnDelete);
            Controls.Add(btnAddClient);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Clients Manager";
            ((System.ComponentModel.ISupportInitialize)clientsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAddClient;
        private Button btnDelete;
        private Button edtClient;
        private DataGridView clientsTable;
    }
}
