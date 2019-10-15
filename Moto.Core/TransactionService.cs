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


        public IEnumerable<Transaction> Query(TransactionRecord p,string btn,string sql)
        {
            if (btn.Equals("Query"))
            {
                sql = "select * from dbo.TransactionRecord where 1=1 ";

                if (!string.IsNullOrEmpty(p.Name)) { sql += " and Name =" + "'" + p.Name + "'"; }
                if (!string.IsNullOrEmpty((p.Amount).ToString())) { sql += $" and Amount ={p.Amount}"; }
                if (!string.IsNullOrEmpty(p.Detail)) { sql += " and Detail =" + "'" + p.Detail + "'"; }
                if (!string.IsNullOrEmpty(p.Memo)) { sql += " and Memo =" + "'" + p.Memo + "'"; }
                if (!string.Equals((p.Date).ToString(), "0001 / 1 / 1 上午 12:00:00")) { sql += " and Date  =" + "'" + (p.Date).ToString("yyyy-MM-dd") + "'"; }
            }

            else if (btn.Equals("Create"))
            {
                sql= sql = "insert into TransactionRecord (Name,Date,Amount,Detail,Memo,Update_Date)Values(" + "'" + p.Name + "'" + "," + "'" +(p.Date).ToString("yyyy-MM-dd") + "'" + "," + "'" +p.Amount + "'" + "," + "'" +p.Detail + "'" + "," + "'" +p.Memo + "'" +","+"GETDATE()) ";
            }



            var result = transactionRepository.QueryTransactionBySql(sql);

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