package com.example.lab1;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;

public class MainActivity3 extends AppCompatActivity {


    private EditText txtid;
    private EditText txtFullname;
    private EditText txtPhone;

    private EditText txtEmail;

    private ImageView imgAnh;
    private Button btnOk;

    private Button btnCancel;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main3);

        txtid = findViewById(R.id.txtid);
        txtFullname = findViewById(R.id.txtFullname);
        txtPhone = findViewById(R.id.txtPhone);
        txtEmail = findViewById(R.id.txtEmail);
        imgAnh = findViewById(R.id.imgAnh);
        btnCancel = findViewById(R.id.btnCancel);
        btnOk = findViewById(R.id.btnOk);

        Intent intent = getIntent();
        //Lấy bundle
        Bundle bundle = intent.getExtras();
        if(bundle != null){
            int id = bundle.getInt("Id");
            String image = bundle.getString("Image");
            String name = bundle.getString("Name");
            String phone = bundle.getString("Phone");
            String email = bundle.getString("Email");
            txtid.setText(String.valueOf(id));
            txtFullname.setText(name);
            txtPhone.setText(phone);
            txtEmail.setText(email);
            btnOk.setText("Edit");
        }

        btnCancel.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });
        btnOk.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                //Lấy dữ liệu và gửi về cho MainActivity
                int id = Integer.parseInt(txtid.getText().toString());
                String name = txtFullname.getText().toString();
                String phone = txtPhone.getText().toString();
                Intent intent = new Intent();
                //Bundle ở đây được sử dụng để đóng gói dữ liệu
                // và gửi nó từ Activity hiện tại đến Activity khác thông qua Intent
                Bundle b = new Bundle();
                b.putInt("Id", id);
                b.putString("Name", name);
                b.putString("Phone", phone);
                b.putString("Email", phone);
                intent.putExtras(b);
                setResult(150,intent);
                finish();
            }
        });
    }
}