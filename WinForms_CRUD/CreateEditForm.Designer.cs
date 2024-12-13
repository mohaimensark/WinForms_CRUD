namespace WinForms_CRUD
{
    partial class CreateEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            tbEmail = new TextBox();
            tbPhone = new TextBox();
            tbAddress = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            lbId = new TextBox();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.DarkGoldenrod;
            lbTitle.Location = new Point(25, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(583, 25);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Create Client";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 74);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "Client ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 125);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 171);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(211, 122);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(249, 27);
            tbFirstName.TabIndex = 4;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(211, 171);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(249, 27);
            tbLastName.TabIndex = 5;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(211, 220);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(249, 27);
            tbEmail.TabIndex = 6;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(211, 266);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(249, 27);
            tbPhone.TabIndex = 7;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(211, 315);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(249, 27);
            tbAddress.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 220);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(99, 269);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 10;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(98, 315);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 11;
            label6.Text = "Address";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(211, 371);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Submit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(366, 371);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbId
            // 
            lbId.Location = new Point(211, 71);
            lbId.Name = "lbId";
            lbId.Size = new Size(249, 27);
            lbId.TabIndex = 14;
            // 
            // CreateEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 475);
            Controls.Add(lbId);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbAddress);
            Controls.Add(tbPhone);
            Controls.Add(tbEmail);
            Controls.Add(tbLastName);
            Controls.Add(tbFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbTitle);
            Name = "CreateEditForm";
            Text = "Create Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private TextBox tbEmail;
        private TextBox tbPhone;
        private TextBox tbAddress;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnSave;
        private Button btnCancel;
        private TextBox lbId;
    }
}