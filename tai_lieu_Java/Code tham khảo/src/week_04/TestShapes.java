package week_04;

import java.util.ArrayList;
import java.util.List;

import week_04.shapes.Circle;
import week_04.shapes.Rectangle;
import week_04.shapes.ShapesG;
import week_04.shapes.ShapesT;

public class TestShapes {

	public static void main(String[] args) {
		List<ShapesG> myShapes = new ArrayList<ShapesG>();
		// Người dùng lựa chọn hình ảnh mong muốn.
		Circle c1 = new Circle(1.0, 1.0, 2.0);
		myShapes.add(c1);
		Circle c2 = new Circle(2.0, 5.0, 3.0);
		myShapes.add(c2);

		// Người dùng lựa chọn hình ảnh mong muốn: rectangle
		Rectangle r1 = new Rectangle(1.0, 1.0, 2.0, 2.0);
		myShapes.add(r1);
		Rectangle r2 = new Rectangle(2.0, 5.0, 3.0, 8.0);
		myShapes.add(r2);
		
		for (ShapesG shapes : myShapes) {
			System.out.println(shapes);
		}

		// Thực hiện các nghiệp vụ
		double S = 0.0;
		double C = 0.0;
		for (ShapesG shapes : myShapes) {
			S += shapes.area();
			C += shapes.perimeters();
		}
		System.out.println("Area: " + S);
		System.out.println("Perimeter: " + C);
		
		// Thực hiện các nghiệp vụ với biến đổi hình học
		for (ShapesG shapes : myShapes) {
			if (shapes instanceof ShapesT){
				((ShapesT)shapes).move(5.0, 3.0);
			}
		}
		
		for (ShapesG shapes : myShapes) {
			System.out.println(shapes);
		}
	}

}
