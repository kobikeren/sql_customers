using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SqlCustomersDAL
{
    public class SqlCustomersDAManager
    {
        //create a connection
        SqlConnection con = new SqlConnection(
            ConfigurationManager.ConnectionStrings["customersCS"].ConnectionString);

        public DataTable GetCustomerById(int id)
        {
            SqlDataAdapter da = new SqlDataAdapter("spGetCustomerById", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterId = new SqlParameter()
            {
                ParameterName = "@Id",
                Value = id
            };
            da.SelectCommand.Parameters.Add(parameterId);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void InsertCustomer(string customerName, int sumOfPurchases, string city,
            string telephone, string accountManager, string category, out int newId)
        {
            SqlCommand cmd = new SqlCommand("spInsertCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterCustomerName = new SqlParameter()
            {
                ParameterName = "@CustomerName",
                Value = customerName
            };
            cmd.Parameters.Add(parameterCustomerName);

            SqlParameter parameterSumOfPurchases = new SqlParameter()
            {
                ParameterName = "@SumOfPurchases",
                Value = sumOfPurchases
            };
            cmd.Parameters.Add(parameterSumOfPurchases);

            SqlParameter parameterCity = new SqlParameter()
            {
                ParameterName = "@City",
                Value = city
            };
            cmd.Parameters.Add(parameterCity);

            SqlParameter parameterTelephone = new SqlParameter()
            {
                ParameterName = "@Telephone",
                Value = telephone
            };
            cmd.Parameters.Add(parameterTelephone);

            SqlParameter parameterAccountManager = new SqlParameter()
            {
                ParameterName = "@AccountManager",
                Value = accountManager
            };
            cmd.Parameters.Add(parameterAccountManager);

            SqlParameter parameterCategory = new SqlParameter()
            {
                ParameterName = "@Category",
                Value = category
            };
            cmd.Parameters.Add(parameterCategory);

            SqlParameter parameterNewId = new SqlParameter()
            {
                ParameterName = "@NewId",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.Int
            };
            cmd.Parameters.Add(parameterNewId);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            newId = (int)parameterNewId.Value;
        }

        public void UpdateCustomer(int id, string customerName, int sumOfPurchases, 
            string city, string telephone, string accountManager, string category)
        {
            SqlCommand cmd = new SqlCommand("spUpdateCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterId = new SqlParameter()
            {
                ParameterName = "@Id",
                Value = id
            };
            cmd.Parameters.Add(parameterId);

            SqlParameter parameterCustomerName = new SqlParameter()
            {
                ParameterName = "@CustomerName",
                Value = customerName
            };
            cmd.Parameters.Add(parameterCustomerName);

            SqlParameter parameterSumOfPurchases = new SqlParameter()
            {
                ParameterName = "@SumOfPurchases",
                Value = sumOfPurchases
            };
            cmd.Parameters.Add(parameterSumOfPurchases);

            SqlParameter parameterCity = new SqlParameter()
            {
                ParameterName = "@City",
                Value = city
            };
            cmd.Parameters.Add(parameterCity);

            SqlParameter parameterTelephone = new SqlParameter()
            {
                ParameterName = "@Telephone",
                Value = telephone
            };
            cmd.Parameters.Add(parameterTelephone);

            SqlParameter parameterAccountManager = new SqlParameter()
            {
                ParameterName = "@AccountManager",
                Value = accountManager
            };
            cmd.Parameters.Add(parameterAccountManager);

            SqlParameter parameterCategory = new SqlParameter()
            {
                ParameterName = "@Category",
                Value = category
            };
            cmd.Parameters.Add(parameterCategory);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteCustomer(int id)
        {
            SqlCommand cmd = new SqlCommand("spDeleteCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterId = new SqlParameter()
            {
                ParameterName = "@Id",
                Value = id
            };
            cmd.Parameters.Add(parameterId);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable GetCustomers(string customerName, string city,
            string accountManager, string category, string sortExpression, 
            string sortDirection, int pageNumber, int pageSize,
            out int currentPage, out int numberOfPages,
            out string canMoveFivePagesBackward, out string canMoveOnePageBackward,
            out string canMoveOnePageForward, out string canMoveFivePagesForward)
        {
            SqlDataAdapter da = new SqlDataAdapter("spGetCustomers", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (customerName != null)
            {
                SqlParameter parameterCustomerName = new SqlParameter()
                {
                    ParameterName = "@CustomerName",
                    Value = customerName
                };
                da.SelectCommand.Parameters.Add(parameterCustomerName);    
            }

            if (city != null)
            {
                SqlParameter parameterCity = new SqlParameter()
                {
                    ParameterName = "@City",
                    Value = city
                };
                da.SelectCommand.Parameters.Add(parameterCity);
            }

            if (accountManager != null)
            {
                SqlParameter parameterAccountManager = new SqlParameter()
                {
                    ParameterName = "@AccountManager",
                    Value = accountManager
                };
                da.SelectCommand.Parameters.Add(parameterAccountManager);
            }

            if (category != null)
            {
                SqlParameter parameterCategory = new SqlParameter()
                {
                    ParameterName = "@Category",
                    Value = category
                };
                da.SelectCommand.Parameters.Add(parameterCategory);
            }

            SqlParameter parameterSortExpression = new SqlParameter()
            {
                ParameterName = "@SortExpression",
                Value = sortExpression
            };
            da.SelectCommand.Parameters.Add(parameterSortExpression);

            SqlParameter parameterSortDirection = new SqlParameter()
            {
                ParameterName = "@SortDirection",
                Value = sortDirection
            };
            da.SelectCommand.Parameters.Add(parameterSortDirection);

            SqlParameter parameterPageNumber = new SqlParameter()
            {
                ParameterName = "@PageNumber",
                Value = pageNumber
            };
            da.SelectCommand.Parameters.Add(parameterPageNumber);

            SqlParameter parameterPageSize = new SqlParameter()
            {
                ParameterName = "@PageSize",
                Value = pageSize
            };
            da.SelectCommand.Parameters.Add(parameterPageSize);

            SqlParameter parameterCurrentPage = new SqlParameter()
            {
                ParameterName = "@CurrentPage",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.Int
            };
            da.SelectCommand.Parameters.Add(parameterCurrentPage);

            SqlParameter parameterNumberOfPages = new SqlParameter()
            {
                ParameterName = "@NumberOfPages",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.Int
            };
            da.SelectCommand.Parameters.Add(parameterNumberOfPages);

            SqlParameter parameterCanMoveFivePagesBackward = new SqlParameter()
            {
                ParameterName = "@CanMoveFivePagesBackward",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50
            };
            da.SelectCommand.Parameters.Add(parameterCanMoveFivePagesBackward);

            SqlParameter parameterCanMoveOnePageBackward = new SqlParameter()
            {
                ParameterName = "@CanMoveOnePageBackward",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50
            };
            da.SelectCommand.Parameters.Add(parameterCanMoveOnePageBackward);

            SqlParameter parameterCanMoveOnePageForward = new SqlParameter()
            {
                ParameterName = "@CanMoveOnePageForward",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50
            };
            da.SelectCommand.Parameters.Add(parameterCanMoveOnePageForward);

            SqlParameter parameterCanMoveFivePagesForward = new SqlParameter()
            {
                ParameterName = "@CanMoveFivePagesForward",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50
            };
            da.SelectCommand.Parameters.Add(parameterCanMoveFivePagesForward);

            DataTable dt = new DataTable();
            da.Fill(dt);

            currentPage = (int)parameterCurrentPage.Value;
            numberOfPages = (int)parameterNumberOfPages.Value;
            canMoveFivePagesBackward = parameterCanMoveFivePagesBackward.Value.ToString();
            canMoveOnePageBackward = parameterCanMoveOnePageBackward.Value.ToString();
            canMoveOnePageForward = parameterCanMoveOnePageForward.Value.ToString();
            canMoveFivePagesForward = parameterCanMoveFivePagesForward.Value.ToString();

            return dt;
        }

        public DataTable GetCustomersBySumOfPurchasesLevel(int sumOfPurchasesLevel,
            string sortExpression, string sortDirection, int pageNumber, int pageSize,
            out int sumOfPurchasesForLevel, out int currentPage, out int numberOfPages,
            out string canMoveFivePagesBackward, out string canMoveOnePageBackward,
            out string canMoveOnePageForward, out string canMoveFivePagesForward)
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "spGetCustomersBySumOfPurchasesLevel", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterSumOfPurchasesLevel = new SqlParameter()
            {
                ParameterName = "@SumOfPurchasesLevel",
                Value = sumOfPurchasesLevel
            };
            da.SelectCommand.Parameters.Add(parameterSumOfPurchasesLevel);

            SqlParameter parameterSortExpression = new SqlParameter()
            {
                ParameterName = "@SortExpression",
                Value = sortExpression
            };
            da.SelectCommand.Parameters.Add(parameterSortExpression);

            SqlParameter parameterSortDirection = new SqlParameter()
            {
                ParameterName = "@SortDirection",
                Value = sortDirection
            };
            da.SelectCommand.Parameters.Add(parameterSortDirection);
                        
            SqlParameter parameterPageNumber = new SqlParameter()
            {
                ParameterName = "@PageNumber",
                Value = pageNumber
            };
            da.SelectCommand.Parameters.Add(parameterPageNumber);

            SqlParameter parameterPageSize = new SqlParameter()
            {
                ParameterName = "@PageSize",
                Value = pageSize
            };
            da.SelectCommand.Parameters.Add(parameterPageSize);

            SqlParameter parameterSumOfPurchasesForLevel = new SqlParameter()
            {
                ParameterName = "@SumOfPurchasesForLevel",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.Int
            };
            da.SelectCommand.Parameters.Add(parameterSumOfPurchasesForLevel);

            SqlParameter parameterCurrentPage = new SqlParameter()
            {
                ParameterName = "@CurrentPage",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.Int
            };
            da.SelectCommand.Parameters.Add(parameterCurrentPage);

            SqlParameter parameterNumberOfPages = new SqlParameter()
            {
                ParameterName = "@NumberOfPages",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.Int
            };
            da.SelectCommand.Parameters.Add(parameterNumberOfPages);

            SqlParameter parameterCanMoveFivePagesBackward = new SqlParameter()
            {
                ParameterName = "@CanMoveFivePagesBackward",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50
            };
            da.SelectCommand.Parameters.Add(parameterCanMoveFivePagesBackward);

            SqlParameter parameterCanMoveOnePageBackward = new SqlParameter()
            {
                ParameterName = "@CanMoveOnePageBackward",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50
            };
            da.SelectCommand.Parameters.Add(parameterCanMoveOnePageBackward);

            SqlParameter parameterCanMoveOnePageForward = new SqlParameter()
            {
                ParameterName = "@CanMoveOnePageForward",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50
            };
            da.SelectCommand.Parameters.Add(parameterCanMoveOnePageForward);

            SqlParameter parameterCanMoveFivePagesForward = new SqlParameter()
            {
                ParameterName = "@CanMoveFivePagesForward",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50
            };
            da.SelectCommand.Parameters.Add(parameterCanMoveFivePagesForward);

            DataTable dt = new DataTable();
            da.Fill(dt);

            sumOfPurchasesForLevel = (int)parameterSumOfPurchasesForLevel.Value;
            currentPage = (int)parameterCurrentPage.Value;
            numberOfPages = (int)parameterNumberOfPages.Value;
            canMoveFivePagesBackward = parameterCanMoveFivePagesBackward.Value.ToString();
            canMoveOnePageBackward = parameterCanMoveOnePageBackward.Value.ToString();
            canMoveOnePageForward = parameterCanMoveOnePageForward.Value.ToString();
            canMoveFivePagesForward = parameterCanMoveFivePagesForward.Value.ToString();

            return dt;
        }

        public DataTable GetCustomersAuditData(int? customerId, string operation,
            string sortExpression, string sortDirection, int pageNumber, int pageSize,
            out int currentPage, out int numberOfPages,
            out string canMoveFivePagesBackward, out string canMoveOnePageBackward,
            out string canMoveOnePageForward, out string canMoveFivePagesForward)
        {
            SqlDataAdapter da = new SqlDataAdapter("spGetCustomersAuditData", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (customerId != null)
            {
                SqlParameter parameterCustomerId = new SqlParameter()
                {
                    ParameterName = "@CustomerId",
                    Value = customerId
                };
                da.SelectCommand.Parameters.Add(parameterCustomerId);
            }

            if (operation != null)
            {
                SqlParameter parameterOperation = new SqlParameter()
                {
                    ParameterName = "@Operation",
                    Value = operation
                };
                da.SelectCommand.Parameters.Add(parameterOperation);
            }

            SqlParameter parameterSortExpression = new SqlParameter()
            {
                ParameterName = "@SortExpression",
                Value = sortExpression
            };
            da.SelectCommand.Parameters.Add(parameterSortExpression);

            SqlParameter parameterSortDirection = new SqlParameter()
            {
                ParameterName = "@SortDirection",
                Value = sortDirection
            };
            da.SelectCommand.Parameters.Add(parameterSortDirection);

            SqlParameter parameterPageNumber = new SqlParameter()
            {
                ParameterName = "@PageNumber",
                Value = pageNumber
            };
            da.SelectCommand.Parameters.Add(parameterPageNumber);

            SqlParameter parameterPageSize = new SqlParameter()
            {
                ParameterName = "@PageSize",
                Value = pageSize
            };
            da.SelectCommand.Parameters.Add(parameterPageSize);

            SqlParameter parameterCurrentPage = new SqlParameter()
            {
                ParameterName = "@CurrentPage",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.Int
            };
            da.SelectCommand.Parameters.Add(parameterCurrentPage);

            SqlParameter parameterNumberOfPages = new SqlParameter()
            {
                ParameterName = "@NumberOfPages",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.Int
            };
            da.SelectCommand.Parameters.Add(parameterNumberOfPages);

            SqlParameter parameterCanMoveFivePagesBackward = new SqlParameter()
            {
                ParameterName = "@CanMoveFivePagesBackward",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50
            };
            da.SelectCommand.Parameters.Add(parameterCanMoveFivePagesBackward);

            SqlParameter parameterCanMoveOnePageBackward = new SqlParameter()
            {
                ParameterName = "@CanMoveOnePageBackward",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50
            };
            da.SelectCommand.Parameters.Add(parameterCanMoveOnePageBackward);

            SqlParameter parameterCanMoveOnePageForward = new SqlParameter()
            {
                ParameterName = "@CanMoveOnePageForward",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50
            };
            da.SelectCommand.Parameters.Add(parameterCanMoveOnePageForward);

            SqlParameter parameterCanMoveFivePagesForward = new SqlParameter()
            {
                ParameterName = "@CanMoveFivePagesForward",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50
            };
            da.SelectCommand.Parameters.Add(parameterCanMoveFivePagesForward);

            DataTable dt = new DataTable();
            da.Fill(dt);

            currentPage = (int)parameterCurrentPage.Value;
            numberOfPages = (int)parameterNumberOfPages.Value;
            canMoveFivePagesBackward = parameterCanMoveFivePagesBackward.Value.ToString();
            canMoveOnePageBackward = parameterCanMoveOnePageBackward.Value.ToString();
            canMoveOnePageForward = parameterCanMoveOnePageForward.Value.ToString();
            canMoveFivePagesForward = parameterCanMoveFivePagesForward.Value.ToString();

            return dt;
        }
    }
}
