namespace _2C_Company
{
    partial class FormRefills
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
            this.dataGridViewRefill = new System.Windows.Forms.DataGridView();
            this.OpenFormOrder = new System.Windows.Forms.Button();
            this.AddMoney = new System.Windows.Forms.Button();
            this.moneyCountAdd = new System.Windows.Forms.MaskedTextBox();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRefill)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRefill
            // 
            this.dataGridViewRefill.AllowUserToAddRows = false;
            this.dataGridViewRefill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRefill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRefill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Date,
            this.Sum,
            this.Balance});
            this.dataGridViewRefill.Location = new System.Drawing.Point(12, 52);
            this.dataGridViewRefill.MultiSelect = false;
            this.dataGridViewRefill.Name = "dataGridViewRefill";
            this.dataGridViewRefill.ReadOnly = true;
            this.dataGridViewRefill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRefill.ShowRowErrors = false;
            this.dataGridViewRefill.Size = new System.Drawing.Size(502, 358);
            this.dataGridViewRefill.TabIndex = 1;
            // 
            // OpenFormOrder
            // 
            this.OpenFormOrder.Location = new System.Drawing.Point(12, 12);
            this.OpenFormOrder.Name = "OpenFormOrder";
            this.OpenFormOrder.Size = new System.Drawing.Size(118, 25);
            this.OpenFormOrder.TabIndex = 2;
            this.OpenFormOrder.Text = "Оплатить заказы";
            this.OpenFormOrder.UseVisualStyleBackColor = true;
            this.OpenFormOrder.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddMoney
            // 
            this.AddMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddMoney.Location = new System.Drawing.Point(281, 12);
            this.AddMoney.Name = "AddMoney";
            this.AddMoney.Size = new System.Drawing.Size(95, 25);
            this.AddMoney.TabIndex = 3;
            this.AddMoney.Text = "Внести деньги";
            this.AddMoney.UseVisualStyleBackColor = true;
            this.AddMoney.Click += new System.EventHandler(this.AddMoney_Click);
            // 
            // moneyCountAdd
            // 
            this.moneyCountAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moneyCountAdd.Location = new System.Drawing.Point(398, 15);
            this.moneyCountAdd.Mask = "000000";
            this.moneyCountAdd.Name = "moneyCountAdd";
            this.moneyCountAdd.Size = new System.Drawing.Size(100, 20);
            this.moneyCountAdd.TabIndex = 4;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Sum
            // 
            this.Sum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sum.HeaderText = "Sum";
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(136, 14);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(115, 21);
            this.comboBoxUsers.TabIndex = 5;
            // 
            // FormRefills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 427);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.moneyCountAdd);
            this.Controls.Add(this.AddMoney);
            this.Controls.Add(this.OpenFormOrder);
            this.Controls.Add(this.dataGridViewRefill);
            this.Name = "FormRefills";
            this.Text = "Платежи";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRefill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewRefill;
        private System.Windows.Forms.Button OpenFormOrder;
        private System.Windows.Forms.Button AddMoney;
        private System.Windows.Forms.MaskedTextBox moneyCountAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.ComboBox comboBoxUsers;
    }
}

