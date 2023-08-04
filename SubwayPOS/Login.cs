using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SubwayPOS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string connectionString = "Data Source = DESKTOP - L6VKGRE; Initial Catalog = Subway; Integrated Security = True";

        private void Login_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(" SELECT USERID, USERNAME FROM USERS WHERE USERID='26' ", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() && reader["USERID"].ToString().Equals("26"))
            {

            }
            con.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                int userId;
                userId = int.TryParse(txt_userId.Text, out userId) ? int.Parse(txt_userId.Text) : throw new FormatException("userId");
                int passWord;
                passWord = int.TryParse(txt_password.Text, out passWord) ? int.Parse(txt_password.Text) : throw new FormatException("passWord");

                SqlDataReader reader = Model.authenticateUser(userId, passWord);


                if (reader.Read())
                {
                    HomeScreen homeScreenMain = new HomeScreen(int.Parse(reader["USERID"].ToString()), reader["USERNAME"].ToString());
                    homeScreenMain.Show();
                    Hide();
                }
                else
                {
                    txt_userId.Text = "";
                    txt_password.Text = "";
                    MessageBox.Show("Incorrect User Id or Password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.FormatException ex)
            {
                if (ex.Message.Equals("userId"))
                {
                    txt_userId.Text = "";
                    txt_userId.Focus();
                    MessageBox.Show("Please enter valid numeric value for User ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (ex.Message.Equals("passWord"))
                {
                    txt_password.Text = "";
                    txt_userId.Focus();
                    MessageBox.Show("Please enter valid numeric value for Password.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.GetType());
            }
        }
    }
}
