using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopPro.Domain;
using TopPro.Domain.Model;

namespace TopPro.Service.MA001Service
{
   public class MA001Service : IMA001Service
    {
        private IRepository<MA001> _ma001Repository;
        public MA001Service(IRepository<MA001> ma001Repository)
        {
            this._ma001Repository = ma001Repository;
        }
        public MA001 GetById(int id)
        {
            if (id == 0)
                return null;
            return _ma001Repository.GetById(id);
        }
        public List<MA001> GetAll()
        {
            return _ma001Repository.GetAll().ToList();
        }

       public virtual void Insert(MA001 ma001)
        {
            _ma001Repository.Insert(ma001);

        }

    }
}
