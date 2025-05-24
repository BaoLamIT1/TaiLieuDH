package week_02;

public class CaroGame {

	public static int N = 10;

	public static int game[][] = { { -1, 1, 0, 0, 1, 0, 0, 0, 0, 1 }, { -1, 1, 0, 0, 1, 0, 0, 0, 0, 1 },
			{ -1, 1, 0, 0, 1, 0, 0, 0, 0, 1 }, { -1, 1, 0, 0, 1, 0, 0, 0, 0, 1 }, { -1, 1, 0, 0, 1, 0, 0, 0, 0, 1 },
			{ -1, 1, 0, 0, 1, 0, 0, 0, 0, 1 }, { -1, 1, 0, 0, 1, 0, 0, 0, 0, 1 }, { -1, 1, 0, 0, 1, 0, 0, 0, 0, 1 },
			{ -1, 1, 0, 0, 1, 0, 0, 0, 0, 1 }, { -1, 1, 0, 0, 1, 0, 0, 0, 0, 1 } };

	public static void showGame(int[][] game) {
		System.out.println("Game: ");
		for (int i = 0; i < N; i++) {
			for (int j = 0; j < N; j++) {
				System.out.print(game[i][j] + "|");
			}
			System.out.println();
		}
	}

	public static boolean isEmpty(int r, int c, int[][] game) {
		if (game[r][c] == -1) {
			return true;
		}
		return false;
	}

	public static boolean checkRow(int r, int c, int[][] game, int value) {
		int start = c - 4 < 0 ? 0 : c - 4;
		int end = c + 4 < N-1 ? c + 4 : N-1;
		int count = 0;
		for (int i = start; i <= end; i++) {
			if (game[r][i] == value){
				count ++;
			}else{
				count = 0;
			}
			if (count == 5){
				return true;
			}
		}
		return false;
	}
	
	public static boolean isEndGame(int[][] game) {
		for (int i = 0; i < N; i++) {
			for (int j = 0; j < N; j++) {
				if (game[i][j] == -1) {
					return false;
				}
			}
		}
		return true;
	}

	public static void main(String[] args) {
		CaroGame.showGame(game);
	}

}
