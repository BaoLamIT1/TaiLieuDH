package com.example.kiemtra;

public class ThiSinh {
    private String SBD;
    private String Hoten;
    private double Toan;
    private double Ly;
    private double Hoa;

    public ThiSinh(String sbd, String hoten, double toan, double ly, double hoa){
        this.SBD = sbd;
        this.Hoa= hoa;
        this.Hoten= hoten;
        this.Ly= ly;
        this.Toan= toan;
    }

    public double getToan() {
        return Toan;
    }

    public void setToan(double toan) {
        Toan = toan;
    }

    public String getSBD() {
        return SBD;
    }

    public void setSBD(String SBD) {
        this.SBD = SBD;
    }

    public String getHoten() {
        return Hoten;
    }

    public void setHoten(String hoten) {
        Hoten = hoten;
    }

    public double getLy() {
        return Ly;
    }

    public void setLy(double ly) {
        Ly = ly;
    }

    public double getHoa() {
        return Hoa;
    }

    public void setHoa(double hoa) {
        Hoa = hoa;
    }

    public double TongDiem(){
        return Toan+ Ly+ Hoa;
    }
    public double DiemTB(){
        return (Toan+ Ly+ Hoa)/3;
    }
}
