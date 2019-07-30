using Moto. Common.Entities;
using Moto.Common.Interfaces;
using Moto.Dal;
using System.Collections.Generic;
using System.Linq;

namespace Moto.Core
{
    public class BrandService
    {
        IRepository<Brand> brandRepository;

        public BrandService()
        {
            brandRepository = new BrandRepository();
        }
        //Read
        public IEnumerable<Brand> GetAll()
        {
            var result = brandRepository.FindAll();
            return result;
        }

        public bool Add(Brand brand)
        {
            bool result = false;
            var chk = brandRepository.GetById(brand.id);
            if (null == chk)
            {
                brandRepository.Add(brand);
                result = true;
            }
            else
            {
                // todo something
            }

            return result;
        }

        public bool Update(Brand brand)
        {
            bool result = false;
            var chk = brandRepository.GetById(brand.id);
            if (null == chk)
            {
                // todo something
            }
            else
            {
                brandRepository.Update(brand);
                result = true;
            }

            return result;
        }

        public bool Remove(int id)
        {
            bool result = false;
            var chk = brandRepository.GetById(id);
            if (null == chk)
            {
                // todo something
            }
            else
            {
                brandRepository.Remove(chk);
                result = true;
            }

            return result;
        }

         


    }
}