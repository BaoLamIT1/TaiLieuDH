package week_04.execices;

public class Line {
	// Attributes
	private double a;
	private double b;

	public Line(double a, double b) {
		super();
		this.a = a;
		this.b = b;
	}

	public double getA() {
		return a;
	}

	public void setA(double a) {
		this.a = a;
	}

	public double getB() {
		return b;
	}

	public void setB(double b) {
		this.b = b;
	}

	@Override
	public String toString() {
		if (b<0.0){
			return "Line [y = " + a + "x - " + Math.abs(b)+ "]";
		}
		if (b==0.0){
			return "Line [y = " + a + "x]";
		}
		return "Line [y = " + a + "x + " + b + "]";
	}

	// Methods
	public boolean checkPoint(double xa, double ya){
		if (ya == this.a * xa + this.b){
			return true;
		}
		return false;
	}
	
	public double distance(){
		double value = Math.abs(b) / Math.sqrt(this.a * this.a + 1.0);
		return value;
	}
	
	public double distance(double xa, double ya){
		double d = 0.0;
		d = Math.abs(this.a * xa - ya + this.b);
		d = d / Math.sqrt(this.a * this.a + 1.0);
		return d;
	}
}
