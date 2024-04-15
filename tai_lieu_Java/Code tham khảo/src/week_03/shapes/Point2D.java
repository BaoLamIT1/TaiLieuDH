package week_03.shapes;

public class Point2D {
	// Attributes
	private double x;
	private double y;

	// Constructors
	public Point2D(double x, double y) {
		this.x = x;
		this.y = y;
	}

	public Point2D() {
		this.x = 0;
		this.y = 0;
	}
	
	// Getters and setters
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

	// toString
	@Override
	public String toString() {
		return "Point2D [x=" + x + ", y=" + y + "]";
	}
	
	public double distance(){
		return Math.sqrt(this.x * this.x + this.y * this.y);
	}
	
	public void move(double dx, double dy){
		this.x += dx;
		this.y += dy;
	}
	
	public double area(){
		return 0.0;
	}
}
