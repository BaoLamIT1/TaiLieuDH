package week_04.shapes;

public class Circle implements ShapesG, ShapesT {
	// Attributes
	private double x;
	private double y;
	private double r;

	public Circle(double x, double y, double r) {
		super();
		this.x = x;
		this.y = y;
		this.r = r;
	}

	public double getX() {
		return x;
	}

	public void setX(double x) {
		this.x = x;
	}

	public double getY() {
		return y;
	}

	public void setY(double y) {
		this.y = y;
	}

	public double getR() {
		return r;
	}

	public void setR(double r) {
		this.r = r;
	}

	@Override
	public String toString() {
		return "Circle [x=" + x + ", y=" + y + ", r=" + r + "]";
	}

	// Methods - bộ khung của đối tượng - hình học
	// 1. Tính diện tích của hình tròn.
	// 2. Tính chu vi của hình tròn.
	
	@Override
	public double area() {
		return this.r * this.r * Math.PI;
	}

	@Override
	public double perimeters() {
		return 2.0 * this.r * Math.PI;
	}

	// Methods - bộ khung của đối tượng - biến đổi hình học
	@Override
	public void move(double dx, double dy) {
		this.x += dx;
		this.y += dy;
	}

	@Override
	public void rotate(double alpha) {
		// N.A: hình tròn, khi xoay không thay đổi.
	}

	@Override
	public void zoom(double ratio) {
		this.r *= ratio;
	}
}
