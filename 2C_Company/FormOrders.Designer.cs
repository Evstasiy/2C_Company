namespace _2C_Company.DataBase
{
    partial class FormOrders
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.SelectedOrder = new System.Windows.Forms.Button();
            this.RefillInfo = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Date,
            this.Sum,
            this.SumPayment});
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 53);
            this.dataGridViewOrders.MultiSelect = false;
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.ShowRowErrors = false;
            this.dataGridViewOrders.Size = new System.Drawing.Size(411, 212);
            this.dataGridViewOrders.TabIndex = 2;
            // 
            // SelectedOrder
            // 
            this.SelectedOrder.Location = new System.Drawing.Point(12, 12);
            this.SelectedOrder.Name = "SelectedOrder";
            this.SelectedOrder.Size = new System.Drawing.Size(111, 23);
            this.SelectedOrder.TabIndex = 3;
            this.SelectedOrder.Text = "Внести средства";
            this.SelectedOrder.UseVisualStyleBackColor = true;
            this.SelectedOrder.Click += new System.EventHandler(this.SelectedOrder_Click);
            // 
            // RefillInfo
            // 
            this.RefillInfo.AutoSize = true;
            this.RefillInfo.Location = new System.Drawing.Point(155, 17);
            this.RefillInfo.Name = "RefillInfo";
            this.RefillInfo.Size = new System.Drawing.Size(35, 13);
            this.RefillInfo.TabIndex = 4;
            this.RefillInfo.Text = "label1";
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
            // SumPayment
            // 
            this.SumPayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SumPayment.HeaderText = "SumPayment";
            this.SumPayment.Name = "SumPayment";
            this.SumPayment.ReadOnly = true;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 277);
            this.Controls.Add(this.RefillInfo);
            this.Controls.Add(this.SelectedOrder);
            this.Controls.Add(this.dataGridViewOrders);
            this.Name = "FormOrders";
            this.Text = "FormOrders";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOrders_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button SelectedOrder;
        private System.Windows.Forms.Label RefillInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumPayment;
    }
}