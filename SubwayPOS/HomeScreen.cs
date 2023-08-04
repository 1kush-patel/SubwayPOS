using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SubwayPOS
{
    public partial class HomeScreen : Form
    {
        public int userID;
        public string userName;
        public HomeScreen(int currentUserId, string currentUserName)
        {
            InitializeComponent();
            userID = currentUserId;
            userName = currentUserName;
        }
        public HomeScreen()
        {
            InitializeComponent();
          
        }

        private void btnRestaurantFunction_Click(object sender, EventArgs e)
        {
            RestaurantFunctions restaurantFunctions = new RestaurantFunctions(userID, userName);
            restaurantFunctions.Show();
            Hide();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            lblUsername.Text = userName;

        }

        private void btnSalesInfo_Click(object sender, EventArgs e)
        {
            SalesInfo salesInfos = new SalesInfo(userID, userName);
            salesInfos.Show();
            //Hide(); 
        }
    }
}
