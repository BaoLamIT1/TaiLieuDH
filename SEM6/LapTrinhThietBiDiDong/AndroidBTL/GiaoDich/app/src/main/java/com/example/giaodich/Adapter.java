package com.example.giaodich;

import android.app.Activity;
import android.content.Context;
import android.graphics.Color;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;

public class Adapter extends BaseAdapter {
    private Context context;
    private List<GiaoDich> giaoDichList;

    public Adapter(Context context, List<GiaoDich> giaoDichList) {
        this.context = context;
        this.giaoDichList = giaoDichList;
    }

    @Override
    public int getCount() {
        return giaoDichList.size();
    }

    @Override
    public Object getItem(int position) {
        return giaoDichList.get(position);
    }

    @Override
    public long getItemId(int position) {
        return giaoDichList.get(position).getMaGiaoDich();
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        GiaoDich giaoDich = (GiaoDich) getItem(position);

        if (convertView == null) {
            convertView = LayoutInflater.from(context).inflate(R.layout.lst_item, parent, false);
        }

        TextView tvNoiDung = convertView.findViewById(R.id.txtName);

        if (giaoDich.isLoaiGiaoDich()) {
            tvNoiDung.setText("Số tiền đến từ " + giaoDich.getTenNguoi());
            tvNoiDung.setTextColor(Color.GREEN);
        } else {
            tvNoiDung.setText("Số tiền đi tới " + giaoDich.getTenNguoi());
            tvNoiDung.setTextColor(Color.RED);
        }
        TextView tvMucDich = convertView.findViewById(R.id.txtMucDich);
        TextView tvNgayThang = convertView.findViewById(R.id.txtDate);
        TextView tvSoTien = convertView.findViewById(R.id.txtMoney);
        tvMucDich.setText(giaoDich.getNoiDung());
        tvNgayThang.setText(giaoDich.getNgayThang());
        tvSoTien.setText(String.format("%,.0f VND", giaoDich.getSoTien()));


        return convertView;
    }
}
