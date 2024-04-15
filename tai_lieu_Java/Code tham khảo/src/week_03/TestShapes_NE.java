package week_03;

import week_03.shapes.Point2D;
import week_03.shapes.Point3D_NE;

public class TestShapes_NE {

	public static void main(String[] args) {
		Point2D p1 = new Point2D(1, 1);
		Point2D p2 = new Point2D(10, -5);
		Point2D p3 = new Point2D(-2, 7);

		Point3D_NE p31 = new Point3D_NE(1, 2, 1);
		Point3D_NE p32 = new Point3D_NE(1, 5, 2);
		
		Point2D[] lpoints = { p1, p2, p3 };
		Point3D_NE[] lpoint3Ds = {p31, p32};

		// 1. Vẽ các điểm lên màn hình
		for (Point2D point2d : lpoints) {
			System.out.println(point2d.toString());
		}
		for (Point3D_NE point3d : lpoint3Ds) {
			System.out.println(point3d.toString());
		}
		
		// 2. Tính tổng khoảng cách đến các điểm
		double sdis = 0.0;
		for (Point2D point2d : lpoints) {
			sdis += point2d.distance();
		}
		System.out.println("Sum of distances: " + sdis);
		
		// 3. Tịnh tiến toàn bộ các điểm
		for (Point2D point2d : lpoints) {
			point2d.move(10.0, 5.0);
		}
		for (Point2D point2d : lpoints) {
			System.out.println(point2d.toString());
		}
	}

}
