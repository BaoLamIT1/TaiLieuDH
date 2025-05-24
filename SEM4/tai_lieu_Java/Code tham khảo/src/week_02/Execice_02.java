package week_02;

public class Execice_02 {

	private static double calculate(int n, double x) {
		double result = 0.0;
		double Q = 1.0;
		double T = 0.0;
		for (int i = 1; i <= n; i++) {
			Q = Q * i;
			if (i % 2 == 1) {
				T -= (x - 1.0 + i) / (Q + x);
			} else {
				T += (x - 1.0 + i) / (Q + x);
			}

		}
		if (T < 0) {
			return 2023.0;
		} else {
			result = 2022.0 - Math.sqrt(T);
			return result;
		}
	}

	public static void main(String[] args) {
		int n = 4;
		double x = 1.2;
		double S = calculate(n, x);
		if (S >= 2023.0) {
			System.out.println("Không thỏa mãn!");
		} else {
			System.out.println("S = " + S);
		}
	}

}
