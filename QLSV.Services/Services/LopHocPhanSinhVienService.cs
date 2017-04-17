using System;
using System.Linq;
using QLSV.Abstract.Repositories;
using QLSV.Abstract.Services;
using QLSV.Common;
using QLSV.Entities.Models;
using QLSV.Repositories.Repositories;

namespace QLSV.Services.Services
{
    public class LopHocPhanSinhVienService : BaseService<LopHocPhanSinhVien>, ILopHocPhanSinhVienService
    {
        private readonly IDiemDanhRepository _diemDanhRepository;

        public LopHocPhanSinhVienService()
        {
            _diemDanhRepository = UnitOfWork.Repository<DiemDanh>() as IDiemDanhRepository;
        }

        public void XetDiemChuyenCan(int id)
        {
            var listSvLopHp = Where(x => x.LopHocPhanId == id);
            foreach (var item in listSvLopHp)
            {
                var listDiemDanh = _diemDanhRepository.Where(x => x.SinhVienId == item.SinhVienId
                                                                  && x.LopHocPhanId == id).ToList();
                var soBuoiCoMat = listDiemDanh.Count(x => x.CoMat);
                var diemCc = soBuoiCoMat / (decimal)listDiemDanh.Count;
                item.DiemCc = Math.Round(diemCc*10, 1);
                Update(item);
            }
            UnitOfWork.SaveChanges();
        }

        public void XepLoai(int id)
        {
            var listSvLopHp = Where(x => x.LopHocPhanId == id);
            foreach (var item in listSvLopHp)
            {
                var diemTb = item.DiemGk * (decimal) 0.4 + ((item.DiemCk1 + item.DiemCk2) / 2) * (decimal) 0.6;
                item.DiemTb = diemTb;
                item.XepLoai = Utility.XepLoai(diemTb.GetValueOrDefault());
                Update(item);
            }
            UnitOfWork.SaveChanges();
        }
    }
}
