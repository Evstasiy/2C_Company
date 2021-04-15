using _2C_Company.DataBase.DataModels;
using _2C_Company.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2C_Company.DataBase
{
    public partial class FormOrders : Form
    {

        private readonly DatabaseContext dbContext;
        private Refill refill;
        private User user;
        public FormOrders(DatabaseContext dbContext, User user, int refillNumber)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.user = user;
            
            refill = dbContext.Refills.FirstOrDefault(x => x.Number == refillNumber);
            SetRefillLableInfo(refill);
            UpdateGridOrders(dbContext.Orders);
            
        }

        private void SelectedOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.CurrentRow != null&& refill.Balance != 0) {
                var orderNumber = (int)dataGridViewOrders.CurrentRow.Cells[dataGridViewOrders.Columns["Number"].Index].Value;
                var order = dbContext.Orders.FirstOrDefault(x => x.Number == orderNumber);

                decimal orderSumPay = order.Sum - order.SumPay;
                decimal sumPay = (orderSumPay < refill.Balance) ? orderSumPay : (decimal)refill.Balance;
                var payment = new Payment()
                {
                    OrderNumber = orderNumber,
                    RefillNumber = refill.Number,
                    SumPay = sumPay,
                    UserId = user.Id
                };
                dbContext.Payments.Add(payment);
                dbContext.SaveChanges();
                UpdateGridOrders(dbContext.Orders);
                refill.Balance -= sumPay;
                SetRefillLableInfo(refill);
            }
        }

        private void UpdateGridOrders(IEnumerable<Order> orders)
        {
            dataGridViewOrders.Rows.Clear();
            var context = ((System.Data.Entity.Infrastructure.IObjectContextAdapter)dbContext).ObjectContext;
            context.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, orders);
            orders = orders.Where(x => x.Sum != x.SumPay && (user.Id == x.UserId || x.UserId== null));
            foreach (var order in orders)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewOrders);
                row.Cells[dataGridViewOrders.Columns["Number"].Index].Value = order.Number;
                row.Cells[dataGridViewOrders.Columns["Date"].Index].Value = order.Date;
                row.Cells[dataGridViewOrders.Columns["Sum"].Index].Value = order.Sum;
                row.Cells[dataGridViewOrders.Columns["SumPayment"].Index].Value = order.SumPay;
                dataGridViewOrders.Rows.Add(row);
            }
        }

        private void SetRefillLableInfo(Refill refill) {
            RefillInfo.Text = $"User balance: {refill.Balance} ";
        }

        private void FormOrders_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
