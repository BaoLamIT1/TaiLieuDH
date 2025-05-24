package week_02;

public class Execice_03 {

	private static String calculate_01(String s) {
		String result = "";
		result = s.replaceAll("a", "");
		result = new StringBuffer(result).reverse().toString();
		return result;
	}

	private static int calculate_02(String s) {
		String[] lStrs = s.split(" ");
		int count = 0;
		for (String s_e : lStrs) {
			try {
				Double.parseDouble(s_e);
				count++;
			} catch (NumberFormatException e) {
				return -1;
			}
		}
		return count;
	}

	public static void main(String[] args) {
		// Câu 1
		String s = "Lap trinh Java khong don gian";
		System.out.println("Input: " + s);
		s = calculate_01(s);
		System.out.println("Output: " + s);

		// Câu 2
		s = "2 34.5 -1a2.9 0 12 1.98";
		int count = calculate_02(s);
		if (count == -1){
			System.out.println("false");
		}else{
			System.out.println("true: có số phần tử là: " + count);
		}
	}

}
