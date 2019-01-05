using SqlCustomersDAL;
using System.Collections.Generic;
using System.Data;

namespace SqlCustomersBLL
{
    public class SqlCustomersBLManager
    {
        //create a data-access manager
        SqlCustomersDAManager daManager = new SqlCustomersDAManager();

        public Customer GetCustomerById(int id)
        {
            Customer customer = new Customer();

            DataTable dt = daManager.GetCustomerById(id);

            foreach (DataRow i in dt.Rows)
            {
                customer.Id = (int)i["Id"];
                customer.CustomerName = i["CustomerName"].ToString();
                customer.SumOfPurchases = (int)i["SumOfPurchases"];
                customer.City = i["City"].ToString();
                customer.Telephone = i["Telephone"].ToString();
                customer.AccountManager = i["AccountManager"].ToString();
                customer.Category = i["Category"].ToString();
            }

            return customer;
        }

        public void InsertCustomer(Customer customer, out int newId)
        {
            daManager.InsertCustomer(customer.CustomerName, customer.SumOfPurchases,
                customer.City, customer.Telephone, customer.AccountManager, 
                customer.Category, out newId);
        }

        public void UpdateCustomer(Customer customer)
        {
            daManager.UpdateCustomer(customer.Id, customer.CustomerName,
                customer.SumOfPurchases, customer.City, customer.Telephone,
                customer.AccountManager, customer.Category);
        }

        public void DeleteCustomer(int id)
        {
            daManager.DeleteCustomer(id);
        }

        public List<Customer> GetCustomers(string customerName, string city,
            string accountManager, string category,
            string sortExpression, string sortDirection, int pageNumber, 
            int pageSize, out int currentPage, out int numberOfPages,
            out string canMoveFivePagesBackward, out string canMoveOnePageBackward,
            out string canMoveOnePageForward, out string canMoveFivePagesForward)
        {
            List<Customer> customers = new List<Customer>();

            DataTable dt = daManager.GetCustomers(customerName, city, accountManager,
                category, sortExpression, sortDirection, pageNumber, pageSize,
                out currentPage, out numberOfPages,
                out canMoveFivePagesBackward, out canMoveOnePageBackward,
                out canMoveOnePageForward, out canMoveFivePagesForward);

            foreach (DataRow i in dt.Rows)
            {
                Customer customer = new Customer();

                customer.Id = (int)i["Id"];
                customer.CustomerName = i["CustomerName"].ToString();
                customer.SumOfPurchases = (int)i["SumOfPurchases"];
                customer.City = i["City"].ToString();
                customer.Telephone = i["Telephone"].ToString();
                customer.AccountManager = i["AccountManager"].ToString();
                customer.Category = i["Category"].ToString();

                customers.Add(customer);
            }

            return customers;
        }

        public List<Customer> GetCustomersBySumOfPurchasesLevel(int sumOfPurchasesLevel, 
            string sortExpression, string sortDirection, int pageNumber, int pageSize, 
            out int sumOfPurchasesForLevel, out int currentPage, out int numberOfPages,
            out string canMoveFivePagesBackward, out string canMoveOnePageBackward,
            out string canMoveOnePageForward, out string canMoveFivePagesForward)
        {
            List<Customer> customers = new List<Customer>();

            DataTable dt = daManager.GetCustomersBySumOfPurchasesLevel(sumOfPurchasesLevel, 
                sortExpression, sortDirection, pageNumber, pageSize,
                out sumOfPurchasesForLevel, out currentPage, out numberOfPages, 
                out canMoveFivePagesBackward, out canMoveOnePageBackward, 
                out canMoveOnePageForward, out canMoveFivePagesForward);

            foreach (DataRow i in dt.Rows)
            {
                Customer customer = new Customer();

                customer.Id = (int)i["Id"];
                customer.CustomerName = i["CustomerName"].ToString();
                customer.SumOfPurchases = (int)i["SumOfPurchases"];
                customer.City = i["City"].ToString();
                customer.Telephone = i["Telephone"].ToString();
                customer.AccountManager = i["AccountManager"].ToString();
                customer.Category = i["Category"].ToString();

                customers.Add(customer);
            }

            return customers;
        }

        public List<CustomerAuditData> GetCustomersAuditData(int? customerId,
            string operation, string sortExpression, string sortDirection, int pageNumber,
            int pageSize, out int currentPage, out int numberOfPages, 
            out string canMoveFivePagesBackward, out string canMoveOnePageBackward,
            out string canMoveOnePageForward, out string canMoveFivePagesForward)
        {
            List<CustomerAuditData> customerAuditDatas = new List<CustomerAuditData>();

            DataTable dt = daManager.GetCustomersAuditData(customerId, operation,
                sortExpression, sortDirection, pageNumber, pageSize,
                out currentPage, out numberOfPages,
                out canMoveFivePagesBackward, out canMoveOnePageBackward,
                out canMoveOnePageForward, out canMoveFivePagesForward);

            foreach (DataRow i in dt.Rows)
            {
                CustomerAuditData customerAuditData = new CustomerAuditData();

                customerAuditData.Id = (int)i["Id"];
                customerAuditData.CustomerId = (int)i["CustomerId"];
                customerAuditData.AuditData = i["AuditData"].ToString();
                customerAuditData.Operation = i["Operation"].ToString();

                customerAuditDatas.Add(customerAuditData);
            }

            return customerAuditDatas;
        }
    }
}
