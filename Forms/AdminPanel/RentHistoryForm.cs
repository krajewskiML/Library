using Library.Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms.AdminPanel
{
    public partial class RentHistoryForm : Form
    {
        public RentHistoryForm(User user, List<Rent> rents)
        {
            InitializeComponent();
            assignLabel(user);
            fillRents(rents);
        }

        public void assignLabel(User user)
        {
            UserRentHistoryLabel.Text = $"{user.UserName}'s rents:";
        }

        public void fillRents(List<Rent> rents)
        {
            RentHistoryListBox.DataSource = rents;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
