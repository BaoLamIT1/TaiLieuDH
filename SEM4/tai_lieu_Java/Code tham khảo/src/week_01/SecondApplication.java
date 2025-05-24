package week_01;

public class SecondApplication {

	public static void main(String[] args) {
		/*
		 * Thực hiện chương trình ở đây: trong hàm main
		 */
		// 3.1: Khai báo các biến
		int n = 5;
		double S = 0.0;
		
		for (int i=1; i<=n; i++){
			S = S + 1.0/i;
		}
		
		System.out.println("Giá trị tổng S = " + S);
	}

}
