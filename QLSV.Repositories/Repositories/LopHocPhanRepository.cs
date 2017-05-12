using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using QLSV.Abstract.Repositories;
using QLSV.Entities.Models;

namespace QLSV.Repositories.Repositories
{
    public class LopHocPhanRepository : BaseRepository<LopHocPhan>,ILopHocPhanRepository
    {
        private readonly QlsvDbContext _context;
        public LopHocPhanRepository(QlsvDbContext context) : base(context)
        {
            _context = context;
        }

        public IList<MonHoc> GetMonHocs()
        {
            return _context.Set<MonHoc>().Where(x=>x.Deleted==false).ToList();
        }

        public bool AddMonHoc(MonHoc monHoc)
        {
            try
            {
                monHoc.Deleted = false;
                _context.Set<MonHoc>().Add(monHoc);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IList<KyHocNamHoc> GetHocKies()
        {
            return _context.Set<KyHocNamHoc>().Where(x => x.Deleted == false).ToList();
        }

        public IList<LopHocPhanSinhVien> GetDanhSachSinhVien(int id)
        {
            return
                _context.Set<LopHocPhanSinhVien>()
                    .Where(x => x.LopHocPhanId == id && x.Deleted.Value == false)
                    .ToList();
        }

        public IList<SinhVien> GetSinhVienToAdd(int id)
        {
            var listHpSv = _context.Set<LopHocPhanSinhVien>()
                    .Where(x => x.LopHocPhanId == id && x.Deleted.Value == false)
                    .ToList();
            var listSv = from sv in _context.Set<SinhVien>().ToList()
                where listHpSv.All(x => x.SinhVienId != sv.Id)
                select sv;
            return listSv.ToList();
        }

        public bool AddSvToLopHp(int id, int sinhVienId)
        {
            try
            {
                _context.Set<LopHocPhanSinhVien>().Add(new LopHocPhanSinhVien
                {
                    LopHocPhanId = id,
                    SinhVienId = sinhVienId,
                    DaNop = false,
                    Deleted = false,
                    DiemCc = 0,
                    DiemCk1 = 0,
                    DiemCk2 = 0,
                    DiemDk = 0,
                    DiemTx = 0
                });
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateMonHoc(MonHoc monHoc)
        {
            try
            {
                if (_context.Entry(monHoc).State == EntityState.Detached)
                {
                    _context.Set<MonHoc>().Attach(monHoc);
                }
                _context.Entry(monHoc).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public MonHoc GetMonHocById(int id)
        {
            return _context.Set<MonHoc>().FirstOrDefault(x => x.Id == id);
        }

        public bool DeleteMonHoc(int id)
        {
            try
            {
                var entity = GetMonHocById(id);
                entity.Deleted = true;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
