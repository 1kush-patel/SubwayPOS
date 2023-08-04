using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SubwayPOS
{
    public partial class RestaurantFunctions : Form
    {
        public int userID;
        public string userName;
        public RestaurantFunctions(int currentUserId, String currentUserName)
        {
            InitializeComponent();
            userID = currentUserId;
            userName = currentUserName;

        }

        private void btnReprintReceipt_Click(object sender, EventArgs e)
        {

        }

        private void btnMinCashIn_Click(object sender, EventArgs e)
        {
            _1MinuteCashIn minuteCashIn = new _1MinuteCashIn(userID, userName);
            minuteCashIn.Show();
            // Hide();
        }

        private void RestaurantFunctions_Load(object sender, EventArgs e)
        {
            lblUserNamelabel.Text = userName;
        }
    }
}
