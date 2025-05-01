namespace LinkHR
{
    partial class EmployeeListForm
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            first_name = new DataGridViewTextBoxColumn();
            last_name = new DataGridViewTextBoxColumn();
            dob = new DataGridViewTextBoxColumn();
            contact_no = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            department_name = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            joining_date = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(26, 22);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 0;
            label1.Text = "Employee details";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, first_name, last_name, dob, contact_no, address, email, department_name, gender, joining_date, role });
            dataGridView1.Location = new Point(26, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1016, 555);
            dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // first_name
            // 
            first_name.HeaderText = "First name";
            first_name.MinimumWidth = 6;
            first_name.Name = "first_name";
            first_name.Width = 125;
            // 
            // last_name
            // 
            last_name.HeaderText = "Last name";
            last_name.MinimumWidth = 6;
            last_name.Name = "last_name";
            last_name.Width = 125;
            // 
            // dob
            // 
            dob.HeaderText = "Birthday";
            dob.MinimumWidth = 6;
            dob.Name = "dob";
            dob.Width = 125;
            // 
            // contact_no
            // 
            contact_no.HeaderText = "Phone no";
            contact_no.MinimumWidth = 6;
            contact_no.Name = "contact_no";
            contact_no.Width = 125;
            // 
            // address
            // 
            address.HeaderText = "Address";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.Width = 125;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.Width = 125;
            // 
            // department_name
            // 
            department_name.HeaderText = "Department";
            department_name.MinimumWidth = 6;
            department_name.Name = "department_name";
            department_name.Width = 125;
            // 
            // gender
            // 
            gender.HeaderText = "Gender";
            gender.MinimumWidth = 6;
            gender.Name = "gender";
            gender.Width = 125;
            // 
            // joining_date
            // 
            joining_date.HeaderText = "Joining Date";
            joining_date.MinimumWidth = 6;
            joining_date.Name = "joining_date";
            joining_date.Width = 125;
            // 
            // role
            // 
            role.HeaderText = "Role";
            role.MinimumWidth = 6;
            role.Name = "role";
            role.Width = 125;
            // 
            // EmployeeListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 676);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "EmployeeListForm";
            Text = "EmployeeListForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn first_name;
        private DataGridViewTextBoxColumn last_name;
        private DataGridViewTextBoxColumn dob;
        private DataGridViewTextBoxColumn contact_no;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn department_name;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn joining_date;
        private DataGridViewTextBoxColumn role;
    }
}