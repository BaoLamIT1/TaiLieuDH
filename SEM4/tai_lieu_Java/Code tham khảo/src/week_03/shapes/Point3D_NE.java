package week_03.shapes;

// Lớp Point3D không kế thừa => duplicated code.

public class Point3D_NE {
	// Attributes
	private double x;
	private double y;
	// 1. duplicated: x/y
	private double z;

	// Constructors
	public Point3D_NE(double x, double y, double z) {
		super();
		this.x = x;
		this.y = y;
		// 2. các tính toán x, y bị duplicated
		this.z = z;
	}

	public Point3D_NE() {
		this.x = 0;
		this.y = 0;
		// 2. các tính toán x, y bị duplicated
		this.z = 0;
	}

	// Getters and setters
	// 3. các hàm get/set của x, y là duplicated
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

	public double getZ() {
		return z;
	}

	public void setZ(double z) {
		this.z = z;
	}

	// toString
	@Override
	public String toString() {
		return "Point3D_NE [x=" + x + ", y=" + y + ", z=" + z + "]";
	}
	
	public double distance(){
		return Math.sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
	}
	
	public void move(double dx, double dy, double dz){
		this.x += dx;
		this.y += dy;
		// 2. các tính toán x, y bị duplicated
		this.z += dz;
	}
	
	// duplicated
	public double area(){
		return 0.0;
	}

}
