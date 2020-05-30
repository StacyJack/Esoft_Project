namespace Esoft_Project
{
    partial class FormAgents
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleNam = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxDealShare = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelDealShare = new System.Windows.Forms.Label();
            this.listAgent = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(12, 52);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(128, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // textBoxMiddleNam
            // 
            this.textBoxMiddleNam.Location = new System.Drawing.Point(12, 118);
            this.textBoxMiddleNam.Name = "textBoxMiddleNam";
            this.textBoxMiddleNam.Size = new System.Drawing.Size(128, 20);
            this.textBoxMiddleNam.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(12, 183);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(128, 20);
            this.textBoxLastName.TabIndex = 2;
            // 
            // textBoxDealShare
            // 
            this.textBoxDealShare.Location = new System.Drawing.Point(12, 252);
            this.textBoxDealShare.Name = "textBoxDealShare";
            this.textBoxDealShare.Size = new System.Drawing.Size(128, 20);
            this.textBoxDealShare.TabIndex = 3;
            this.textBoxDealShare.TextChanged += new System.EventHandler(this.textBoxDealShare_TextChanged);
            this.textBoxDealShare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DealShareBox_KeyPress);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(9, 36);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(29, 13);
            this.labelFirstName.TabIndex = 4;
            this.labelFirstName.Text = "Имя";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(12, 102);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(54, 13);
            this.labelMiddleName.TabIndex = 5;
            this.labelMiddleName.Text = "Отчество";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(12, 167);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Text = "Фамилия";
            this.labelLastName.Click += new System.EventHandler(this.labelLastName_Click);
            // 
            // labelDealShare
            // 
            this.labelDealShare.AutoSize = true;
            this.labelDealShare.Location = new System.Drawing.Point(12, 236);
            this.labelDealShare.Name = "labelDealShare";
            this.labelDealShare.Size = new System.Drawing.Size(43, 13);
            this.labelDealShare.TabIndex = 7;
            this.labelDealShare.Text = "Ставка";
            // 
            // listAgent
            // 
            this.listAgent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listAgent.FullRowSelect = true;
            this.listAgent.GridLines = true;
            this.listAgent.HideSelection = false;
            this.listAgent.Location = new System.Drawing.Point(187, 31);
            this.listAgent.MultiSelect = false;
            this.listAgent.Name = "listAgent";
            this.listAgent.Size = new System.Drawing.Size(571, 241);
            this.listAgent.TabIndex = 8;
            this.listAgent.UseCompatibleStateImageBehavior = false;
            this.listAgent.View = System.Windows.Forms.View.Details;
            this.listAgent.SelectedIndexChanged += new System.EventHandler(this.listAgent_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            this.columnHeader2.Width = 137;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Отчество";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Фамилия";
            this.columnHeader4.Width = 108;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ставка";
            this.columnHeader5.Width = 74;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(0, 0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 12;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(393, 337);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(108, 31);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(537, 337);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(108, 31);
            this.buttonDel.TabIndex = 11;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listAgent);
            this.Controls.Add(this.labelDealShare);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxDealShare);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxMiddleNam);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "FormAgents";
            this.Text = "FormAgents";
            this.Load += new System.EventHandler(this.FormAgents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxMiddleNam;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxDealShare;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelDealShare;
        private System.Windows.Forms.ListView listAgent;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button1;
    }
}