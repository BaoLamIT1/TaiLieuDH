package com.example.hoadontaxi2;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

import java.util.ArrayList;

public class Database extends SQLiteOpenHelper {

    public static final String TableName = "Taxi02";
    public static final String Ma = "MA";
    public static final String SoXe = "SoXe";
    public static final String QuangDuong = "QuangDuong";
    public static final String DonGia = "Hoa";
    public static final String KhuyenMai = "KhuyenMai";

    public Database(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
    }


    @Override
    public void onCreate(SQLiteDatabase db) {
        //Tạo câu sql để tạo bảng TableContact
        String sqlCreate = "Create table if not exists " + TableName + " ("
                + Ma + " INTEGER PRIMARY KEY AUTOINCREMENT, "
                + SoXe + " Text, "
                + QuangDuong + " Double, "
                + DonGia + " Double, "
                + KhuyenMai + " INTEGER) ";
//                + Anh + " String) ";
        ;

        //Chạy câu truy vấn sql để tạo bảng
        db.execSQL(sqlCreate);

    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        //xoá bảng TableContact đã có
        db.execSQL("Drop table if exists " + TableName);

        //taoj laij
        onCreate(db);
    }

    public ArrayList<hoaDonTaxi> getAllContact() {
        ArrayList<hoaDonTaxi> list = new ArrayList<>();
        String sql = "Select * from " + TableName;
        //Lay doi tuong csdl
        SQLiteDatabase db = this.getReadableDatabase();
        //chạy câu truy vấn về dạng Cursor
        Cursor cursor = db.rawQuery(sql, null);
        //tạo ArrayList<Contact> ể trả về
        if (cursor != null) {
            while (cursor.moveToNext()) {
                hoaDonTaxi contact = new hoaDonTaxi(
                        cursor.getInt(0),
                        cursor.getString(1),
                        cursor.getDouble(2),
                        cursor.getDouble(3),
                        cursor.getInt(4)
                );
                list.add(contact);
            }
        }
        return list;
    }

    public void addContact(String soXe, double qd, double dongia, int km) {
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues value = new ContentValues();
        value.put(SoXe, soXe);
        value.put(QuangDuong, qd);
        value.put(DonGia, dongia);
        value.put(KhuyenMai, km);
        db.insert(TableName, null, value);
        db.close();
    }

    public void updateContact(int id, hoaDonTaxi contact) {
        SQLiteDatabase db = getWritableDatabase();
        ContentValues value = new ContentValues();
        value.put(Ma, contact.getMa());
        value.put(SoXe, contact.getSoXe());
        value.put(QuangDuong, contact.getQuangDuong());
        value.put(DonGia, contact.getDonGia());
        value.put(KhuyenMai, contact.getKhuyenMai());
        db.update(TableName, value, Ma + "=?",
                new String[]{String.valueOf(id)});
        db.close();
    }

    public void deleteContact(int id) {
        SQLiteDatabase db = getWritableDatabase();
        String sql = "Delete From " + TableName + " Where Ma = " + id;
        //db.delete(TableName, Ma + "=?",id);
        db.execSQL(sql);
        db.close();
    }
}
