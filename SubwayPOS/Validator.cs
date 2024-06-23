using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SubwayPOS
{
    public class Validator
    {
        public static bool validatePrice(string price)
        {
            bool result = decimal.TryParse(price, out _);
            if(result)
                return result;
            MessageBox.Show("Please enter valid amount!","Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }
        public static bool isSuperUser(int userId) 
        {
            if(userId == 26)
                return true;
            return false;
        
        }

        public static bool validateAuthCreds(string Id, string PW) 
        {
            try
            {
                int userId;
                userId = int.TryParse(Id, out userId) ? int.Parse(Id) : throw new FormatException("userId");
                int passWord;
                passWord = int.TryParse(PW, out passWord) ? int.Parse(PW) : throw new FormatException("passWord");

            }
            catch (System.FormatException ex)
            {
                if (ex.Message.Equals("userId"))
                {
                    MessageBox.Show("Please enter valid numeric value for User ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else if (ex.Message.Equals("passWord"))
                {
                    MessageBox.Show("Please enter valid numeric value for Password.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.GetType());
                return false;
            }
            return true;
        }
        public static bool _1minuteCashInValidation(string looseMny, string coinDes, string breadCnt, string saladCnt, string wrapCnt)
        {
            try
            {
                decimal LooseMoney, CoinMoney, BreadCount;
                int SaladCount, WrapCount;
                LooseMoney = decimal.TryParse(looseMny, out LooseMoney) ? decimal.Parse(looseMny) : throw new FormatException("LooseMoney");
                CoinMoney = decimal.TryParse(coinDes, out CoinMoney) ? decimal.Parse(coinDes) : throw new FormatException("CoinMoney");
                BreadCount = decimal.TryParse(breadCnt, out BreadCount) ? decimal.Parse(breadCnt) : throw new FormatException("BreadCount");
                SaladCount = int.TryParse(saladCnt, out SaladCount) ? int.Parse(saladCnt) : throw new FormatException("SaladCount");
                WrapCount = int.TryParse(wrapCnt, out WrapCount) ? int.Parse(wrapCnt) : throw new FormatException("WrapCount");
                
            }
            catch (System.FormatException ex)
            {
                if (ex.Message.Equals("LooseMoney"))
                {
                    MessageBox.Show("Please enter valid numeric value for Loose Money.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else if (ex.Message.Equals("CoinMoney"))
                {
                    MessageBox.Show("Please enter valid numeric value for Coin Despensor.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }else if (ex.Message.Equals("BreadCount"))
                {
                    MessageBox.Show("Please enter valid numeric value for Breads.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }else if (ex.Message.Equals("SaladCount"))
                {
                    MessageBox.Show("Please enter valid numeric value for Salad.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }else if (ex.Message.Equals("WrapCount"))
                {
                    MessageBox.Show("Please enter valid numeric value for Wrap.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.GetType());
                return false;
            }
            return true;

        }
        public static bool validateRegistrationCreds(string Id, string password, string name)
        {
            try
            {
                int userId;
                userId = int.TryParse(Id, out userId) ? int.Parse(Id) : throw new FormatException("userId");

                int PassWord;
                PassWord = int.TryParse(password, out PassWord) ? int.Parse(password) : throw new FormatException("password");

                if (name.Equals(""))
                    throw new FormatException("name");
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("userId"))
                {
                    MessageBox.Show("Please enter valid numeric value for User Id.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else if (ex.Message.Equals("password"))
                {
                    MessageBox.Show("Please enter valid numeric value for Password.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                else if (ex.Message.Equals("name"))
                {
                    MessageBox.Show("User Name should not be empty!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                    MessageBox.Show(ex.GetType() + ex.Message);

            }
            return true;

        }
        public static bool validateDeletionCreds(string Id)
        {
            try
            {
                int userId;
                userId = int.TryParse(Id, out userId) ? int.Parse(Id) : throw new FormatException("userId");
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("userId"))
                {
                    MessageBox.Show("Please enter valid numeric value for User Id.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

            }
            return true;
        }
    }
}
