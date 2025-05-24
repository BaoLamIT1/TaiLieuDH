package com.example.kiemtra;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Toast;

import com.google.android.material.floatingactionbutton.FloatingActionButton;

import java.util.ArrayList;

public class UpdateActivity extends AppCompatActivity {
    private EditText edtSBD1;
    private EditText edtName1;
    private  EditText edtToan1;
    private  EditText edtLy1;
    private  EditText edtHoa1;
    private Button btnSua;

    private Button btnReturn1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_update);

        Intent intent = getIntent();
        Bundle b = intent.getExtras();
        String id = b.getString("Id");
        String name = b.getString("Name");
        double toan = b.getDouble("Toan");
        double ly = b.getDouble("Ly");
        double hoa = b.getDouble("Hoa");

        edtSBD1 = findViewById(R.id.edtSBD1);
        edtSBD1.setText(id);
        edtName1 = findViewById(R.id.edtName1);
        edtName1.setText(name);
        edtToan1 = findViewById(R.id.edtToan1);
        edtToan1.setText(String.valueOf(toan));
        edtLy1 = findViewById(R.id.edtLy1);
        edtLy1.setText(String.valueOf(ly));
        edtHoa1 = findViewById(R.id.edtHoa1);
        edtHoa1.setText(String.valueOf(hoa));
        btnSua = findViewById(R.id.btnSua);
        btnReturn1 = findViewById(R.id.btnReturn);
        btnReturn1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });
        btnSua.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                try {
                    String id = edtSBD1.getText().toString();
                    String name = edtName1.getText().toString();
                    double toan = Double.parseDouble(edtToan1.getText().toString());
                    double ly = Double.parseDouble(edtLy1.getText().toString());
                    double hoa = Double.parseDouble(edtHoa1.getText().toString());
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
                        setResult(200, intent);
                        finish();
                    }
                } catch (NumberFormatException e) {
                    Toast.makeText(getApplicationContext(), "Vui lòng nhập số cho ID", Toast.LENGTH_SHORT).show();
                }
            }
        });

    }
}