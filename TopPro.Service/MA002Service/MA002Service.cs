using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopPro.Domain;
using TopPro.Domain.Model;

namespace TopPro.Service.MA002Service
{
    public partial class MA002Service : IMA002Service
    {
        private IRepository<MA002> _ma002Reponsitory;
        public MA002Service(IRepository<MA002> ma002Reonsitory)
        {
            this._ma002Reponsitory = ma002Reonsitory;
        }

        public virtual MA002 GetById(int id)
        {
            if (id == 0)
                return null;

            var ma002 = _ma002Reponsitory.GetById(id);
            return ma002;
        }
        public virtual IPagedList<MA002> GetAll(int pageIndex = 0, int pageSize = int.MaxValue)
        {
            var query = from a in _ma002Reponsitory.Table orderby a.MBUPDT, a.MBUPDTM descending select a ;
            var ma002 = new PagedList<MA002>(query, pageIndex, pageSize);
            return ma002;
        }
        public virtual MA002 GetByMBUSRCD(string mbusrcd)
        {
            if (mbusrcd == null)
                return null;
            var ma002 = from a in _ma002Reponsitory.Table where a.MBUSRCD == mbusrcd select a;
            var model = ma002.FirstOrDefault();
            return model;
        }
        public virtual void Update(MA002 ma002)
        {
            if (ma002 == null)
                throw new ArgumentNullException("MA002");
            _ma002Reponsitory.Update(ma002);
        }

        public virtual void Insert(MA002 ma002)
        {
            if (ma002 == null)
                throw new ArgumentNullException("MA002");
            _ma002Reponsitory.Insert(ma002);
        }
        public virtual void Delete(MA002 ma002)
        {
            _ma002Reponsitory.Delete(ma002);
        }
        public virtual void Delete(int id)
        {
            var ma002 = _ma002Reponsitory.GetById(id);
            _ma002Reponsitory.Delete(ma002);
        }
        public virtual void Delete(IEnumerable<MA002> listMA002)
        {
            _ma002Reponsitory.Delete(listMA002);
        }
    }
}
