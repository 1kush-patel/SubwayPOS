using System;
using System.Collections.Generic;
using System.Text;

namespace SubwayPOS
{
    class Constant
    {
        public static class SqlStatements
        {
            public const string authUser = "SELECT USERID,PASSWORD, USERNAME FROM USERS WHERE USERID = @UserID AND PASSWORD = @Password";
            public const string clockInOutInfoStatement = "SELECT CLOCKIN, CLOCKOUT, DATE, USERID FROM WORKINGHOURS WHERE USERID = @UserId AND DATE = @Date";
            public const string clockInStatement = "INSERT INTO WORKINGHOURS (USERID, CLOCKIN, CLOCKOUT) VALUES (@Userid," +
                "@ClockInTime, @ClockOutTime)";
            public const string clockOutStatement = "UPDATE WORKINGHOURS SET CLOCKOUT = @ClockOutTime WHERE USERID = @UserId";
            public const string submitDailyReportStatement = "INSERT INTO DAILYSTOREREPORT (USERID, USERNAME, LOOSECURRENCY, COINDESPENSER," +
                "TOTAL, BREADCOUNT, SALAD, WRAP, TIME) VALUES (@UserId, @UserName, @LooseCurrency, @CoinDespenser, @Total, @BreadCount, @Salad, @Wrap, @Time)";
            public const string todaysDailyReportStatement = "SELECT * FROM DAILYSTOREREPORT WHERE DATE = @Date";
            public const string getUserByIdStatement = "SELECT * FROM USERS WHERE USERID = @UserId";
            public const string insertEmployeeStatement = "INSERT INTO USERS (USERID, PASSWORD, USERNAME) VALUES (@UserId, @Password, @UserName)";

            public const string punchOrderStatement = "INSERT INTO SALESINFO(USERID, USERNAME, DATE, TIME, ORDERITEMS, ACTUALAMOUNT, AMOUNTGIVENBYCUSTOMER," +
                "RETURNEDAMOUNT, TAXAMOUNT, PAYMENTTYPE) VALUES (@UserId, @UserName, @Date, @Time, @OrderItems, @ActualAmount, @AmountGivenByCustomer, @ReturnedAmount," +
                "@TaxAmount, @PaymentType)";
            public static string allSalesRecordsStatement = "SELECT * FROM SALESINFO ORDER BY DATE DESC";

            public static string lastPunchedOrder = "SELECT TOP 1 * FROM SALESINFO ORDER BY DATE DESC";

            public static string deleteEmployeeStatement = "DELETE FROM USERS WHERE USERID = @UserId";




        }
    }
}
