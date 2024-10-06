namespace EmployeeApplication
{
    partial class FrmEmployeeDataBase
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
            ListViewGroup listViewGroup1 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewItem listViewItem1 = new ListViewItem("");
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TBEmployeeID = new TextBox();
            TBFirstName = new TextBox();
            TBLastName = new TextBox();
            TBPosition = new TextBox();
            ButtonSubmit = new Button();
            label6 = new Label();
            listView = new ListView();
            CHID = new ColumnHeader();
            CHFirstName = new ColumnHeader();
            CHLastName = new ColumnHeader();
            CHPosition = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 0;
            label1.Text = "Add Employee:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 1;
            label2.Text = "Employee ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gray;
            label3.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gray;
            label4.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 225);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 3;
            label4.Text = "Last name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gray;
            label5.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 307);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 4;
            label5.Text = "Position:";
            // 
            // TBEmployeeID
            // 
            TBEmployeeID.BackColor = Color.Gainsboro;
            TBEmployeeID.Font = new Font("Constantia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBEmployeeID.Location = new Point(12, 106);
            TBEmployeeID.Name = "TBEmployeeID";
            TBEmployeeID.Size = new Size(219, 23);
            TBEmployeeID.TabIndex = 5;
            // 
            // TBFirstName
            // 
            TBFirstName.BackColor = Color.Gainsboro;
            TBFirstName.Font = new Font("Constantia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBFirstName.Location = new Point(12, 186);
            TBFirstName.Name = "TBFirstName";
            TBFirstName.Size = new Size(219, 23);
            TBFirstName.TabIndex = 6;
            // 
            // TBLastName
            // 
            TBLastName.BackColor = Color.Gainsboro;
            TBLastName.Font = new Font("Constantia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBLastName.Location = new Point(12, 265);
            TBLastName.Name = "TBLastName";
            TBLastName.Size = new Size(219, 23);
            TBLastName.TabIndex = 7;
            // 
            // TBPosition
            // 
            TBPosition.BackColor = Color.Gainsboro;
            TBPosition.Font = new Font("Constantia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBPosition.Location = new Point(12, 340);
            TBPosition.Name = "TBPosition";
            TBPosition.Size = new Size(219, 23);
            TBPosition.TabIndex = 8;
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.BackColor = Color.DarkGray;
            ButtonSubmit.Location = new Point(37, 380);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(166, 44);
            ButtonSubmit.TabIndex = 9;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = false;
            ButtonSubmit.Click += ButtonSubmit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gray;
            label6.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(270, 36);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 10;
            label6.Text = "Employee List:";
            // 
            // listView
            // 
            listView.BackColor = Color.Gainsboro;
            listView.Columns.AddRange(new ColumnHeader[] { CHID, CHFirstName, CHLastName, CHPosition });
            listView.Font = new Font("Constantia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listView.Groups.AddRange(new ListViewGroup[] { listViewGroup1 });
            listView.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView.Location = new Point(270, 59);
            listView.Name = "listView";
            listView.Size = new Size(478, 365);
            listView.TabIndex = 11;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // CHID
            // 
            CHID.Text = "ID";
            CHID.Width = 100;
            // 
            // CHFirstName
            // 
            CHFirstName.Text = "FirstName";
            CHFirstName.Width = 100;
            // 
            // CHLastName
            // 
            CHLastName.Text = "LastName";
            CHLastName.Width = 100;
            // 
            // CHPosition
            // 
            CHPosition.Text = "Position";
            CHPosition.Width = 100;
            // 
            // FrmEmployeeDataBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(listView);
            Controls.Add(label6);
            Controls.Add(ButtonSubmit);
            Controls.Add(TBPosition);
            Controls.Add(TBLastName);
            Controls.Add(TBFirstName);
            Controls.Add(TBEmployeeID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmEmployeeDataBase";
            Text = "Employee Database";
            Load += FrmEmployeeDataBase_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TBEmployeeID;
        private TextBox TBFirstName;
        private TextBox TBLastName;
        private TextBox TBPosition;
        private Button ButtonSubmit;
        private Label label6;
        private ListView listView;
        private ColumnHeader CHID;
        private ColumnHeader CHFirstName;
        private ColumnHeader CHLastName;
        private ColumnHeader CHPosition;
    }
}
