using Moto.Common.Entities;
using Moto.Common.Interfaces;
using Moto.Common.Models;
using Moto.Dal;
using System.Collections.Generic;
using System.Linq;

namespace Moto.Core
{
    public class TransactionService
    {
        ITransactionRepository transactionRepository;

        public TransactionService()
        {
            transactionRepository = new TransactionRepository();
        }
        //Read
        public IEnumerable<Transaction> GetAll()
        {
            var result = transactionRepository.FindAll();
            return result;
        }


        public IEnumerable<Transaction> Query(TransactionRecord p)
        {

            string sql = "select * from dbo.TransactionRecord where 1=1 ";


            //if(m.Brand_code != "") { sql += "and brand_code =" + m.Brand_code; }
            //if (m.Year != "") { sql += " and year =" + m.Year; }
            //if (m.cc_s != "") { sql += " and cc >=" + m.cc_s; }
            //if (m.cc_e != "") { sql += " and cc <=" + m.cc_e; }

            // if (!string.IsNullOrEmpty((p.Date).ToString())) {  sql += " and Date  ="+"'"+(p.Date).ToString("yyyy-MM-dd")+"'"; }
            if (!string.IsNullOrEmpty(p.Name)) { sql += " and Name =" + "'" + p.Name + "'"; }
            if (!string.IsNullOrEmpty((p.Amount).ToString())) { sql += $" and Amount ={p.Amount}"; }
            if (!string.IsNullOrEmpty(p.Detail)) { sql += " and Detail =" + "'" + p.Detail + "'"; }
            if (!string.IsNullOrEmpty(p.Memo)) { sql += " and Memo =" +"'"+ p.Memo+"'"; }
            if (!string.Equals((p.Date).ToString(), "0001 / 1 / 1 上午 12:00:00")) { sql += " and Date  =" + "'" + (p.Date).ToString("yyyy-MM-dd") + "'"; }


            string sql2 = "select count(*) from dbo.Transaction where 1=1";

            var result = transactionRepository.QueryTransactionBySql(sql,sql2);

            return result;
        }

        

    public bool Add(Transaction model)
        {
            bool result = false;
            var chk = transactionRepository.GetById(model.id);
            if (null == chk)
            {
                transactionRepository.Add(model);
                result = true;
            }
            else
            {
                // todo something
            }

            return result;
        }

        public bool Update(Transaction model)
        {
            bool result = false;
            var chk = transactionRepository.GetById(model.id);
            if (null == chk)
            {
                // todo something
            }
            else
            {
                transactionRepository.Update(model);
                result = true;
            }

            return result;
        }

        public bool Remove(int id)
        {
            bool result = false;
            var chk = transactionRepository.GetById(id);
            if (null == chk)
            {
                // todo something
            }
            else
            {
                transactionRepository.Remove(chk);
                result = true;
            }

            return result;
        }


    }
}