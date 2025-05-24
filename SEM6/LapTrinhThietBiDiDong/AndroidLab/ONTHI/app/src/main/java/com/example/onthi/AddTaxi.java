package com.example.onthi;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class AddTaxi extends AppCompatActivity {

    EditText editSXe;
    EditText editQD;
    EditText editDG;
    EditText editKM;
    Button btnadd;
    Button btnback;
    int maxe=0;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_taxi);
        editSXe = findViewById(R.id.editSoxe);
        editQD = findViewById(R.id.editQD);
        editDG = findViewById(R.id.editDonGia);
        editKM = findViewById(R.id.editKM);
        btnadd= findViewById(R.id.btn_add);
        btnback = findViewById(R.id.btn_back);
        Intent intent = getIntent();
        if(intent!=null)
        {
            Bundle b = intent.getExtras();
            if (b != null) {
                maxe = b.getInt("maxe");
                String soxe = b.getString("soxe");
                double QD = b.getDouble("QD");
                int dongia = b.getInt("dongia");
                int KM = b.getInt("KM");
                editSXe.setText(soxe);
                editQD.setText(String.valueOf(QD));
                editDG.setText(String.valueOf(dongia));
                editKM.setText(String.valueOf(KM));
                btnadd.setText("Sửa");}
        }

            btnadd.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent();
                Bundle b= new Bundle();
                if(maxe!=0){
                    b.putInt("maxe",maxe);
                }
                b.putString("soxe",editSXe.getText().toString());
                b.putDouble("QD", Double.parseDouble(editQD.getText().toString()));
                b.putInt("dongia", Integer.parseInt(editDG.getText().toString()));
                b.putInt("KM", Integer.parseInt(editKM.getText().toString()));
                i.putExtras(b);
                setResult(150,i);
                finish();
            }
        });
        btnback.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });
    }
}