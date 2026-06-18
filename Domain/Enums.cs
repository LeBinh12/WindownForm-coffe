namespace QuanLyQuanCafe.Domain
{
    public enum VaiTro
    {
        KhachHang = 0,
        NhanVien = 1,
        Admin = 2
    }

    public enum TrangThaiTaiKhoan
    {
        HoatDong = 0,
        BiKhoa = 1
    }

    public enum TrangThaiBan
    {
        Trong = 0,
        DangPhucVu = 1,
        ChoThanhToan = 2,
        DaThanhToan = 3
    }

    public enum TrangThaiDonHang
    {
        ChoXuLy = 0,
        DangPhucVu = 1,
        HoanThanh = 2,
        DaThanhToan = 3,
        DaHuy = 4
    }

    public enum TrangThaiThanhToan
    {
        ChuaThanhToan = 0,
        DaThanhToan = 1
    }

    public enum PhuongThucThanhToan
    {
        TienMat = 0,
        ChuyenKhoan = 1,
        ViDienTu = 2
    }

    public enum LoaiMon
    {
        CaPhe = 0,
        Tra = 1,
        Banh = 2,
        Khac = 3
    }
}
