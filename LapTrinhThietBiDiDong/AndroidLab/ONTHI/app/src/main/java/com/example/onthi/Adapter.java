package com.example.onthi;

import android.app.Activity;
import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.CheckBox;
import android.widget.Filter;
import android.widget.Filterable;
import android.widget.TextView;

import java.util.ArrayList;

public class Adapter extends BaseAdapter implements Filterable {

    public ArrayList<Taxi_MaDe> data;
    private Activity context;
    private  ArrayList<Taxi_MaDe> databackup;

    private LayoutInflater inflater;

    private TextView soxe;
    private  TextView quangduong;
    private TextView tongtien;
    public  Adapter(ArrayList<Taxi_MaDe> data, Activity context){
        this.data = data;
        this.context = context;//////
        this.inflater = (LayoutInflater) context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
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
        return data.get(position).getMaXe();
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        View  v = convertView;
        if(v==null)
            v = inflater.inflate(R.layout.list_view,null);
        soxe = v.findViewById(R.id.txtSoxe);
        quangduong = v.findViewById(R.id.txtQD);
        tongtien = v.findViewById(R.id.txtTongtien);
        soxe.setText(data.get(position).getSoXe());
        quangduong.setText("Quang Duong" + String.valueOf(data.get(position).getQuangDuong()));
        tongtien.setText(String.valueOf(data.get(position).tongTien(data.get(position).getMaXe())));
        return v;
    }

    @Override
    public Filter getFilter() {
        Filter f = new Filter() {
            @Override
            protected FilterResults performFiltering(CharSequence constraint) {
                FilterResults fr = new FilterResults();
                // luu tamm dât và databackup
                if(databackup==null){
                    databackup = new ArrayList<>(data);
                }
                //Neu chuoi de filter la rong thi khoi phuc du lieu
                if(constraint == null || constraint.length()==0){
                    fr.count = databackup.size();
                    fr.values = databackup;
                }
                // Neu khong rong thi thuc hien fiter

                else {
                    ArrayList<Taxi_MaDe> newdata = new ArrayList<>();
                    for(Taxi_MaDe c: databackup){
                        if(c.getSoXe().toLowerCase().contains(constraint.toString().toLowerCase()))
                            newdata.add(c);
                        fr.count= newdata.size();
                        fr.values = newdata;
                    }

                }
                return  fr;
            }

            @Override
            protected void publishResults(CharSequence constraint, FilterResults results) {
                data = new ArrayList<Taxi_MaDe>();
                ArrayList<Taxi_MaDe> tmp = (ArrayList<Taxi_MaDe>)results.values;
                for(Taxi_MaDe c:tmp){
                    data.add(c);
                    notifyDataSetChanged();
                }
            }
        };
        return  f;
    }
}
