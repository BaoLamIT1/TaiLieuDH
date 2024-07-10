package com.example.lab1;

import android.app.Activity;
import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.EditText;
import android.widget.Filter;
import android.widget.ImageButton;
import android.widget.ImageView;

import java.util.ArrayList;

public class Adapter extends BaseAdapter {
    public void setData(ArrayList<Contact> data){
        this.data = data;
    }
    //Nguồn dữ liệu cho adaoter
    private ArrayList<Contact> data;
    private ArrayList<Contact> databackup;
    //Ngữ cảnh của ứng dụng
    private Activity context;
    //Đối tượng để phân tích layout
    private LayoutInflater inflater;
    public Adapter(){}

    public Adapter(ArrayList<Contact> data,  Activity activity) {
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
        return data.get(position).getId();
    }

    @Override
    public View getView(int position, View view, ViewGroup viewGroup) {
        View v = view;
        if(v==null)
            v = inflater.inflate(R.layout.contact, null);
        ImageView imgprofile = v.findViewById(R.id.img);
        EditText txtName = v.findViewById(R.id.txtName);
        txtName.setText(data.get(position).getName());
        EditText txtPhone = v.findViewById(R.id.txtPhone);
        txtPhone.setText(data.get(position).getPhone());
        return v;
    }

    public Filter getFilter(){
        Filter f = new Filter() {
            @Override
            protected FilterResults performFiltering(CharSequence constraint) {
                FilterResults fr = new FilterResults();
                //Backup dữ liêu; tạm lưu data vào databackup
                if(databackup == null)
                    databackup = new ArrayList<>(data);
                    //Nếu chuổi filter là rỗng thì khôi phục dữ liệu
                if(constraint == null || constraint.length() == 0){
                    fr.count = databackup.size();
                    fr.values = databackup;
                }else{
                        ArrayList<Contact> newdata = new ArrayList<>();
                        for(Contact c : databackup){
                            if(c.getName().toLowerCase().contains(constraint
                                    .toString().toLowerCase())){
                                newdata.add(c);
                            }
                        }
                        fr.count = newdata.size();
                        fr.values = newdata;
                    }

               return fr;
            }

            @Override
            protected void publishResults(CharSequence constraint, FilterResults results) {
                data =  new ArrayList<Contact>();
                 ArrayList<Contact> tmp = (ArrayList<Contact>)results.values;
                 for(Contact c:tmp){
                     data.add(c);
                 }
                 notifyDataSetChanged();
            }
        };
        return f;
    }

}
