package week_04.execices;

public class Plane extends Line {
	// Attributes
	private double c;

	public Plane(double a, double b, double c) {
		super(a, b);
		this.c = c;
	}

	public double getC() {
		return c;
	}

	public void setC(double c) {
		this.c = c;
	}

	@Override
	public String toString() {
		return "Plane [z = " + this.getA() + "x + " + this.getB() + "y + " + this.c + "]";
	}

	// Overload
	public boolean checkPoint(double xa, double ya, double za) {
		if (za == this.getA() * xa + this.getB() * ya + this.c) {
			return true;
		}
		return false;
	}

	@Override
	public double distance() {
		double value = this.getA() * this.getA() + this.getB() * this.getB() + 1.0;
		value = Math.abs(c) / Math.sqrt(value);
		return value;
	}

	// Overload
	public double distance(double xa, double ya, double za) {
		double t = this.getA() * xa + this.getB() * ya - za + this.c;
		double m = this.getA() * this.getA() + this.getB() * this.getB() + 1.0;
		return Math.abs(t) / Math.sqrt(m);
	}

}
