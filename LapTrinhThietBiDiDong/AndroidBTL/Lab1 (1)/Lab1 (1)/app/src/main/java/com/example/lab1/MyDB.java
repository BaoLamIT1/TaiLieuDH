package com.example.lab1;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

import com.google.android.material.tabs.TabLayout;

import java.util.ArrayList;

public class MyDB extends SQLiteOpenHelper {

    public static final String TableName = "ContactTable";
    public static final String Id = "Id";
    public static final String Name = "Fullname";
    public static final String Phone = "Phonenumber";
    public static final String Image = "Image";

    public MyDB(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        //Tạo câu sql để tạo bảng TableContact
        String sqlCreate = "Create table if not exists " + TableName + " ("
                + Id +" Integer Primary key, "
                + Image + " Text, "
                + Name + " Text, "
                + Phone + " Text) ";

        //Chạy câu truy vấn sql để tạo bảng
        db.execSQL(sqlCreate);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        //xoá bảng TableContact đã có
        db.execSQL("Drop table if exists "+ TableName);

        //taoj laij
        onCreate(db);
    }

    public ArrayList<Contact> getAllContact(){
        ArrayList<Contact> list = new ArrayList<>();
        String sql = "Select * from " + TableName;
        //Lay doi tuong csdl
        SQLiteDatabase db = this.getReadableDatabase();
        //chạy câu truy vấn về dạng Cursor
        Cursor cursor = db.rawQuery(sql,null);
        //tạo ArrayList<Contact> ể trả về
        if(cursor!=null){
            while (cursor.moveToNext()){
                Contact contact = new Contact(cursor.getInt(0),
                        cursor.getString(1),
                        cursor.getString(2),
                        cursor.getString(3));
                list.add(contact);
            }
        }

        return list;
    }

    public void addContact(Contact contact){
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues value = new ContentValues();
        value.put(Id, contact.getId());
        value.put(Image, contact.getImages());
        value.put(Name, contact.getName());
        value.put(Phone, contact.getPhone());
        db.insert(TableName, null, value);
        db.close();
    }

    public void updateContact(int id,Contact contact){
        SQLiteDatabase db = getWritableDatabase();
        ContentValues value = new ContentValues();
        value.put(Id,contact.getId());
        value.put(Image, contact.getImages());
        value.put(Name, contact.getName());
        value.put(Phone, contact.getPhone());
        db.update(TableName,value, Id  + " = ?",new String[]{String.valueOf(id)});
        db.close();
    }
}
