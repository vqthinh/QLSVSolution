using System.Collections;
using System.Collections.Generic;
using QLSV.Entities.Models;

namespace QLSV.Abstract.Repositories
{
    public interface ILopRepository : IBaseRepository<Lop>
    {
        IList<Lop> GetByKhoaId(int id);
    }
}
