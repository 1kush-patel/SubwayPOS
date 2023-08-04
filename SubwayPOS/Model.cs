using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SubwayPOS
{
    public class Model
    {
        public static string connectionString = "Data Source=DESKTOP-L6VKGRE;Initial Catalog = SUBWAY; Integrated Security = True";
        public static SqlConnection con;
        public static SqlDataReader authenticateUser(int userId, int passWord)
        {
            //opening conncetion
            openConnection();

            //logic for autnemtication
            string authenticationQurery = $"SELECT USERID, USERNAME, PASSWORD FROM USERS WHERE USERID = {userId} AND PASSWORD = {passWord}";
            SqlCommand cmd = new SqlCommand(authenticationQurery, con);
            cmd.Parameters.AddWithValue("ID", userId);
            cmd.Parameters.AddWithValue("PASSWORD", passWord);
            SqlDataReader reader = cmd.ExecuteReader();
            
            //closing connection
            return reader;
        }
        public static SqlDataReader getSalesInfoWithUserId(int userId)
        {
            //opening conncetion
            openConnection();
            userId = 26;

                  SqlCommand cmd = new SqlCommand($"SELECT USERID, USERNAME, DATE, TIME, ORDERITEMS, ACTUALAMOUNT, AMOUNTGIVENBYCUSTOMER, RETURNEDAMOUNT, TAXAMOUNT, PAYMENTTYPE FROM SALESINFO WHERE USERID= {userId}", con);
                SqlDataReader reader = cmd.ExecuteReader();
               

            //closing connection
            return reader;
        }
        public static void openConnection()
        {
            con = new SqlConnection(connectionString);
            con.Open();
        }

        public static void closeConnection()
        { 
            con.Close();
        }

        public static int Add1MinuteCashDetails(int userId,String userName, decimal looseCurrency, decimal coinDispenser, decimal total, decimal breadCount, int salad, int wrap)
        {
             userId = 26; // Change this to the actual user ID
           
            //opening conncetion
            openConnection();
           
            string insertQuery = "INSERT INTO DAILYSTOREREPORT (USERID, USERNAME, LOOSECURRENCY, COINDESPENSER, TOTAL, BREADCOUNT, SALAD, WRAP, DATE, TIME) " +
                                    "VALUES (@UserID, @UserName, @LooseCurrency, @CoinDispenser, @Total, @BreadCount, @Salad, @Wrap, GETDATE(), GETDATE())";

            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@UserID", userId);
            cmd.Parameters.AddWithValue("@UserName", userName);
            cmd.Parameters.AddWithValue("@LooseCurrency", looseCurrency);
            cmd.Parameters.AddWithValue("@CoinDispenser", coinDispenser);
            cmd.Parameters.AddWithValue("@Total", total);
            cmd.Parameters.AddWithValue("@BreadCount", breadCount);
            cmd.Parameters.AddWithValue("@Salad", salad);
            cmd.Parameters.AddWithValue("@Wrap", wrap);

            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected;
        }
    }
}
