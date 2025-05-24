package com.example.lab1;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.content.IntentFilter;
import android.content.pm.PackageManager;
import android.net.Uri;
import android.os.Build;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.ContextMenu;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Toast;
import android.Manifest;

import com.google.android.material.floatingactionbutton.FloatingActionButton;

import java.nio.channels.SelectionKey;
import java.util.ArrayList;

public class MainActivity2 extends AppCompatActivity {

    protected EditText txtName;
    protected FloatingActionButton btnAdd;
    protected FloatingActionButton btnDelete;
    protected ListView lstStudent;

    protected Adapter ListAdapter;
    private ArrayList<Contact> ContactList;
    protected ArrayList listname;

    private int SelectedItemId;

    private int PERMISSION_REQUEST_READ_CONTACTS = 400;

    EditText etSearch;

    private  MyDB db;
    private ContentProvider cp;

    ConnectionReceiver receiver;

    IntentFilter intentFilter;

   // private static final int


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);
        //Tham chiếu tới các view trên giao diện
        txtName = findViewById(R.id.txtName);
        btnAdd = findViewById(R.id.btnAdd2);
        lstStudent = findViewById(R.id.lstStudent);
        btnDelete = findViewById(R.id.btnDelete);

        registerForContextMenu(lstStudent);

        ContactList = new ArrayList<Contact>();
       /* ContactList.add(new Contact(1, "img1","Nguyễn Văn An", "09123456","nqchi2003@gmail.com"));
        ContactList.add(new Contact(2, "img2","Văn An", "091465646","nqchi2003@gmail.com"));
        ContactList.add(new Contact(3, "img3","Nguyễn An", "0912322222","nqchi2003@gmail.com"));*/

        //Tạo mới Csdl
        //db = new MyDB(this, "ContactDB",null,1);
       /* db.addContact(new Contact(1, "img1","Nguyễn Văn An", "09123456"));
        db.addContact(new Contact(2, "img2","Nguyễn An", "09892456"));
        db.addContact(new Contact(3, "img3","Văn An", "09103426"));*/

        //ContactList = db.getAllContact();
        //Tạo adapter
        //Tham số 1: context lớp cha của lớp Activity
        //Tham số 2: layout của 1 pần tả
        //Tham số 3: arraylist chứa dữ liệu danh sách sinh viên
        //adapter = new ArrayAdapter(this, androidx.appcompat.R.layout.support_simple_spinner_dropdown_item,listname);
        //set adapter cho listview
        ListAdapter = new Adapter(ContactList,this);
        lstStudent.setAdapter(ListAdapter);
        ShowContact();
        btnAdd.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                //1. Tạo intent để mở subactivity
                Intent intent = new Intent(MainActivity2.this,MainActivity3.class);
                //2. Truyền dữ liệu sang subactivity bằng bunble nếu cần
                //3. Mở subactivity bằng cách gọi hàm startactivity hoặc startactivityforresult
                startActivityForResult(intent,100); // requestCode là số hiệu tự quy định, để đánh dấu mã của lần ta gửi yêu cầu
                //
                //listname.add(txtName.getText().toString());
                //adapter.notifyDataSetChanged();
                //lstStudent.setAdapter(ListAdapter);
            }
        });
        lstStudent.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                txtName.setText(ListAdapter.getItem(position).toString());
            }
        });
        lstStudent.setOnItemLongClickListener(new AdapterView.OnItemLongClickListener() {
            @Override
            public boolean onItemLongClick(AdapterView<?> parent, View view, int position, long id) {
                SelectedItemId = position;
                return false;
            }
        });
        btnDelete.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                listname.remove(txtName.getText().toString());
                txtName.setText("");
                lstStudent.setAdapter(ListAdapter);
            }
        });
        etSearch = findViewById(R.id.txtSearchc);
        etSearch.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {

            }

            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {
                ListAdapter.getFilter().filter(s.toString());

                ListAdapter.notifyDataSetChanged();
            }

            @Override
            public void afterTextChanged(Editable s) {

            }
        });

        //broastcastreceiver

        receiver = new ConnectionReceiver();
        intentFilter = new IntentFilter("com.example.lab1.SOME_ACTION");
        intentFilter.addAction(Intent.ACTION_AIRPLANE_MODE_CHANGED);
        intentFilter.addAction("android.net.conn.CONNECTIVITY_CHANGE");
        registerReceiver(receiver, intentFilter);



    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        if(data != null){
            Bundle b = data.getExtras();
            int id = b.getInt("Id");
            String name = b.getString("Name");
            String phone = b.getString("Phone");
            Contact newcontact = new Contact(id,"Image", name,phone);
            if(requestCode == 100 && resultCode ==150){
                //truong hop them
                //ContactList.add(newcontact);
               /* db.addContact(newcontact);
                ContactList = db.getAllContact();*/
                if(Build.VERSION.SDK_INT >= Build.VERSION_CODES.M && checkSelfPermission(Manifest.permission.WRITE_CONTACTS)
                        != PackageManager.PERMISSION_GRANTED){
                    requestPermissions(new String[]{Manifest.permission.WRITE_CONTACTS},PERMISSION_REQUEST_READ_CONTACTS);
                }else{
                    cp = new ContentProvider(this);
                    ContactList = cp.addContact(name,phone);
                    ListAdapter = new Adapter(ContactList,this);
                    lstStudent.setAdapter(ListAdapter);}
            }
            else if(requestCode == 200 && resultCode == 150){
                //truong hop sua
                //ContactList.set(SelectedItemId, newcontact);
                db.updateContact(SelectedItemId,newcontact);
                ContactList = db.getAllContact();
                ListAdapter.notifyDataSetChanged();
            }
        }

    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        if(item.getItemId() == R.id.mnuSortName){
            Toast.makeText(this, "Sort by name", Toast.LENGTH_SHORT).show();
        }else if(item.getItemId() == R.id.mnuBroadcast){
//            Intent intent = new Intent(Intent.ACTION_WEB_SEARCH);
//            startActivity(intent);
            Intent intent = new Intent("com.example.lab1.SOME_ACTION");
            sendBroadcast(intent);
        }
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
        Contact c = ContactList.get(SelectedItemId);
        if(item.getItemId() == R.id.mnuEdit){
            //Tạo intent để mở subactivity
            Intent intent = new Intent(MainActivity2.this,MainActivity3.class);
            //Truyền sữ liệu sang MainActivity3 bằng bundle nếu cần
            Bundle b = new Bundle();
            b.putInt("Id",c.getId());
            b.putString("Image",c.getImages());
            b.putString("Name",c.getName());
            b.putString("Phone",c.getPhone());
            intent.putExtras(b);
            startActivityForResult(intent,200);
        }else if(item.getItemId() == R.id.mnuCall){
            Intent in = new Intent(Intent.ACTION_DIAL, Uri.parse("tel: " + c.getPhone()));
            startActivity(in);

            //https://developer.android.com/reference/android/content/Intent
        }else if(item.getItemId() == R.id.mnuSms){
            Intent it  = new Intent(Intent.ACTION_SENDTO, Uri.parse("sms: " + c.getPhone()));
            startActivity(it);
        }
        return super.onContextItemSelected(item);
    }

    private void ShowContact(){
        if(Build.VERSION.SDK_INT >= Build.VERSION_CODES.M && checkSelfPermission(Manifest.permission.READ_CONTACTS)
         != PackageManager.PERMISSION_GRANTED){
            requestPermissions(new String[]{Manifest.permission.READ_CONTACTS},PERMISSION_REQUEST_READ_CONTACTS);
        }else{
            cp = new ContentProvider(this);
            ContactList = cp.getAllContact();
            ListAdapter = new Adapter(ContactList,this);
            lstStudent.setAdapter(ListAdapter);
        }
    }


}