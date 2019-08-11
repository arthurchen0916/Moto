using Moto.Common.Entities;
using Moto.Common.Interfaces;
using Moto.Common.Models;
using Moto.Dal;
using System.Collections.Generic;
using System.Linq;

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


        public IEnumerable<Customer> Query(CustomerManagement m)
        {
            string sql = "select * from dbo.Customer where 1=1 ";


            //if(m.Brand_code != "") { sql += "and brand_code =" + m.Brand_code; }
            //if (m.Year != "") { sql += " and year =" + m.Year; }
            //if (m.cc_s != "") { sql += " and cc >=" + m.cc_s; }
            //if (m.cc_e != "") { sql += " and cc <=" + m.cc_e; }
            if (!string.IsNullOrEmpty(m.Phone_Number)) { sql += $" and Phone_Number  ={m.Phone_Number}"; }
            if (!string.IsNullOrEmpty(m.Tel_Number)) { sql += " and Tel_Number =" + m.Tel_Number; }
            if (!string.IsNullOrEmpty(m.Name)) { sql += $" and Name ='{m.Name}'"; }
            if (!string.IsNullOrEmpty(m.License_Plate)) { sql += " and License_Plate =" + m.License_Plate; }
            if (!string.IsNullOrEmpty(m.Address)) { sql += " and Address =" + "''m.Address''"; }

            string sql2 = "select count(*) from dbo.Customer where 1=1";

            var result = customerRepository.QueryCustomerBySql(sql,sql2);

            return result;
        }



        public bool Add(Customer model)
        {
            bool result = false;
            var chk = customerRepository.GetById(model.id);
            if (null == chk)
            {
                customerRepository.Add(model);
                result = true;
            }
            else
            {
                // todo something
            }

            return result;
        }

        public bool Update(Customer model)
        {
            bool result = false;
            var chk = customerRepository.GetById(model.id);
            if (null == chk)
            {
                // todo something
            }
            else
            {
                customerRepository.Update(model);
                result = true;
            }

            return result;
        }

        public bool Remove(int id)
        {
            bool result = false;
            var chk = customerRepository.GetById(id);
            if (null == chk)
            {
                // todo something
            }
            else
            {
                customerRepository.Remove(chk);
                result = true;
            }

            return result;
        }



    }
}