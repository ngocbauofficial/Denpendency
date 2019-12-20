using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopPro.Domain.Model;

namespace TopPro.Service.MA001Service
{
    public interface IMA001Service
    {
        MA001 GetById(int Id);

        List<MA001> GetAll();

        void Insert(MA001 ma001);
    }
}
