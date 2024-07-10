package com.example.kiemtra;

import android.app.Activity;
import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;

import java.util.ArrayList;

public class Adapter extends BaseAdapter {

    private TextView txtSBD;
    private  TextView txtHoten;

    private TextView txtTongDiem;
    private LayoutInflater inflater;

    private ArrayList<ThiSinh> data;
    private Activity context;

    public Adapter(ArrayList<ThiSinh> data, Activity activity){
        this.data = data;
        this.context = activity;
        this.inflater = (LayoutInflater) activity.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
    }




    @Override
    public int getCount() {
        return data.size();
    }

    @Override
    public Object getItem(int position) {
        return data.get(position);
    }

    @Override
    public long getItemId(int position) {
        return 0;
    }

    @Override
    public View getView(int position, View view, ViewGroup viewGroup) {
        View v = view;
        if(v==null)
            v = inflater.inflate(R.layout.thisinh, null);
        txtSBD= v.findViewById(R.id.txtSBD);
        txtSBD.setText(data.get(position).getSBD());

        txtHoten = v.findViewById(R.id.txtHoten);
        txtHoten.setText(data.get(position).getHoten());

        txtTongDiem = v.findViewById(R.id.txtTongdiem);
        txtTongDiem.setText(""+data.get(position).TongDiem());
        return v;
    }
}
