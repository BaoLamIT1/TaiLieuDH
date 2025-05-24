package com.example.onthi;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.content.Intent;
import android.graphics.Color;
import android.net.Uri;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.ContextMenu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.EditText;
import android.widget.ListView;

import com.google.android.material.floatingactionbutton.FloatingActionButton;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    public EditText editSearch;
    public ListView listView;
    public FloatingActionButton btnAdd;
    public ArrayList<Taxi_MaDe> listTaxi;
    public Adapter adapter;
    public SQLite_05 sqLite05;
    public int selectedItemId;
    public Taxi_MaDe tx;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        editSearch = findViewById(R.id.edit_search);
        listView = findViewById(R.id.list_item);
        btnAdd = findViewById(R.id.btnAdd);
        listTaxi = new ArrayList<Taxi_MaDe>();
        sqLite05 = new SQLite_05(this,"D",null,1);
//        sqLite05.addTaxi(new Taxi_MaDe("c12-a1",34.67,2400,15));
//        sqLite05.addTaxi(new Taxi_MaDe("a12-a1",34.67,2400,5));
//        sqLite05.addTaxi(new Taxi_MaDe("b25-a1",34.67,2400,10));
        listTaxi = sqLite05.getTaxi();
        adapter = new Adapter(listTaxi,MainActivity.this);
        listView.setAdapter(adapter);
        registerForContextMenu(listView);
        editSearch.setTextColor(Color.RED);

        //Tim kiem
        editSearch.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {

            }

            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {
                adapter.getFilter().filter(s.toString());
                adapter.notifyDataSetChanged();
            }

            @Override
            public void afterTextChanged(Editable s) {

            }
        });
        //them
        btnAdd.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(MainActivity.this,AddTaxi.class);
                startActivityForResult(i,100);
            }
        });
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        if(requestCode==100&&resultCode==150&&data!=null)
        {
            Bundle bd = data.getExtras();
            String soxe = bd.getString("soxe");
            double QD = bd.getDouble("QD");
            int dongia = bd.getInt("dongia");
            int KM = bd.getInt("KM");
            sqLite05.addTaxi(new Taxi_MaDe(soxe,QD,dongia,KM));
            listTaxi=sqLite05.getTaxi();
            adapter = new Adapter(listTaxi,MainActivity.this);
            listView.setAdapter(adapter);
        }
        if(requestCode==200&&resultCode==150&&data!=null)
        {
            Bundle bd = data.getExtras();
            int maxe = bd.getInt("maxe");
            String soxe = bd.getString("soxe");
            double QD = bd.getDouble("QD");
            int dongia = bd.getInt("dongia");
            int KM = bd.getInt("KM");
            sqLite05.updateTaxi(maxe,new Taxi_MaDe(maxe,soxe,QD,dongia,KM));
            listTaxi=sqLite05.getTaxi();
            adapter = new Adapter(listTaxi,MainActivity.this);
            listView.setAdapter(adapter);
        }
    }
    @Override
    public void onCreateContextMenu(ContextMenu menu, View v, ContextMenu.ContextMenuInfo menuInfo) {
        super.onCreateContextMenu(menu, v, menuInfo);
        MenuInflater inflater = new MenuInflater(this);
        inflater.inflate(R.menu.menu_context, menu);

    }

    @Override
    public boolean onContextItemSelected(@NonNull MenuItem item) {
        tx= listTaxi.get(selectedItemId);
        if(item.getItemId()==R.id.menu_edit)
        {
            edit_item(tx.getMaXe());
        }
        else if(item.getItemId()==R.id.menu_delete){
            deleteItem();

        }
        return super.onContextItemSelected(item);
    }
    public void edit_item(int maxe){
        Intent i= new Intent(MainActivity.this,AddTaxi.class);
        Bundle b = new Bundle();
        b.putInt("maxe",tx.getMaXe());
        b.putString("soxe",tx.getSoXe());
        b.putDouble("QD", tx.getQuangDuong());
        b.putInt("dongia", tx.getDonGia());
        b.putInt("KM",tx.getPhamTramKM());
        i.putExtras(b);
        startActivityForResult(i,200);
    }
    public void deleteItem()
    {
        AlertDialog.Builder dg= new AlertDialog.Builder(MainActivity.this);
        dg.setTitle("Thông báo");
        dg.setMessage("Bạn có chắc chắn muốn xóa không?");
        dg.setPositiveButton("OK", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                sqLite05.deleteContact(tx.getMaXe());
                listTaxi = sqLite05.getTaxi();
                adapter= new Adapter(listTaxi,MainActivity.this);
                listView.setAdapter(adapter);

            }
        });
        dg.setNegativeButton("Cancel", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                dialog.cancel();
            }
        });
        AlertDialog al = dg.create();
        al.show();

    }
}