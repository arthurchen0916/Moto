using Moto.Common.Entities;
using Moto.Common.Interfaces;
using Moto.Common.Models;
using Moto.Dal;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Moto.Core
{
    public class CustomerService
    {
        ICustomerRepository customerRepository;

        public CustomerService()
        {
            customerRepository = new CustomerRepository();
        }
        //Read
        public IEnumerable<Customer> GetAll()
        {
            var result = customerRepository.FindAll();
            return result;
        }



        [HttpPost]
        public IEnumerable<Customer> Query(CustomerManagement m,string btn,string sql)
        {
           if (btn.Equals("Query"))
                    {
                         sql = "select * from dbo.Customer where 1=1 ";

                        if (!string.IsNullOrEmpty(m.Phone_Number)) { sql += $" and Phone_Number  ={m.Phone_Number}"; }
                        if (!string.IsNullOrEmpty(m.Tel_Number)) { sql += " and Tel_Number =" + m.Tel_Number; }
                        if (!string.IsNullOrEmpty(m.Name)) { sql += " and Name like" + "'%" + m.Name + "%'"; }
                        if (!string.IsNullOrEmpty(m.License_Plate)) { sql += " and License_Plate =" + "'" + m.License_Plate + "'"; }
                        if (!string.IsNullOrEmpty(m.Address)) { sql += " and Address like" + "'%" + m.Address + "%'"; }
                    }

            else if (btn.Equals("Create"))
                    {  
                          sql = "insert into Customer(Name,License_Plate,Phone_Number,Tel_Number,Address,Del_Flag,Update_Date)Values(" + "'" + m.Name + "'" + "," + "'" + m.License_Plate + "'" + "," + "'" + m.Phone_Number + "'" + "," + "'" + m.Tel_Number + "'" + "," + "'" + m.Address + "'" + ",0," + "GETDATE()) ";
                   }

            var result = customerRepository.QueryCustomerBySql(sql);
            return result;
        }


    }
}