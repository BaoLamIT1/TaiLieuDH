package com.example.todotask;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.widget.Toast;

import androidx.annotation.Nullable;

import com.example.todotask.AddTagFragment;
import com.example.todotask.TagsModel;
import com.example.todotask.Task;

import java.security.PublicKey;
import java.util.ArrayList;

public class CreateDatabase  extends SQLiteOpenHelper {
    private Context context;
    private static final String DATABASE_NAME = "hoicham.db";
    private static final int DATABASE_VERSION =1;
    private static final String TB_TASK = "TASK";
    private static final String TB_TAG = "TAG";

    private static final String TB_TASK_NAME = "TASK_NAME";
    private static final String TB_TASK_DATE = "TASK_DATE";
    private static final String TB_TASK_ID = "TASK_ID";

    private static final String TB_TASK_REPEAT="TASK_REPEAT";
    private static final String TB_TASK_START = "TASK_START";
    private static final String TB_TASK_END = "TASK_END";

    private static final String TB_TASK_TAG = "TAG_ID";
    private static final String TB_TASK_NOTIFICATION = "TASK_NOTIFICATION";
    public static final String TB_TAG_NAME = "TAG_NAME";
    public static final String TB_TAG_ID = "TAG_ID";
    public static final String TB_TAG_ICON = "TAG_ICON";
    public static final String TB_TAG_COLOR = "TAG_COLOR";
    //    public static int TB_TAG_ICON = Integer.parseInt("TAG_ICON");
//
//    public static int TB_TAG_COLOR = Integer.parseInt("TAG_COLOR");
    public CreateDatabase(@Nullable Context context) {

        super(context, DATABASE_NAME, null, DATABASE_VERSION);
        this.context = context;
    }



    @Override
    public void onCreate(SQLiteDatabase db) {

        String tbTask = "CREATE TABLE IF NOT EXISTS " + TB_TASK + "(" + TB_TASK_ID + " INTEGER PRIMARY KEY AUTOINCREMENT,  "
                + TB_TASK_NAME + " TEXT, " +TB_TASK_DATE + " TEXT, " + TB_TASK_START + " TEXT, " + TB_TASK_END + " TEXT, "
                + TB_TASK_REPEAT + " TEXT, "
                + TB_TASK_TAG + " INTEGER, " +
                TB_TASK_NOTIFICATION + " TEXT )";

        String tbTag = "CREATE TABLE IF NOT EXISTS " + TB_TAG + " ( " + TB_TAG_ID + " INTEGER PRIMARY KEY AUTOINCREMENT, "
                +TB_TAG_NAME + " TEXT, " + TB_TAG_ICON + " INTEGER, "
                +TB_TAG_COLOR + " INTEGER)";
        db.execSQL(tbTask);
        db.execSQL(tbTag);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("DROP TABLE IF EXISTS " + TB_TASK);
        db.execSQL("DROP TABLE IF EXISTS " + TB_TAG);
        onCreate(db);
    }
    //    public  SQLiteDatabase open(){
//        return this.getWritableDatabase();
//    }
    //tag

    public ArrayList<TagsModel> getAllTag(){
        ArrayList<TagsModel> list= new ArrayList<>();
        String sql = "SELECT * FROM " + TB_TAG;
        SQLiteDatabase db = this.getReadableDatabase();
        Cursor cursor = db.rawQuery(sql,null);
        if (cursor != null)
            while (cursor.moveToNext()){
                TagsModel tagsModel = new TagsModel(cursor.getInt(0),
                        cursor.getString(1), cursor.getInt(2),
                        cursor.getInt(3));
                list.add(tagsModel);
            }
        return list;
    }


    public void addTag(String Name, int Icon, int Color){
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues contentValues = new ContentValues();
        //  contentValues.put(TB_TAG_ID,Id);
        contentValues.put(TB_TAG_NAME,Name);
        contentValues.put(TB_TAG_ICON,Icon);
        contentValues.put(TB_TAG_COLOR,Color);
        long result =  db.insert(TB_TAG,null,contentValues);
        //CHI DE CHECK
        if (result == -1){
            Toast.makeText(context, "Failed", Toast.LENGTH_SHORT).show();
        }
        else {
            Toast.makeText(context, "Success", Toast.LENGTH_SHORT).show();
        }
        db.close();

    }
    //LMD
//    public void UpdateTag(int id, TagsModel tagsModel)
//    {
//        SQLiteDatabase db = this.getWritableDatabase();
//        ContentValues value = new ContentValues();
//        value.put(TB_TAG_ID, tagsModel.getIdTag());
//        value.put(TB_TAG_NAME, tagsModel.getTagContent());
//        value.put(TB_TAG_ICON, tagsModel.getLogoContent());
//        value.put(TB_TAG_COLOR,tagsModel.getLogoContent());
//        db.update(TB_TAG, value,TB_TAG_ID + "=?",
//                new String[]{String.valueOf(id)});
//        db.close();
//    }

    //
    public void UpdateTag (int id, String Name, int Icon, int Color ){
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues contentValues = new ContentValues();
        contentValues.put(TB_TAG_NAME, Name);
        contentValues.put(TB_TAG_ICON, Icon);
        contentValues.put(TB_TAG_COLOR, Color);
        long result = db.update(TB_TAG, contentValues, "TAG_ID = ?",new String[]{String.valueOf(id)});
        if (result == -1){
            Toast.makeText(context, "Failed", Toast.LENGTH_SHORT).show();
        }
        else {
            Toast.makeText(context, "Success", Toast.LENGTH_SHORT).show();
        }
        db.close();

    }
    public void deleteTag(int id)
    {
        SQLiteDatabase db = getWritableDatabase();
        String sql = "Delete From " + TB_TAG + " Where TAG_ID=" + id;
        db.delete(TB_TAG, TB_TAG_ID + "=?",new String[]{String.valueOf(id)});
        db.execSQL(sql);
        db.close();
    }

    public TagsModel getIdTag(int id){
        TagsModel tagsModel = new TagsModel();
        String sql = "SELECT * FROM " + TB_TAG + " WHERE TAG_ID = " + id;
        SQLiteDatabase db = this.getReadableDatabase();
        Cursor cursor = db.rawQuery(sql,null);
        if (cursor != null)
            while (cursor.moveToNext()){
                tagsModel = new TagsModel(cursor.getInt(0),
                        cursor.getString(1), cursor.getInt(2),
                        cursor.getInt(3));

            }
        return tagsModel;
    }
    //Task

    public ArrayList<Task> getAllTask(){
        ArrayList<Task> list= new ArrayList<>();
        String sql = "SELECT * FROM " + TB_TASK;
        SQLiteDatabase db = this.getReadableDatabase();
        Cursor cursor = db.rawQuery(sql,null);
        if (cursor != null)
            while (cursor.moveToNext()){
                Task task = new Task(cursor.getInt(0),
                        cursor.getString(1),cursor.getString(2),cursor.getString(3)
                        ,cursor.getString(4 ),cursor.getString(5), cursor.getInt(6),
                        cursor.getString(7));
                list.add(task);
            }
        return list;
    }
    public void addTask(String NameTask,
                        String Date, String TimeStart,
                        String TimeEnd, String Repeat,
                        int Tag, String Notification){
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues contentValues = new ContentValues();
        //  contentValues.put(TB_TAG_ID,Id);
        contentValues.put(TB_TASK_NAME,NameTask);
        contentValues.put(TB_TASK_DATE,Date);
        contentValues.put(TB_TASK_START,TimeStart);
        contentValues.put(TB_TASK_END,TimeEnd);
        contentValues.put(TB_TASK_REPEAT,Repeat);
        contentValues.put(TB_TASK_TAG, Tag);
        contentValues.put(TB_TASK_NOTIFICATION,Notification);

        long result =  db.insert(TB_TASK,null,contentValues);
        //CHI DE CHECK
        if (result == -1){
            Toast.makeText(context, "Failed", Toast.LENGTH_SHORT).show();
        }
        else {
            Toast.makeText(context, "Success", Toast.LENGTH_SHORT).show();
        }
        db.close();

    }
    public void UpdateTask(int id, Task task)
    {
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues contentValues = new ContentValues();
        //  contentValues.put(TB_TAG_ID,Id);
        contentValues.put(TB_TASK_NAME,task.getNameTask());
        contentValues.put(TB_TASK_DATE,task.getDate());
        contentValues.put(TB_TASK_START,task.getTimeStart());
        contentValues.put(TB_TASK_END,task.getTimeEnd());
        contentValues.put(TB_TAG_ID, task.getTag());
        contentValues.put(TB_TASK_NOTIFICATION,task.getNotification());

        long result = db.update(TB_TASK, contentValues, "TASK_ID = ?",new String[]{String.valueOf(id)});
        if (result == -1){
            Toast.makeText(context, "Failed", Toast.LENGTH_SHORT).show();
        }
        else {
            Toast.makeText(context, "Success", Toast.LENGTH_SHORT).show();
        }
        db.close();
    }
    public void deleteTask(int id)
    {
        SQLiteDatabase db = getWritableDatabase();
        String sql = "Delete From " + TB_TASK + " Where TASK_ID=" + id;
        db.delete(TB_TASK, TB_TASK_ID + "=?",new String[]{String.valueOf(id)});
        db.execSQL(sql);
        db.close();
    }

    //lay ngay

    public ArrayList<Task> getDateTask(String date){
        ArrayList<Task> list= new ArrayList<>();
        String sql = "SELECT * FROM " + TB_TASK + " WHERE TASK_DATE = '" + date + "'";
        SQLiteDatabase db = this.getReadableDatabase();
        Cursor cursor = db.rawQuery(sql,null);
        if (cursor != null)
            while (cursor.moveToNext()){
                Task task = new Task(cursor.getInt(0),
                        cursor.getString(1),cursor.getString(2),cursor.getString(3)
                        ,cursor.getString(4 ),cursor.getString(5), cursor.getInt(6),
                        cursor.getString(7));
                list.add(task);
            }
        return list;
    }


}