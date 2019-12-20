using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopPro.Domain.Model;

namespace TopPro.Service.MA003Service
{
   public partial interface IMA003Service
    {
        MA003 GetById(int Id);

        MA003 GetByMCIDCD(string mcidcd);

        void Update(MA003 MA003);

        void Insert(MA003 MA003);

        void Delete(MA003 MA003);

        void Delete(int id);

        void Delete(IEnumerable<MA003> listMA003);
    }
}
