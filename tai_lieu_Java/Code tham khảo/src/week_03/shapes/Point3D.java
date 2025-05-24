package week_03.shapes;

public class Point3D extends Point2D{
	// Attributes
	private double z;

	// Constructors
	public Point3D(double x, double y, double z) {
		super(x, y);
		this.z = z;
	}

	// Getters and setters
	public double getZ() {
		return z;
	}

	public void setZ(double z) {
		this.z = z;
	}

	@Override
	public String toString() {
		return "Point3D [x=" + this.getX() + ", y=" + this.getY() + ", z=" + z + "]";
	}

	@Override
	public double distance() {
		// Cách 1:
		//double res = this.getX() * this.getX() + this.getY() * this.getY() + this.z * this.z;
		
		// Cách 2:
		double res = super.distance() * super.distance() + this.z * this.z;
		return Math.sqrt(res);
	}
	
	public void move(double dx, double dy, double dz){
		super.move(dx, dy);
		this.z += dz;
	}
}
