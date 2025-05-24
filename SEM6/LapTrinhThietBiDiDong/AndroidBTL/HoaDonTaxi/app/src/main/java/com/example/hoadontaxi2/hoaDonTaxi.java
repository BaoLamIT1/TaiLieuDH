package com.example.hoadontaxi2;

public class hoaDonTaxi {
    private int ma;
    private String soXe;
    private double quangDuong;
    private double donGia;
    private int khuyenMai;

    public hoaDonTaxi(int ma, String soXe, double quangDuong, double donGia, int khuyenMai)
    {
        this.ma=ma;
        this.soXe = soXe;
        this.quangDuong = quangDuong;
        this.donGia = donGia;
        this.khuyenMai = khuyenMai;
    }

    public int getMa() {
        return ma;
    }

    public void setMa(int ma) {
        this.ma = ma;
    }

    public String getSoXe() {
        return soXe;
    }

    public void setSoXe(String soXe) {
        this.soXe = soXe;
    }

    public double getQuangDuong() {
        return quangDuong;
    }

    public void setQuangDuong(double quangDuong) {
        this.quangDuong = quangDuong;
    }

    public double getDonGia() {
        return donGia;
    }

    public void setDonGia(double donGia) {
        this.donGia = donGia;
    }

    public int getKhuyenMai() {
        return khuyenMai;
    }

    public void setKhuyenMai(int khuyenMai) {
        this.khuyenMai = khuyenMai;
    }
    public double getTongTien() {
        return donGia * quangDuong * (100 - khuyenMai) / 100;
    }

}
