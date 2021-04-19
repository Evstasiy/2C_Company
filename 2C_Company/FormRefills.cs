using _2C_Company.DataBase;
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

namespace _2C_Company
{
    public partial class FormRefills : Form
    {
        private readonly DatabaseContext dbContext = new DatabaseContext();
        public FormRefills()
        {
            InitializeComponent();
            UpdateCombobox();
            UpdateGridRefill(dbContext.Refills);
        }

        private void UpdateCombobox() {
            comboBoxUsers.Items.Clear();
            comboBoxUsers.Items.AddRange(dbContext.Users.Where(x=>!x.isLogin).Select(x => x.Name).ToArray());
            comboBoxUsers.SelectedItem = (comboBoxUsers.Items.Count>=1)? comboBoxUsers.Items[0] : null;
        }

        private void UpdateGridRefill(IEnumerable<Refill> refills)
        {
            dataGridViewRefill.Rows.Clear();

            dbContext.Refresh(dbContext.Refills);
            refills = refills.Where(x => x.Balance > 0);

            foreach (var refill in refills)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewRefill);
                row.Cells[dataGridViewRefill.Columns["Number"].Index].Value = refill.Number;
                row.Cells[dataGridViewRefill.Columns["Date"].Index].Value = refill.Date;
                row.Cells[dataGridViewRefill.Columns["Sum"].Index].Value = refill.Sum;
                row.Cells[dataGridViewRefill.Columns["Balance"].Index].Value = refill.Balance;
                dataGridViewRefill.Rows.Add(row);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var numberColumn = dataGridViewRefill.Columns["Number"].Index;
            if (dataGridViewRefill.CurrentRow == null)
                return;
            var valueRef = dataGridViewRefill.CurrentRow.Cells[numberColumn].Value.ToString();
            int numberRef = 0;
            if (Int32.TryParse(valueRef, out numberRef)) {
                dbContext.Refresh(dbContext.Users);
                var user = dbContext.Users.FirstOrDefault(x => x.Name == comboBoxUsers.Text);
                if (!user.isLogin)
                {
                    user.isLogin = true;
                    dbContext.SaveChanges();
                    FormOrders formOrders = new FormOrders(dbContext, user, numberRef);
                    var res = formOrders.ShowDialog();
                    if (res == DialogResult.Cancel)
                    {
                        UpdateGridRefill(dbContext.Refills);
                    }
                }
                else {
                    MessageBox.Show("В настоящий момент выбранный аккаунт недоступен, выберите другой аккаунт", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    UpdateCombobox();
                    UpdateGridRefill(dbContext.Refills);
                    return;
                }
            }
        }

        private async void AddMoney_Click(object sender, EventArgs e)
        {
            if (moneyCountAdd.Text == String.Empty) {
                MessageBox.Show("Введите количество денег для пополнения", "Недопустимое значение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int addMoneyCount =Int32.Parse(moneyCountAdd.Text);
            moneyCountAdd.Text = "";
            var refill = new Refill() { Sum = addMoneyCount, Balance = addMoneyCount, Date = DateTime.Now };
            dbContext.Refills.Add(refill);
            await dbContext.SaveChangesAsync();

            UpdateGridRefill(dbContext.Refills);
        }
    }
}
