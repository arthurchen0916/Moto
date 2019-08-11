using Moto.Common.Entities;
using Moto.Common.Interfaces;
using Moto.Common.Models;
using Moto.Dal;
using System.Collections.Generic;
using System.Linq;

namespace Moto.Core
{
    public class ModelService
    {
        IModelRepository modelRepository;

        public ModelService()
        {
            modelRepository = new ModelRepository();
        }
        //Read
        public IEnumerable<Model> GetAll()
        {
            var result = modelRepository.FindAll();
            return result;
        }

        //GetYear
        public IEnumerable<int> GetYear()
        {
            var year =modelRepository.QueryYearBySql("select distinct year from model");
            return year;
        }

 
        public IEnumerable<Model> Query(MotoSearch m)
        {
            string sql = "select * from dbo.Model where 1=1 ";
            

            //if(m.Brand_code != "") { sql += "and brand_code =" + m.Brand_code; }
            //if (m.Year != "") { sql += " and year =" + m.Year; }
            //if (m.cc_s != "") { sql += " and cc >=" + m.cc_s; }
            //if (m.cc_e != "") { sql += " and cc <=" + m.cc_e; }
            if (!string.IsNullOrEmpty(m.Brand_code)) { sql += $" and brand_code ='{m.Brand_code}'"; }
            if (!string.IsNullOrEmpty(m.Year)) { sql += $" and year ={m.Year}"; }
            if (!string.IsNullOrEmpty(m.cc_s)) { sql += " and cc >=" + m.cc_s; }
            if (!string.IsNullOrEmpty(m.cc_e)) { sql += " and cc <=" + m.cc_e; }
            if (!string.IsNullOrEmpty(m.Factory_price)) { sql += " and Factory_price >=" + m.Factory_price; }
            if (!string.IsNullOrEmpty(m.Factory_price2)) { sql += " and Factory_price <=" + m.Factory_price2; }
            if (!string.IsNullOrEmpty(m.ABS)) { sql += " and ABS =" + m.ABS; }

            string sql2 = "select count(*) from dbo.Model where 1=1";

            var result = modelRepository.QueryModelBySql(sql,sql2);
            
            return result;
        }

        public List<Model> QueryByCC(int cc)
        {
            var model = modelRepository.Find(x => x.cc == cc).ToList();
            return model;
        }

        public bool Add(Model model)
        {
            bool result = false;
            var chk = modelRepository.GetById(model.id);
            if (null == chk)
            {
                modelRepository.Add(model);
                result = true;
            }
            else
            {
                // todo something
            }

            return result;
        }

        public bool Update(Model model)
        {
            bool result = false;
            var chk = modelRepository.GetById(model.id);
            if (null == chk)
            {
                // todo something
            }
            else
            {
                modelRepository.Update(model);
                result = true;
            }

            return result;
        }

        public bool Remove(int id)
        {
            bool result = false;
            var chk = modelRepository.GetById(id);
            if (null == chk)
            {
                // todo something
            }
            else
            {
                modelRepository.Remove(chk);
                result = true;
            }

            return result;
        }


        
    }
}