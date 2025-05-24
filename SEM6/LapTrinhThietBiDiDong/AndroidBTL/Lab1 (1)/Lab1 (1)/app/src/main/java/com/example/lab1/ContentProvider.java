package com.example.lab1;

import android.app.Activity;
import android.content.ContentResolver;
import android.content.ContentValues;
import android.database.Cursor;
import android.net.Uri;
import android.provider.ContactsContract;

import java.util.ArrayList;

public class ContentProvider {
    public Activity activity;

    public ContentProvider(Activity activity) {
        this.activity = activity;
    }

    public ArrayList<Contact> getAllContact(){
        ArrayList<Contact> listContact = new ArrayList<>();
        String[] projection = new String[]{
                ContactsContract.CommonDataKinds.Phone._ID,
                ContactsContract.CommonDataKinds.Phone.DISPLAY_NAME,
                ContactsContract.CommonDataKinds.Phone.NUMBER,
                ContactsContract.CommonDataKinds.Phone.PHOTO_THUMBNAIL_URI
        };
        Cursor cursor = activity.getContentResolver().query(
                ContactsContract.CommonDataKinds.Phone.CONTENT_URI,
                projection,null,null,null);

        if(cursor.moveToFirst()){
            do{
                Contact c = new Contact(cursor.getInt(0),cursor.getString(1),
                        cursor.getString(2),
                        cursor.getString(3));
                listContact.add(c);
            }while (cursor.moveToNext());

        }
        cursor.close();
        return listContact;
    }

    public ArrayList<Contact> addContact(String displayName, String phoneNumber) {
        ArrayList<Contact> contactsList = new ArrayList<>();

        try {
            ContentResolver contentResolver = activity.getContentResolver();

            // Tạo một dòng mới trong danh bạ
            ContentValues values = new ContentValues();
            values.put(ContactsContract.RawContacts.ACCOUNT_TYPE, (String) null);
            values.put(ContactsContract.RawContacts.ACCOUNT_NAME, (String) null);
            Uri rawContactUri = contentResolver.insert(ContactsContract.RawContacts.CONTENT_URI, values);
            long rawContactId = Long.parseLong(rawContactUri.getLastPathSegment());

            // Thêm tên của liên hệ
            values.clear();
            values.put(ContactsContract.Data.RAW_CONTACT_ID, rawContactId);
            values.put(ContactsContract.Data.MIMETYPE, ContactsContract.CommonDataKinds.StructuredName.CONTENT_ITEM_TYPE);
            values.put(ContactsContract.CommonDataKinds.StructuredName.DISPLAY_NAME, displayName);
            contentResolver.insert(ContactsContract.Data.CONTENT_URI, values);

            // Thêm số điện thoại của liên hệ
            values.clear();
            values.put(ContactsContract.Data.RAW_CONTACT_ID, rawContactId);
            values.put(ContactsContract.Data.MIMETYPE, ContactsContract.CommonDataKinds.Phone.CONTENT_ITEM_TYPE);
            values.put(ContactsContract.CommonDataKinds.Phone.NUMBER, phoneNumber);
            contentResolver.insert(ContactsContract.Data.CONTENT_URI, values);

            // Lấy tất cả các liên hệ sau khi đã thêm liên hệ mới
            contactsList = getAllContact();
        } catch (Exception e) {
            e.printStackTrace();
            // Xử lý ngoại lệ nếu có
        }

        return contactsList;
    }
}
