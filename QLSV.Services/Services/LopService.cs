using System.Collections.Generic;
using QLSV.Abstract.Repositories;
using QLSV.Abstract.Services;
using QLSV.Entities.Models;

namespace QLSV.Services.Services
{
    public class LopService : BaseService<Lop>,ILopService
    {
        private readonly ILopRepository _lopRepository;

        public LopService()
        {
            _lopRepository = UnitOfWork.Repository<Lop>() as ILopRepository;
        }

        public IList<Lop> GetByKhoaId(int id)
        {
            return _lopRepository.GetByKhoaId(id);
        }
    }
}
