namespace QLSV.Common
{
    public static class Utility
    {
        public static string XepLoai(decimal diem)
        {
            if ((double) diem >= 8.5) return "A";
            if ((double) diem >= 7 && (double) diem < 8.5) return "B";
            if ((double) diem >= 5.5 && (double) diem < 7) return "C";
            if ((double) diem >= 4 && (double) diem < 5.5) return "D";
            return "F";
        }
    }
}
