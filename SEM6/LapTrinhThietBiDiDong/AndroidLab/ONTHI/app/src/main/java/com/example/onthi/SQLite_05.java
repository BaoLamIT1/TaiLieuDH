package com.example.onthi;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Log;

import androidx.annotation.Nullable;

import java.util.ArrayList;

public class SQLite_05 extends SQLiteOpenHelper {
    public static final String TableName = "Taxi_MaDe";
    public static final  String maxe ="MaXe";
    public static final String soxe = "SoXe";
    public static final String quangduong = "QuangDuong";
    public static final String dongia = "DonGia";
    public static final String phantramKM = "KM";
    public SQLite_05(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);

    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        String sqlCreate = "Create table if not exists " + TableName + "(" +
                maxe + " Integer Primary key AUTOINCREMENT, "
                + soxe + " Text, "
                + quangduong + " Double, "
                + dongia + " Integer, "
                + phantramKM + " Integer)";
        db.execSQL(sqlCreate);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("Drop table if exists " + TableName);
        onCreate(db);
    }
    public void addTaxi(Taxi_MaDe taxi) {
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues values = new ContentValues();
        values.put(soxe, taxi.getSoXe());
        values.put(quangduong, taxi.getQuangDuong());
        values.put(dongia, taxi.getDonGia());
        values.put(phantramKM, taxi.getPhamTramKM());
        db.insert(TableName, null, values);
        db.close();

    }
    public ArrayList<Taxi_MaDe> getTaxi() {
        ArrayList<Taxi_MaDe> list = new ArrayList<>();
        String sql = "Select * from " + TableName;
        SQLiteDatabase db = this.getReadableDatabase();
        Cursor cursor = db.rawQuery(sql, null);
        if (cursor != null) {
            while (cursor.moveToNext()) {
                Taxi_MaDe c = new Taxi_MaDe(cursor.getInt(0),
                        cursor.getString(1), cursor.getDouble(2), cursor.getInt(3), cursor.getInt(4));
                list.add(c);
            }
            db.close();
        }
        //sap xep
        list.sort((t1, t2) -> t1.getSoXe().compareTo(t2.getSoXe()));
        return list;
    }
    public void updateTaxi(int Id, Taxi_MaDe taxi){
        SQLiteDatabase db = getWritableDatabase();
        ContentValues values = new ContentValues();
        values.put(soxe, taxi.getSoXe());
        values.put(quangduong, taxi.getQuangDuong());
        values.put(dongia, taxi.getDonGia());
        values.put(phantramKM, taxi.getPhamTramKM());
        db.update(TableName, values, maxe + "=?", new String[]{String.valueOf(Id)});
        db.close();

    }
    public void deleteContact(int id){
        SQLiteDatabase db = getWritableDatabase();
        String sql ="Delete from " + TableName+ " Where MaXe = " + id;
        db.execSQL(sql);
        db.close();
    }
}
