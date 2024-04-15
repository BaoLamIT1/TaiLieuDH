package week_03;

import week_03.shapes.Point2D;
import week_03.shapes.Point3D;

public class TestShapes {

	public static void main(String[] args) {
		Point2D p1 = new Point2D(1, 1);
		Point2D p2 = new Point2D(10, -5);
		Point2D p3 = new Point2D(-2, 7);
		Point3D p31 = new Point3D(-1, 2, 5);
		Point3D p32 = new Point3D(10, -4, 8);
		
		Point2D[] lpoints = { p1, p2, p3, p31, p32 };
		//Point2D[] lpoints = { p1, p2, p3 };

		// 1. Vẽ các điểm lên màn hình
		for (Point2D point2d : lpoints) {
			System.out.println(point2d.toString());
		}
		
		// 2. Tính tổng khoảng cách đến các điểm
		double sdis = 0.0;
		for (Point2D point2d : lpoints) {
			sdis += point2d.distance();
		}
		System.out.println("Sum of distances: " + sdis);
		
		// 3. Tịnh tiến toàn bộ các điểm
		for (Point2D point2d : lpoints) {
			if (point2d instanceof Point3D){
				((Point3D) point2d).move(10.0, 5.0, 1.0);
			}else{
				point2d.move(10.0, 5.0);
			}
		}
		for (Point2D point2d : lpoints) {
			System.out.println(point2d.toString());
		}
	}

}
