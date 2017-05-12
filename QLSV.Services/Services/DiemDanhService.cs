using System.Collections.Generic;
using System.Linq;
using QLSV.Abstract.Repositories;
using QLSV.Abstract.Services;
using QLSV.Entities.Models;

namespace QLSV.Services.Services
{

    public class DiemDanhService : BaseService<DiemDanh>, IDiemDanhService
    {
        private readonly ILopHocPhanSinhVienRepository _lopHocPhanSinhVienRepository;
        private readonly IDiemDanhRepository _diemDanhRepository;

        public DiemDanhService()
        {
            _lopHocPhanSinhVienRepository = UnitOfWork.Repository<LopHocPhanSinhVien>() as ILopHocPhanSinhVienRepository;
            _diemDanhRepository = UnitOfWork.Repository<DiemDanh>() as IDiemDanhRepository;
        }

        public IList<KetQuaDiemDanh> GetKetQuaDiemDanhs(int sinhVienId, int? hocKyId)
        {
            var listKetQua = new List<KetQuaDiemDanh>();
            var listLopHp = _lopHocPhanSinhVienRepository.Where(x => x.SinhVienId == sinhVienId).ToList();
            foreach (var lopHp in listLopHp)
            {
                var ketqua = new KetQuaDiemDanh
                {
                    SoBuoiDiemDanh =
                         _diemDanhRepository.GetListDiemDanh(lopHp.LopHocPhanId, sinhVienId,null).Count,
                    SoBuoiVang =
                        _diemDanhRepository.GetListDiemDanh(lopHp.LopHocPhanId, sinhVienId, false).Count,
                    LopHocPhanSinhVien = lopHp,
                };
                ketqua.TiLeVang = System.Math.Round((double) ketqua.SoBuoiVang / ketqua.SoBuoiDiemDanh,2);
                listKetQua.Add(ketqua);
            }
            return listKetQua;
        }
    }
}
