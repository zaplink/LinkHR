namespace LinkHR
{
    partial class RemoveManager
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
            textBoxSearch = new TextBox();
            label2 = new Label();
            textBoxPhoneNo = new TextBox();
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            textBoxManagerId = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label8 = new Label();
            buttonSearch = new Button();
            buttonClear = new Button();
            buttonRemove = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(388, 35);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 1;
            label1.Text = "Remove Manager";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(263, 125);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(269, 27);
            textBoxSearch.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(73, 128);
            label2.Name = "label2";
            label2.Size = new Size(168, 23);
            label2.TabIndex = 4;
            label2.Text = "Search By ID/Name :";
            // 
            // textBoxPhoneNo
            // 
            textBoxPhoneNo.Location = new Point(253, 389);
            textBoxPhoneNo.Name = "textBoxPhoneNo";
            textBoxPhoneNo.Size = new Size(306, 27);
            textBoxPhoneNo.TabIndex = 26;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(253, 338);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(306, 27);
            textBoxEmail.TabIndex = 25;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(253, 289);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(306, 27);
            textBoxName.TabIndex = 24;
            // 
            // textBoxManagerId
            // 
            textBoxManagerId.Location = new Point(253, 248);
            textBoxManagerId.Name = "textBoxManagerId";
            textBoxManagerId.Size = new Size(306, 27);
            textBoxManagerId.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(109, 396);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 22;
            label7.Text = "Phone no.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(109, 345);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 21;
            label6.Text = "Email :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(109, 296);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 20;
            label5.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 255);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 19;
            label4.Text = "Manager ID :";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(73, 223);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(593, 220);
            textBox2.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(73, 200);
            label3.Name = "label3";
            label3.Size = new Size(134, 23);
            label3.TabIndex = 17;
            label3.Text = "Manager Details";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(344, 496);
            label8.Name = "label8";
            label8.Size = new Size(322, 20);
            label8.TabIndex = 30;
            label8.Text = "Warning: Removing this manager is irreversible.";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(572, 126);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 31;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(73, 526);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(132, 40);
            buttonClear.TabIndex = 32;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.RosyBrown;
            buttonRemove.Location = new Point(497, 526);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(169, 49);
            buttonRemove.TabIndex = 33;
            buttonRemove.Text = "Remove Employee";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // RemoveManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 596);
            Controls.Add(buttonRemove);
            Controls.Add(buttonClear);
            Controls.Add(buttonSearch);
            Controls.Add(label8);
            Controls.Add(textBoxPhoneNo);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Controls.Add(textBoxManagerId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBoxSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RemoveManager";
            Text = "RemoveManager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxSearch;
        private Label label2;
        private TextBox textBoxPhoneNo;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
        private TextBox textBoxManagerId;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private Label label8;
        private Button buttonSearch;
        private Button buttonClear;
        private Button buttonRemove;
    }
}