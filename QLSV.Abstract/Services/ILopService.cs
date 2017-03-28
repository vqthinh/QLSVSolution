using System.Collections.Generic;
using QLSV.Entities.Models;

namespace QLSV.Abstract.Services
{
    public interface ILopService : IBaseService<Lop>
    {
        IList<Lop> GetByKhoaId(int id);
    }
}
