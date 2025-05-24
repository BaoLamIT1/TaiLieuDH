package com.example.giaodich;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

public class Database extends SQLiteOpenHelper {

   //private static final String DATABASE_NAME = "GiaoDichDB.db";
    private static final int DATABASE_VERSION = 1;

    private static final String TABLE_NAME = "GiaoDich";
    private static final String COLUMN_ID = "id";
    private static final String COLUMN_NOIDUNG = "noiDung";
    private static final String COLUMN_NGAYTHANG = "ngayThang";
    private static final String COLUMN_LOAIGIAODICH = "loaiGiaoDich";
    private static final String COLUMN_TENNGUOI = "tenNguoi";
    private static final String COLUMN_SOTIEN = "soTien";


    public Database(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        String sqlCreate = "CREATE TABLE " + TABLE_NAME + " (" +
                COLUMN_ID + " INTEGER PRIMARY KEY AUTOINCREMENT, " +
                COLUMN_NOIDUNG + " TEXT, " +
                COLUMN_NGAYTHANG + " TEXT, " +
                COLUMN_LOAIGIAODICH + " INTEGER, " +
                COLUMN_TENNGUOI + " TEXT, " +
                COLUMN_SOTIEN + " REAL)";
        db.execSQL(sqlCreate);
        insertSampleData(db);
    }
    private void insertSampleData(SQLiteDatabase db) {
        insertGiaoDich(db, "Lương", "15-01-2023", true, "Cong Trung", 12000000);
        insertGiaoDich(db, "Thuê nhà", "20-01-2023", false, "Thu Huyền", 2200000);
        insertGiaoDich(db,"Gop tien an ", "28-01-2023",false,"Hà Nam Anh",3000000);
        insertGiaoDich(db,"Thưởng", "30-01-2023",true,"Mai Thu Ha",4100000);
    }
    private void insertGiaoDich(SQLiteDatabase db, String noiDung, String ngayThang, boolean loaiGiaoDich, String tenNguoi, double soTien) {
        ContentValues values = new ContentValues();
        values.put(COLUMN_NOIDUNG, noiDung);
        values.put(COLUMN_NGAYTHANG, ngayThang);
        values.put(COLUMN_LOAIGIAODICH, loaiGiaoDich ? 1 : 0);
        values.put(COLUMN_TENNGUOI, tenNguoi);
        values.put(COLUMN_SOTIEN, soTien);
        db.insert(TABLE_NAME, null, values);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("DROP TABLE IF EXISTS " + TABLE_NAME);
        onCreate(db);
    }
    public Cursor getAllGiaoDich() {
        SQLiteDatabase db = this.getWritableDatabase();
        return db.rawQuery("SELECT * FROM " + TABLE_NAME, null);
    }
    public void deleteContact(String id)
    {
        SQLiteDatabase db = getWritableDatabase();
        String sql = "Delete From " + TABLE_NAME + " Where Id=" + id;
        db.delete(TABLE_NAME, COLUMN_ID + "=?",new String[]{id});
        db.execSQL(sql);
        db.close();
    }
}
