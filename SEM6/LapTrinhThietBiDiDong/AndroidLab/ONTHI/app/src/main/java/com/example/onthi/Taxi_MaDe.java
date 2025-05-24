package com.example.onthi;

public class Taxi_MaDe {
    private int maXe;
    private String soXe;
    private double quangDuong;
    private int donGia;
    private int phamTramKM;

    public Taxi_MaDe() {
    }

    public Taxi_MaDe(int maXe, String soXe, double quangDuong, int donGia, int phamTramKM) {
        this.maXe = maXe;
        this.soXe = soXe;
        this.quangDuong = quangDuong;
        this.donGia = donGia;
        this.phamTramKM = phamTramKM;
    }

    public Taxi_MaDe(String soXe, double quangDuong, int donGia, int phamTramKM) {
        this.soXe = soXe;
        this.quangDuong = quangDuong;
        this.donGia = donGia;
        this.phamTramKM = phamTramKM;
    }

    public int getMaXe() {
        return maXe;
    }

    public void setMaXe(int maXe) {
        this.maXe = maXe;
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

    public int getDonGia() {
        return donGia;
    }

    public void setDonGia(int donGia) {
        this.donGia = donGia;
    }

    public int getPhamTramKM() {
        return phamTramKM;
    }

    public void setPhamTramKM(int phamTramKM) {
        this.phamTramKM = phamTramKM;
    }
    public double tongTien(int maXe){
        return donGia*quangDuong*(100-phamTramKM)/100;
    }
}
