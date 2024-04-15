package week_04.shapes;

public interface ShapesT {
	// B. Methods - bộ khung của đối tượng - biến đổi hình học
	// 1. Tịnh tiến
	public void move(double dx, double dy);

	// 2. Xoay
	public void rotate(double alpha);

	// 3. Phóng to, thu nhỏ
	public void zoom(double ratio);
}
