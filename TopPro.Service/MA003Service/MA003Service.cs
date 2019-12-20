using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopPro.Domain;
using TopPro.Domain.Model;

namespace TopPro.Service.MA003Service
{
    public partial class MA003Service : IMA003Service
    {
        private IRepository<MA003> _ma003Reponsitory;
        public MA003Service(IRepository<MA003> MA003Reonsitory)
        {
            this._ma003Reponsitory = MA003Reonsitory;
        }

        public virtual MA003 GetById(int id)
        {
            if (id == 0)
                return null;

            var MA003 = _ma003Reponsitory.GetById(id);
            return MA003;
        }
        public virtual MA003 GetByMCIDCD(string mcidcd)
        {
            if (mcidcd == null)
                return null;
            var MA003 = from a in _ma003Reponsitory.Table where a.MCIDCD == mcidcd select a;
            var model = MA003.FirstOrDefault();
            return model;
        }
        public virtual void Update(MA003 MA003)
        {
            if (MA003 == null)
                throw new ArgumentNullException("MA003");
            _ma003Reponsitory.Update(MA003);
        }

        public virtual void Insert(MA003 MA003)
        {
            if (MA003 == null)
                throw new ArgumentNullException("MA003");
            _ma003Reponsitory.Insert(MA003);
        }
        public virtual void Delete(MA003 MA003)
        {
            _ma003Reponsitory.Delete(MA003);
        }
        public virtual void Delete(int id)
        {
            var MA003 = _ma003Reponsitory.GetById(id);
            _ma003Reponsitory.Delete(MA003);
        }
        public virtual void Delete(IEnumerable<MA003> listMA003)
        {
            _ma003Reponsitory.Delete(listMA003);
        }
    }
}
