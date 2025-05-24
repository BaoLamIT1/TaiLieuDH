package com.example.giaodich;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.database.Cursor;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.ContextMenu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;

import com.google.android.material.floatingactionbutton.FloatingActionButton;

import java.text.NumberFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.Date;
import java.util.List;
import java.util.Locale;

public class MainActivity extends AppCompatActivity {

    private ListView listView;
    private EditText etSearch;
    private Adapter adapter;
    private List<GiaoDich> giaoDichList = new ArrayList<>();
    private TextView tvBalance;
    private Database databaseHelper;
    private int SelectedItemId;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        etSearch = findViewById(R.id.etSearch);
        listView = findViewById(R.id.lst_main);
        tvBalance = findViewById(R.id.tvBalance);
        databaseHelper = new Database(this, "db1", null,1);

        registerForContextMenu(listView);
        loadGiaoDich();
        calculateBalance();
        // Gọi phương thức sortGiaoDichListByDate() để sắp xếp danh sách
       // sortGiaoDichListByDate();
       // sortGiaoDichListByMoney();
        etSearch.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {
            }

            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {
                filterGiaoDich(s.toString());
            }

            @Override
            public void afterTextChanged(Editable s) {
            }
        });
        listView.setOnItemLongClickListener(new AdapterView.OnItemLongClickListener(){
            @Override
            public boolean onItemLongClick(AdapterView<?> parent, View view, int position, long id) {
                SelectedItemId = position;
                return false;
            }
        });
    }

    @Override
    public void onCreateContextMenu(ContextMenu menu, View v, ContextMenu.ContextMenuInfo menuInfo) {
        MenuInflater inflater = new MenuInflater(this);
        inflater.inflate(R.menu.context_menu,menu);
        super.onCreateContextMenu(menu, v, menuInfo);
    }

    @Override
    public boolean onContextItemSelected(@NonNull MenuItem item) {
        GiaoDich c = giaoDichList.get(SelectedItemId);
        if (item.getItemId() == R.id.mnuDelete)
        {
            AlertDialog.Builder builder = new AlertDialog.Builder(MainActivity.this);
            builder.setTitle("Confirm");
            builder.setMessage("Are you sure to delete");
            builder.setPositiveButton("Yes", new DialogInterface.OnClickListener() {
                @Override
                public void onClick(DialogInterface dialog, int which) {
                    giaoDichList.remove(SelectedItemId);
                    adapter.notifyDataSetChanged();
                }
            });
            builder.setNegativeButton("NO", null);
            builder.create().show();
        }
        return super.onContextItemSelected(item);
    }

    private void loadGiaoDich() {
        Cursor cursor = databaseHelper.getAllGiaoDich();
        if (cursor.moveToFirst()) {
            do {
                int maGiaoDich = cursor.getInt(0);
                String noiDung = cursor.getString(1);
                String ngayThang = cursor.getString(2);
                boolean loaiGiaoDich = cursor.getInt(3) == 1;
                String tenNguoi = cursor.getString(4);
                double soTien = cursor.getDouble(5);

                giaoDichList.add(new GiaoDich(maGiaoDich, noiDung, ngayThang, loaiGiaoDich, tenNguoi, soTien));
            } while (cursor.moveToNext());
        }
        cursor.close();

        adapter = new Adapter(this, giaoDichList);
        listView.setAdapter(adapter);
    }

    private void calculateBalance() {
        double balance = 0;
        for (GiaoDich gd : giaoDichList) {
            if (gd.isLoaiGiaoDich()) {
                balance += gd.getSoTien();
            } else {
                balance -= gd.getSoTien();
            }
        }
        NumberFormat numberFormat = NumberFormat.getNumberInstance(Locale.getDefault());
        String formattedBalance = numberFormat.format(balance);
        tvBalance.setText("Số dư còn lại: " + formattedBalance + " VND");
    }
    private void sortGiaoDichListByDate() {
        // Sắp xếp danh sách các giao dịch theo thứ tự tăng dần của ngày tháng
        Collections.sort(giaoDichList, new Comparator<GiaoDich>() {
            SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd", Locale.getDefault());

            @Override
            public int compare(GiaoDich gd1, GiaoDich gd2) {
                try {
                    Date date1 = dateFormat.parse(gd1.getNgayThang());
                    Date date2 = dateFormat.parse(gd2.getNgayThang());
                    return date1.compareTo(date2);
                } catch (ParseException e) {
                    e.printStackTrace();
                    return 0;
                }
            }
        });
    }
    //        Sap xep theo gia tien
    private void sortGiaoDichListByMoney() {
        // Sắp xếp danh sách các giao dịch theo thứ tự tăng dần của số tiền
        Collections.sort(giaoDichList, new Comparator<GiaoDich>() {
            @Override
            public int compare(GiaoDich gd1, GiaoDich gd2) {
                // Sắp xếp theo số tiền tăng dần
                return Double.compare(gd1.getSoTien(), gd2.getSoTien());
                // Để sắp xếp theo số tiền giảm dần, đổi vị trí của gd1 và gd2 trong return
            }
        });
    }
    private void filterGiaoDich(String keyword) {
        List<GiaoDich> filteredList = new ArrayList<>();
        for (GiaoDich gd : giaoDichList) {
            if (gd.getTenNguoi().toLowerCase().contains(keyword.toLowerCase())) {
                filteredList.add(gd);
            }
        }
        adapter = new Adapter(this, filteredList);
        listView.setAdapter(adapter);
    }
}