package week_02;

public class Fibonaccy {

	public static void main(String[] args) {
		int n = 15;
		// Cau 1
		System.out.println("Fibonacci:");
		for (int i = 1; i <= n; i++) {
			int F = fibonaccy_n(i);
			System.out.print(F + "  ");
		}
		System.out.println();
		
		// Cau 2
		n = 3;
		System.out.println("Sum of Fib: " + sum_Fibonacci(n));
		

	}

	private static int fibonaccy_n(int n) {
		if (n == 1 || n == 2) {
			return 1;
		}
		int F1 = 1;
		int F2 = 1;
		int F = 0;
		int count = 2;
		while (count < n) {
			F = F1 + F2;
			F2 = F1;
			F1 = F;
			count++;
		}
		return F;
	}

	private static int sum_Fibonacci(int n) {
		int count = 0;
		int result = 0;
		int i = 1;
		while (count < n) {
			int F = fibonaccy_n(i);
			if (F % 2 == 0) {
				result += F;
				count++;
			}
			i++;
		}
		return result;
	}
}
