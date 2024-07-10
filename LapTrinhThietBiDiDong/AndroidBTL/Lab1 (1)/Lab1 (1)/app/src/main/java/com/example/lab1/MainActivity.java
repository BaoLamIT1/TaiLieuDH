package com.example.lab1;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.RadioButton;
import android.widget.Spinner;

import java.util.ArrayList;


public class MainActivity extends AppCompatActivity implements AdapterView.OnItemSelectedListener, View.OnClickListener  {

    EditText ten;
    EditText sdt;
    RadioButton nam;
    RadioButton nu;
    ListView l;
    Button btn;
    String ds = "";
    String gt ="";
    ArrayList<String> dsach = new ArrayList<>();

    String[] que = {"Quê quán","Hải Phòng", "Hà Nội", "Bình Định", "Quảng Ngãi", "Hải Dương"};

    ArrayAdapter<String>arr;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ten = findViewById(R.id.txtTen);
        sdt = findViewById(R.id.txtSdt);
        nam = findViewById(R.id.rdbNam);
        nu = findViewById(R.id.rdbNu);
        btn = findViewById(R.id.btnAdd);
        //Hien thi spnner
        Spinner spino = findViewById(R.id.spinner);
        spino.setOnItemSelectedListener(this);

        ArrayAdapter ad = new ArrayAdapter(this, android.R.layout.simple_spinner_item,que);
        ad.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        spino.setAdapter(ad);

        // Them vao danh sach
        dsach.add("ABC EFG");
        l = findViewById(R.id.danhsach);

        //que = new ArrayAdapter<String>(this, androidx.appcompat.R.layout.support_simple_spinner_dropdown_item,dsach);
        l.setAdapter(arr);



        // click vaof = btnAdd để thêm


        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if(nam.isChecked()) gt = "Nam";
                if(nu.isChecked()) gt = "Nữ";
                ds= ten.getText().toString() + " - " +  gt + " - " +sdt.getText().toString() + " - " + spino.getSelectedItem().toString();
                dsach.add(ds);
                l.setAdapter(arr);
            }
        });


    }


    @Override
    public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {

    }

    @Override
    public void onNothingSelected(AdapterView<?> parent) {

    }


    @Override
    public void onClick(View v) {

    }

}