package com.example.kiemtra;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.ContextMenu;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Toast;

import com.google.android.material.floatingactionbutton.FloatingActionButton;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;

public class MainActivity extends AppCompatActivity {

    private EditText edtSearch;
    private ListView lstThiSinh;

    private FloatingActionButton btnThem;

    private ArrayList<ThiSinh> thiSinhArrayList;
    private  Adapter adapter;
    private Database database;
    private int SelectedItemId;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        edtSearch = findViewById(R.id.edtSearch);
        lstThiSinh = findViewById(R.id.lstThiSinh);
        btnThem = findViewById(R.id.btnThem);

        database = new Database(this, "ThiSinhDB", null,1);

        // Create a list of Contact objects
        thiSinhArrayList = new ArrayList<>();
//        database.addContact(new ThiSinh("GHA01839", "Vũ Trường An", 8,8,8));
//        database.addContact(new ThiSinh("GHA01839", "Vũ Trường An", 8,8,8));
//        database.addContact(new ThiSinh("GHA00002", "Vũ Trường", 8,8,8));
//        database.addContact(new ThiSinh("GHA00003", "Vũ An", 8,8,8));
        thiSinhArrayList= database.getAllContact();
        // Add more contacts as needed
        registerForContextMenu(lstThiSinh);
        // Create the adapter and set it to the ListView
        adapter = new Adapter(thiSinhArrayList, this);
        lstThiSinh.setAdapter(adapter);

        btnThem.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                //tao intent de mo activity
                Intent intent = new Intent(MainActivity.this,ThemActivity.class);

                startActivityForResult(intent,100);//requestcode để đánh dấu lần yêu cầu để xử lý tình huống

            }
        });

        lstThiSinh.setOnItemLongClickListener(new AdapterView.OnItemLongClickListener() {
            @Override
            public boolean onItemLongClick(AdapterView<?> parent, View view, int position, long id) {
                SelectedItemId = position;
                return false;
            }
        });


    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        super.onActivityResult(requestCode, resultCode, data);

        if(requestCode == 100 && resultCode ==150 ){
            Bundle b = data.getExtras();
            String id = b.getString("Id");
            String name = b.getString("Name");
            double toan = b.getDouble("Toan");
            double ly = b.getDouble("Ly");;
            double hoa = b.getDouble("Hoa");
            ThiSinh newTS = new ThiSinh(id, name, toan, ly, hoa);
            //truong hop them
            database.addContact(newTS);
            thiSinhArrayList.add(newTS);
            adapter.notifyDataSetChanged();
        }else if( requestCode==200){
            Bundle b = data.getExtras();
            String id = b.getString("Id");
            String name = b.getString("Name");
            double toan = b.getDouble("Toan");
            double ly = b.getDouble("Ly");;
            double hoa = b.getDouble("Hoa");
            ThiSinh newTS = new ThiSinh(id, name, toan, ly, hoa);
            //truong hop sua
            database.updateContact(id, newTS);
            thiSinhArrayList.set(SelectedItemId,newTS);
            adapter.notifyDataSetChanged();
        }

    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        if(item.getItemId() == R.id.mnuSortTang){
            Collections.sort(thiSinhArrayList, new Comparator<ThiSinh>() {

                @Override
                public int compare(ThiSinh o1, ThiSinh o2) {
                    if (o1.TongDiem() < o2.TongDiem()) {
                        return -1;
                    } else {
                        if (o1.TongDiem() == o2.TongDiem()) {
                            return 0;
                        } else {
                            return 1;
                        }
                    }
                }
            });
        }else if(item.getItemId() == R.id.mnuSortGiam) {
            Collections.sort(thiSinhArrayList, new Comparator<ThiSinh>() {

                @Override
                public int compare(ThiSinh o1, ThiSinh o2) {
                    if (o1.TongDiem() > o2.TongDiem()) {
                        return -1;
                    } else {
                        if (o1.TongDiem() == o2.TongDiem()) {
                            return 0;
                        } else {
                            return 1;
                        }
                    }
                }
            });
        }
        adapter.notifyDataSetChanged();
        return super.onOptionsItemSelected(item);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        MenuInflater inflater = new MenuInflater(this);
        inflater.inflate(R.menu.action_menu,menu);
        return super.onCreateOptionsMenu(menu);
    }

    @Override
    public void onCreateContextMenu(ContextMenu menu, View v, ContextMenu.ContextMenuInfo menuInfo) {
        super.onCreateContextMenu(menu, v, menuInfo);
        MenuInflater inflater = new MenuInflater(this);
        inflater.inflate(R.menu.context_menu,menu);
    }

    @Override
    public boolean onContextItemSelected(@NonNull MenuItem item) {
        ThiSinh c = thiSinhArrayList.get(SelectedItemId);
        if(item.getItemId() == R.id.mnuEdit){
            //Tạo intent để mở subactivity
            Intent intent = new Intent(MainActivity.this,UpdateActivity.class);
            //Truyền sữ liệu sang MainActivity3 bằng bundle nếu cần
            Bundle b = new Bundle();
            b.putString("Id", c.getSBD());
            b.putString("Name", c.getHoten());
            b.putDouble("Toan", c.getToan());
            b.putDouble("Ly", c.getLy());
            b.putDouble("Hoa", c.getHoa());
            intent.putExtras(b);
            startActivityForResult(intent,300);
        }else if(item.getItemId() == R.id.mnuDelete){
            thiSinhArrayList.remove(SelectedItemId);
            database.deleteThiSinh(c.getSBD());
            adapter.notifyDataSetChanged();
        }
        return super.onContextItemSelected(item);
    }

}