package week_01;

import java.util.Scanner;

public class FirstApplication {

	public static final double PI = 3.14f;

	public static void main(String[] args) {
		/*
		 * Thực hiện chương trình ở đây: trong hàm main
		 */
		// 3.1: Khai báo các biến
		double r;
		double S, C;

		// 3.2: Nhập dữ liệu
		System.out.print("Nhập dữ liệu cho r:");

		Scanner sc = new Scanner(System.in);
		r = sc.nextDouble();

		// 3.3: Algorithms
		if (r < 0.0) {
			System.out.println("Dữ liệu không hợp lệ");
		} else {
			C = PI * r * 2.0;
			S = PI * r * r;

			// 3.4: Output
			System.out.println("Chu vi là: " + C);
			System.out.println("Diện tích là: " + S);
		}

		// 3.5: Đóng các đối tượng
		sc.close();
	}

}
