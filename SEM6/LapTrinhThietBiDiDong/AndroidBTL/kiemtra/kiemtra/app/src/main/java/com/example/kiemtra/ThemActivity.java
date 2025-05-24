package com.example.kiemtra;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class ThemActivity extends AppCompatActivity {

    private EditText edtSBD;
    private EditText edtName;
    private  EditText edtToan;
    private  EditText edtLy;
    private  EditText edtHoa;
    private Button btnAdd;

    private Button btnReturn;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_them);
        edtSBD = findViewById(R.id.edtSBD);
        edtName = findViewById(R.id.edtName);
        edtToan = findViewById(R.id.edtToan);
        edtLy = findViewById(R.id.edtLy);
        edtHoa = findViewById(R.id.edtHoa);
        btnAdd = findViewById(R.id.btnAdd);
        btnReturn = findViewById(R.id.btnQuayve);

        btnAdd.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                try {
                    String id = edtSBD.getText().toString();
                    String name = edtName.getText().toString();
                    double toan = Double.parseDouble(edtToan.getText().toString());
                    double ly = Double.parseDouble(edtLy.getText().toString());
                    double hoa = Double.parseDouble(edtHoa.getText().toString());
                    // Kiểm tra xem các trường có rỗng không
                    if (name.isEmpty() || id.isEmpty()) {
                        Toast.makeText(getApplicationContext(), "Vui lòng nhập đủ thông tin", Toast.LENGTH_SHORT).show();
                        return;
                    } else {
                        Intent intent = new Intent();
                        //Bundle ở đây được sử dụng để đóng gói dữ liệu
                        // và gửi nó từ Activity hiện tại đến Activity khác thông qua Intent
                        Bundle b = new Bundle();
                        b.putString("Id", id);
                        b.putString("Name", name);
                        b.putDouble("Toan", toan);
                        b.putDouble("Ly", ly);
                        b.putDouble("Hoa", hoa);
                        intent.putExtras(b);
                        setResult(150, intent);
                        finish();
                    }
                } catch (NumberFormatException e) {
                    Toast.makeText(getApplicationContext(), "Vui lòng nhập số cho ID", Toast.LENGTH_SHORT).show();
                }

            }
        });

        btnReturn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });

    }
    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        if(requestCode==200) {
            Bundle b = data.getExtras();
            String id = b.getString("Id");
            edtSBD.setText(id);
            String name = b.getString("Name");
            edtName.setText(name);
            double toan = b.getDouble("Toan");
            edtToan.setText(String.valueOf(toan));
            double ly = b.getDouble("Ly");
            edtToan.setText(String.valueOf(ly));
            double hoa = b.getDouble("Hoa");
            edtToan.setText(String.valueOf(hoa));
        }

    }
}