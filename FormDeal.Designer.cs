namespace Esoft_Project
{
    partial class FormDeal
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
            this.comboBoxSupply = new System.Windows.Forms.ComboBox();
            this.labelSupply = new System.Windows.Forms.Label();
            this.textBoxSellerCompanyDeductions = new System.Windows.Forms.TextBox();
            this.comboBoxDemand = new System.Windows.Forms.ComboBox();
            this.labelDemand = new System.Windows.Forms.Label();
            this.textBoxAgentSellerDeductions = new System.Windows.Forms.TextBox();
            this.textCustomerCompanyDeductions = new System.Windows.Forms.TextBox();
            this.textBoxAgentCustomerDeductions = new System.Windows.Forms.TextBox();
            this.labelSellerCompanyDeductions = new System.Windows.Forms.Label();
            this.labelAgentSellerDeductions = new System.Windows.Forms.Label();
            this.labelCustomerCompanyDeductions = new System.Windows.Forms.Label();
            this.labelAgentCustomerDeductions = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.listViewDealSet = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSupply
            // 
            this.comboBoxSupply.FormattingEnabled = true;
            this.comboBoxSupply.Location = new System.Drawing.Point(12, 49);
            this.comboBoxSupply.Name = "comboBoxSupply";
            this.comboBoxSupply.Size = new System.Drawing.Size(212, 21);
            this.comboBoxSupply.TabIndex = 0;
            this.comboBoxSupply.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupply_SelectedIndexChanged);
            // 
            // labelSupply
            // 
            this.labelSupply.AutoSize = true;
            this.labelSupply.Location = new System.Drawing.Point(16, 33);
            this.labelSupply.Name = "labelSupply";
            this.labelSupply.Size = new System.Drawing.Size(77, 13);
            this.labelSupply.TabIndex = 1;
            this.labelSupply.Text = "Предложение";
            // 
            // textBoxSellerCompanyDeductions
            // 
            this.textBoxSellerCompanyDeductions.Location = new System.Drawing.Point(12, 170);
            this.textBoxSellerCompanyDeductions.Name = "textBoxSellerCompanyDeductions";
            this.textBoxSellerCompanyDeductions.Size = new System.Drawing.Size(209, 20);
            this.textBoxSellerCompanyDeductions.TabIndex = 2;
            // 
            // comboBoxDemand
            // 
            this.comboBoxDemand.FormattingEnabled = true;
            this.comboBoxDemand.Location = new System.Drawing.Point(12, 99);
            this.comboBoxDemand.Name = "comboBoxDemand";
            this.comboBoxDemand.Size = new System.Drawing.Size(209, 21);
            this.comboBoxDemand.TabIndex = 3;
            this.comboBoxDemand.SelectedIndexChanged += new System.EventHandler(this.comboBoxDemand_SelectedIndexChanged);
            // 
            // labelDemand
            // 
            this.labelDemand.AutoSize = true;
            this.labelDemand.Location = new System.Drawing.Point(12, 83);
            this.labelDemand.Name = "labelDemand";
            this.labelDemand.Size = new System.Drawing.Size(73, 13);
            this.labelDemand.TabIndex = 4;
            this.labelDemand.Text = "Потребность";
            // 
            // textBoxAgentSellerDeductions
            // 
            this.textBoxAgentSellerDeductions.Location = new System.Drawing.Point(12, 221);
            this.textBoxAgentSellerDeductions.Name = "textBoxAgentSellerDeductions";
            this.textBoxAgentSellerDeductions.Size = new System.Drawing.Size(209, 20);
            this.textBoxAgentSellerDeductions.TabIndex = 5;
            // 
            // textCustomerCompanyDeductions
            // 
            this.textCustomerCompanyDeductions.Location = new System.Drawing.Point(12, 296);
            this.textCustomerCompanyDeductions.Name = "textCustomerCompanyDeductions";
            this.textCustomerCompanyDeductions.Size = new System.Drawing.Size(209, 20);
            this.textCustomerCompanyDeductions.TabIndex = 6;
            // 
            // textBoxAgentCustomerDeductions
            // 
            this.textBoxAgentCustomerDeductions.Location = new System.Drawing.Point(12, 344);
            this.textBoxAgentCustomerDeductions.Name = "textBoxAgentCustomerDeductions";
            this.textBoxAgentCustomerDeductions.Size = new System.Drawing.Size(205, 20);
            this.textBoxAgentCustomerDeductions.TabIndex = 7;
            // 
            // labelSellerCompanyDeductions
            // 
            this.labelSellerCompanyDeductions.AutoSize = true;
            this.labelSellerCompanyDeductions.Location = new System.Drawing.Point(16, 154);
            this.labelSellerCompanyDeductions.Name = "labelSellerCompanyDeductions";
            this.labelSellerCompanyDeductions.Size = new System.Drawing.Size(214, 13);
            this.labelSellerCompanyDeductions.TabIndex = 8;
            this.labelSellerCompanyDeductions.Text = "Стоимость услуги для клиента-продавца";
            // 
            // labelAgentSellerDeductions
            // 
            this.labelAgentSellerDeductions.AutoSize = true;
            this.labelAgentSellerDeductions.Location = new System.Drawing.Point(10, 205);
            this.labelAgentSellerDeductions.Name = "labelAgentSellerDeductions";
            this.labelAgentSellerDeductions.Size = new System.Drawing.Size(211, 13);
            this.labelAgentSellerDeductions.TabIndex = 9;
            this.labelAgentSellerDeductions.Text = "Отчисления риелтору клиента-продавца";
            this.labelAgentSellerDeductions.Click += new System.EventHandler(this.labelAgentSellerDeductions_Click);
            // 
            // labelCustomerCompanyDeductions
            // 
            this.labelCustomerCompanyDeductions.AutoSize = true;
            this.labelCustomerCompanyDeductions.Location = new System.Drawing.Point(9, 280);
            this.labelCustomerCompanyDeductions.Name = "labelCustomerCompanyDeductions";
            this.labelCustomerCompanyDeductions.Size = new System.Drawing.Size(224, 13);
            this.labelCustomerCompanyDeductions.TabIndex = 10;
            this.labelCustomerCompanyDeductions.Text = "Стоимость услуги для клиента-покупателя";
            // 
            // labelAgentCustomerDeductions
            // 
            this.labelAgentCustomerDeductions.AutoSize = true;
            this.labelAgentCustomerDeductions.Location = new System.Drawing.Point(9, 328);
            this.labelAgentCustomerDeductions.Name = "labelAgentCustomerDeductions";
            this.labelAgentCustomerDeductions.Size = new System.Drawing.Size(208, 13);
            this.labelAgentCustomerDeductions.TabIndex = 11;
            this.labelAgentCustomerDeductions.Text = "Стоимость услуги риелтору-покупателя";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(551, 338);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(89, 30);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(670, 338);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(108, 31);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(823, 338);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(108, 31);
            this.buttonDel.TabIndex = 16;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // listViewDealSet
            // 
            this.listViewDealSet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listViewDealSet.FullRowSelect = true;
            this.listViewDealSet.GridLines = true;
            this.listViewDealSet.HideSelection = false;
            this.listViewDealSet.Location = new System.Drawing.Point(233, 33);
            this.listViewDealSet.MultiSelect = false;
            this.listViewDealSet.Name = "listViewDealSet";
            this.listViewDealSet.Size = new System.Drawing.Size(782, 241);
            this.listViewDealSet.TabIndex = 17;
            this.listViewDealSet.UseCompatibleStateImageBehavior = false;
            this.listViewDealSet.View = System.Windows.Forms.View.Details;
            this.listViewDealSet.SelectedIndexChanged += new System.EventHandler(this.listViewDealSet_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Клиент-продавец";
            this.columnHeader6.Width = 107;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Риелтор клиента-продавца";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Клиент-покупатель";
            this.columnHeader8.Width = 109;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Риелтор клиента-покупателя";
            this.columnHeader9.Width = 167;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Адрес объекта недвижимости";
            this.columnHeader10.Width = 172;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Стоимость";
            this.columnHeader11.Width = 84;
            // 
            // Logo
            // 
            this.Logo.Image = global::Esoft_Project.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(257, 292);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(279, 146);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 18;
            this.Logo.TabStop = false;
            // 
            // FormDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 450);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.listViewDealSet);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelAgentCustomerDeductions);
            this.Controls.Add(this.labelCustomerCompanyDeductions);
            this.Controls.Add(this.labelAgentSellerDeductions);
            this.Controls.Add(this.labelSellerCompanyDeductions);
            this.Controls.Add(this.textBoxAgentCustomerDeductions);
            this.Controls.Add(this.textCustomerCompanyDeductions);
            this.Controls.Add(this.textBoxAgentSellerDeductions);
            this.Controls.Add(this.labelDemand);
            this.Controls.Add(this.comboBoxDemand);
            this.Controls.Add(this.textBoxSellerCompanyDeductions);
            this.Controls.Add(this.labelSupply);
            this.Controls.Add(this.comboBoxSupply);
            this.Name = "FormDeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDeal";
            this.Load += new System.EventHandler(this.FormDeal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSupply;
        private System.Windows.Forms.Label labelSupply;
        private System.Windows.Forms.TextBox textBoxSellerCompanyDeductions;
        private System.Windows.Forms.ComboBox comboBoxDemand;
        private System.Windows.Forms.Label labelDemand;
        private System.Windows.Forms.TextBox textBoxAgentSellerDeductions;
        private System.Windows.Forms.TextBox textCustomerCompanyDeductions;
        private System.Windows.Forms.TextBox textBoxAgentCustomerDeductions;
        private System.Windows.Forms.Label labelSellerCompanyDeductions;
        private System.Windows.Forms.Label labelAgentSellerDeductions;
        private System.Windows.Forms.Label labelCustomerCompanyDeductions;
        private System.Windows.Forms.Label labelAgentCustomerDeductions;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ListView listViewDealSet;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.PictureBox Logo;
    }
}