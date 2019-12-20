using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopPro.Domain;
using TopPro.Domain.Model;

namespace TopPro.Service.MA002Service
{
    public interface IMA002Service
    {
        MA002 GetById(int Id);

        IPagedList<MA002> GetAll(int pageIndex = 0, int pageSize = int.MaxValue);

        MA002 GetByMBUSRCD(string MBUSRCD);

        void Update(MA002 ma002);

        void Insert(MA002 ma002);

        void Delete(MA002 ma002);

        void Delete(int id);

        void Delete(IEnumerable<MA002> listma002);

    }
}
