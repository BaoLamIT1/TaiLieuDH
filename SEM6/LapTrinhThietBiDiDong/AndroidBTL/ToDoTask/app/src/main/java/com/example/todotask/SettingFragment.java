package com.example.todotask;

import android.app.DatePickerDialog;
import android.app.TimePickerDialog;
import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.AutoCompleteTextView;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TimePicker;
import android.widget.Toast;

import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

import com.google.android.material.button.MaterialButton;
import com.google.android.material.floatingactionbutton.FloatingActionButton;

import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Locale;

public class SettingFragment extends Fragment {

    //GoogleSignInOptions gso;
    //GoogleSignInClient gsc;
    //ImageView ggbtn;

    //ImageView fb;


    private AutoCompleteTextView dropDownMenuRepeat;
    //    String[] options = new String[]{"Do not repeat", "Daily","Weekly","Monthly","Annually"};
    ArrayAdapter<String> adapterItems ;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {

        View v = inflater.inflate(R.layout.fragment_setting, container, false);
        // Ánh xạ các thành phần giao diện từ layout XML (nếu cần)

        dropDownMenuRepeat = v.findViewById(R.id.set_language);
        adapterItems = new ArrayAdapter<>(getContext(), android.R.layout.simple_dropdown_item_1line,
                new String[]{"English", "Vietnamese", "Chinese"});
        dropDownMenuRepeat.setAdapter(adapterItems);
        /*fb.findViewById(R.id.facebook);
        fb.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

            }
        });*/
        /*ggbtn=v.findViewById(R.id.google);
        gso = new GoogleSignInOptions.Builder(GoogleSignInOptions.DEFAULT_SIGN_IN).requestEmail().build();
        gsc = GoogleSignIn.getClient(requireContext(), gso);
        ggbtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                signIn();
            }
        });*/
        return v;

    }
    /*void signIn(){
        Intent signInIntent = gsc.getSignInIntent();
        startActivityForResult(signInIntent, 1000);
    }

    @Override
    public void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        if(requestCode==1000){
            Task<GoogleSignInAccount> task = GoogleSignIn.getSignedInAccountFromIntent(data);
            try {
                task.getResult(ApiException.class);
                navigateToSecondActivity();
            }
            catch (ApiException e){
                Toast.makeText(getActivity().getApplicationContext(), "Something went wrong", Toast.LENGTH_SHORT).show();
            }
        }
    }
    void navigateToSecondActivity(){
        getActivity().finish();
        Intent intent = new Intent(getActivity(), SecondFragment.class);
        startActivity(intent);
    }*/


}




