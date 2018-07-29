using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YNAB_Desktop.ynab_account;

namespace YNAB_Desktop
{
    public partial class frm_Main : Form
    {
        private Ynab_Account account;
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_setToken_Click(object sender, EventArgs e)
        {
            account = new Ynab_Account(this, eb_accessToken.Text, true);
        }

        private void btn_fetchBudgets_Click(object sender, EventArgs e)
        {
            account.getBudgetsData();
        }

        public void addObjectsToGrid(string id, string name)
        {
            dgBudgets.Rows.Add(id, name);
        }

        public void clearObjectsFromGrid()
        {
            dgBudgets.Rows.Clear();
        }
    }
}
