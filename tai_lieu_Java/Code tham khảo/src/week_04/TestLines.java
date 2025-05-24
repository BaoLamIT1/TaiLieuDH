package week_04;

import java.util.ArrayList;
import java.util.List;

import week_04.execices.Line;
import week_04.execices.Plane;

public class TestLines {

	public static void main(String[] args) {
		Line l1 = new Line(1.0, -2.0);
		Line l2 = new Line(-5.0, 12.0);
		Line l3 = new Line(3.0, 4.0);

		List<Line> myShapes = new ArrayList<Line>();
		myShapes.add(l1);
		myShapes.add(l2);
		myShapes.add(l3);

		// Version 2.0
		Plane p1 = new Plane(1.0, -2.0, 3.0);
		Plane p2 = new Plane(-5.0, 12.0, 1.0);
		myShapes.add(p1);
		myShapes.add(p2);

		// Business - 1
		double S = 0.0;
		for (Line line : myShapes) {
			S += line.distance();
		}
		System.out.println("S = " + S);

		// Business - 2
		// i.e. xa = 1.0; ya = 1.0; za = 1.0
		int count = 0;
		for (Line line : myShapes) {
			if (line instanceof Plane){
				if (((Plane)line).checkPoint(1.0, 1.0, 1.0)){
					count++;
				}
			}else{
				if (line.checkPoint(1.0, 1.0)) {
					count++;
				}
			}
		}
		System.out.println("Count = " + count);

		// Show
		for (Line line : myShapes) {
			System.out.println(line);
		}

		// Business - 3
		S = 0.0;
		for (Line line : myShapes) {
			// Tính khoảng cách từ A(xa, ya) đến đường thẳng
			// i.e xa = 2.0; ya = 3.0; za = 1.0
			if (line instanceof Plane){
				S += ((Plane)line).distance(2.0, 3.0, 1.0);
			}else{
				S += line.distance(2.0, 3.0);
			}
		}
		System.out.println("S = " + S);

	}

}
