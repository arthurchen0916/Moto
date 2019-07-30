using Moto.Common.Entities;
using Moto.Common.Interfaces;
using Moto.Dal;
using System.Collections.Generic;
using System.Linq;

namespace Moto.Core
{
    public class ModelService
    {
        IRepository<Model> modelRepository;

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

        public Model Query(int cc)
        {
            var model = modelRepository.Find(x => x.cc == cc).SingleOrDefault();

            return model;
        }

        public List<Model> QueryByCC(int cc)
        {
            var model = modelRepository.Find(x => x.cc == cc).ToList();
            return model;
        }

    }
}