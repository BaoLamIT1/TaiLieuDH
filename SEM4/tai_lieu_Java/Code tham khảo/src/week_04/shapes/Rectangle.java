package week_04.shapes;

public class Rectangle implements ShapesG, ShapesT {
	// Attributes
	private double x1;
	private double y1;
	private double x2;
	private double y2;

	public Rectangle(double x1, double y1, double x2, double y2) {
		super();
		this.x1 = x1;
		this.y1 = y1;
		this.x2 = x2;
		this.y2 = y2;
	}

	public double getX1() {
		return x1;
	}

	public void setX1(double x1) {
		this.x1 = x1;
	}

	public double getY1() {
		return y1;
	}

	public void setY1(double y1) {
		this.y1 = y1;
	}

	public double getX2() {
		return x2;
	}

	public void setX2(double x2) {
		this.x2 = x2;
	}

	public double getY2() {
		return y2;
	}

	public void setY2(double y2) {
		this.y2 = y2;
	}

	@Override
	public String toString() {
		return "Rectangle [x1=" + x1 + ", y1=" + y1 + ", x2=" + x2 + ", y2=" + y2 + "]";
	}

	// Methods - bộ khung của đối tượng - hình học.
	// 1. Tính diện tích của hình chữ nhật.
	// 2. Tính chu vi của hình chữ nhật.
	@Override
	public double area() {
		double dx = Math.abs(this.x1 - this.x2);
		double dy = Math.abs(this.y1 - this.y2);
		return dx * dy;
	}

	@Override
	public double perimeters() {
		double dx = Math.abs(this.x1 - this.x2);
		double dy = Math.abs(this.y1 - this.y2);
		return 2.0 * (dx + dy);
	}
	
	// Methods - bộ khung của đối tượng - biến đổi hình học
	@Override
	public void move(double dx, double dy) {
		this.x1 += dx;
		this.y1 += dy;
		this.x2 += dx;
		this.y2 += dy;
	}

	@Override
	public void rotate(double alpha) {
		// TODO Cài đặt sau - khi xây dựng được công thức biến đổi.
	}

	@Override
	public void zoom(double ratio) {
		// TODO Cài đặt sau - khi xây dựng được công thức biến đổi.
	}
}
