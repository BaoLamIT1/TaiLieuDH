package week_04.shapes;

// Chú ý:
// Khi chúng ta sử dụng interface, mặc định các phương thức đã là abstract, nên
// không cần sử dụng từ khóa abstract.
public interface ShapesG {
	// A. Methods - bộ khung của đối tượng - hình học
	
	// 1. Tính diện tích của hình: chưa xác định cách thức cài đặt
	// => trừu tượng hóa: sử dụng abstract.
	public double area();
	
	// 2. Tính chu vi của hình: chưa xác định cách thức cài đặt
	// => trừu tượng hóa: sử dụng abstract.
	public double perimeters();
	
	
}
