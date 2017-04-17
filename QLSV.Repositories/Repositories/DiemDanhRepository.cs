using System.Collections.Generic;
using QLSV.Abstract.Repositories;
using QLSV.Entities.Models;

namespace QLSV.Repositories.Repositories
{
    public class DiemDanhRepository : BaseRepository<DiemDanh>, IDiemDanhRepository
    {
        public DiemDanhRepository(QlsvDbContext context) : base(context)
        {
        }
    }
}
