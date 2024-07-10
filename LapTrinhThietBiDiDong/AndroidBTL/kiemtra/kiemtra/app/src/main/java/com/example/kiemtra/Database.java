package com.example.kiemtra;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

import java.util.ArrayList;

public class Database extends SQLiteOpenHelper {

    public static final String TableName = "ThiSinhTable";
    public static final String Id = "Id";
    public static final String Name = "Fullname";
    public static final String Toan = "Toan";
    public static final String Ly = "Ly";
    public static final String Hoa = "Hoa";

    public Database(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
    }


    @Override
    public void onCreate(SQLiteDatabase db) {
        //Tạo câu sql để tạo bảng TableContact
        String sqlCreate = "Create table if not exists " + TableName + " ("
                + Id +" Text, "
                + Name + " Text, "
                + Toan + " Double, "
                + Ly + " Double, "
                + Hoa + " Double) ";

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

    public ArrayList<ThiSinh> getAllContact(){
        ArrayList<ThiSinh> list = new ArrayList<>();
        String sql = "Select * from " + TableName;
        //Lay doi tuong csdl
        SQLiteDatabase db = this.getReadableDatabase();
        //chạy câu truy vấn về dạng Cursor
        Cursor cursor = db.rawQuery(sql,null);
        //tạo ArrayList<Contact> ể trả về
        if(cursor!=null){
            while (cursor.moveToNext()){
                ThiSinh contact = new ThiSinh(cursor.getString(0),
                        cursor.getString(1),
                        cursor.getDouble(2),
                        cursor.getDouble(3),
                        cursor.getDouble(4));
                list.add(contact);
            }
        }
        return list;
    }

    public void addContact(ThiSinh contact){
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues value = new ContentValues();
        value.put(Id, contact.getSBD());
        value.put(Name, contact.getHoten());
        value.put( Toan, contact.getToan());
        value.put(Ly, contact.getLy());
        value.put(Hoa, contact.getHoa());
        db.insert(TableName, null, value);
        db.close();
    }

    public void updateContact(String id,ThiSinh contact){
        SQLiteDatabase db = getWritableDatabase();
        ContentValues value = new ContentValues();
        value.put(Id,contact.getSBD());
        value.put(Name, contact.getHoten());
        value.put(Toan, contact.getToan());
        value.put(Ly, contact.getLy());
        value.put(Hoa, contact.getHoa());
        db.update(TableName,value, Id  + " = ?",new String[]{id});
        db.close();
    }

    public void deleteThiSinh(String id)
    {
        SQLiteDatabase db = getWritableDatabase();
        String sql = "Delete From " + TableName + " Where Id=" + id;
        db.delete(TableName, Id + "=?",new String[]{id});
        db.execSQL(sql);
        db.close();
    }



}
