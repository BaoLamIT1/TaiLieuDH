package com.example.giaodich;

public class GiaoDich {
    private int maGiaoDich;
    private String noiDung;
    private String ngayThang;
    private boolean loaiGiaoDich; // true nếu là tiền đến, false nếu là tiền đi
    private String tenNguoi;
    private double soTien;

    public GiaoDich(int maGiaoDich, String noiDung, String ngayThang, boolean loaiGiaoDich, String tenNguoi, double soTien) {
        this.maGiaoDich = maGiaoDich;
        this.noiDung = noiDung;
        this.ngayThang = ngayThang;
        this.loaiGiaoDich = loaiGiaoDich;
        this.tenNguoi = tenNguoi;
        this.soTien = soTien;
    }


    public int getMaGiaoDich() {
        return maGiaoDich;
    }

    public void setMaGiaoDich(int maGiaoDich) {
        this.maGiaoDich = maGiaoDich;
    }

    public String getNoiDung() {
        return noiDung;
    }

    public void setNoiDung(String noiDung) {
        this.noiDung = noiDung;
    }

    public String getNgayThang() {
        return ngayThang;
    }

    public void setNgayThang(String ngayThang) {
        this.ngayThang = ngayThang;
    }

    public boolean isLoaiGiaoDich() {
        return loaiGiaoDich;
    }

    public void setLoaiGiaoDich(boolean loaiGiaoDich) {
        this.loaiGiaoDich = loaiGiaoDich;
    }

    public String getTenNguoi() {
        return tenNguoi;
    }

    public void setTenNguoi(String tenNguoi) {
        this.tenNguoi = tenNguoi;
    }

    public double getSoTien() {
        return soTien;
    }

    public void setSoTien(double soTien) {
        this.soTien = soTien;
    }
}
