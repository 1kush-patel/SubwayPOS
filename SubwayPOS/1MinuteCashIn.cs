using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SubwayPOS
{
    public partial class _1MinuteCashIn : Form
    {
        public int userID;
        public string userName;
        public _1MinuteCashIn(int currentUserID, String currentUserName)
        {
            InitializeComponent();
            userID = currentUserID;
            userName = currentUserName;
        }



        private void _1MinuteCashIn_Load(object sender, EventArgs e)
        {
            lblusernamelabel.Text = userName;
        }
        private void btnSaveMinuteCashIn_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = 26; // Change this to the actual user ID
                string userName = "Arun"; // Change this to the actual user name

                decimal looseCurrency = Convert.ToDecimal(txtLooseMoney.Text);
                decimal coinDispenser = Convert.ToDecimal(txtCoinsDispenser.Text);
                decimal total = looseCurrency + coinDispenser;
                txtTotalMinCashIn.Text = total.ToString();

                decimal breadCount = Convert.ToDecimal(txtBreadsTextField.Text);
                int salad = Convert.ToInt32(txtSalad.Text);
                int wrap = Convert.ToInt32(txtWrap.Text);

                int rowsAffected = Model.Add1MinuteCashDetails(userId, userName, looseCurrency, coinDispenser, total, breadCount, salad, wrap);

               
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("1 Minute Cash record has been saved successfully!");
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Data save failed!");
                    }
                    Model.closeConnection();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
