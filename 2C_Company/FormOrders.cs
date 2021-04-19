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

            dbContext.Refresh(dbContext.Refills);
            refill = dbContext.Refills.FirstOrDefault(x => x.Number == refillNumber);
            UpdateGridOrders(dbContext.Orders);
            FormClosing += FormOrders_FormClosing;
            dbContext.isRefreshDb += DbContext_isRefreshDb;
            dbContext.Refresh(dbContext.Refills);
        }

        private void DbContext_isRefreshDb()
        {
            RefillInfo.Text = $"User balance: {refill.Balance} ";
        }

        private void FormOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            user.isLogin = false;
            dbContext.SaveChanges();
        }

        private void SelectedOrder_Click(object sender, EventArgs e)
        {
            dbContext.Refresh(dbContext.Refills);
            if (dataGridViewOrders.CurrentRow != null && refill.Balance != 0)
            {
                var orderNumber = (int)dataGridViewOrders.CurrentRow.Cells[dataGridViewOrders.Columns["Number"].Index].Value;
                dbContext.Refresh(dbContext.Orders);
                var order = dbContext.Orders.FirstOrDefault(x => x.Number == orderNumber);
                if (order.UserId != null && order.UserId != user.Id)
                {
                    MessageBox.Show("Извините, в настоящий момент заказ не доступен", "Заказ не доступен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    UpdateGridOrders(dbContext.Orders);
                    return;
                }
                decimal moneyUserPay = 0;
                decimal.TryParse(moneyCountRefill.Text, out moneyUserPay);

                moneyUserPay = (moneyUserPay > refill.Balance || moneyUserPay == 0) ? refill.Balance : moneyUserPay;
                decimal orderSumPay = order.Sum - order.SumPay;
                decimal sumPay = (orderSumPay < moneyUserPay) ? orderSumPay : moneyUserPay;
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
                dbContext.Refresh(dbContext.Refills);
            }
            else if(refill.Balance == 0)
            {
                MessageBox.Show("На балансе недостаточно средств", "Недостаточно средств", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dbContext.Refresh(dbContext.Orders); 
                UpdateGridOrders(dbContext.Orders);
            }
        }

        private void UpdateGridOrders(IEnumerable<Order> orders)
        {
            dataGridViewOrders.Rows.Clear();
            dbContext.Refresh(orders);
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


    }
}
