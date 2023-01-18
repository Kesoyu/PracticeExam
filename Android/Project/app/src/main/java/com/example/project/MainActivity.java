package com.example.project;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.SwitchCompat;

import android.annotation.SuppressLint;
import android.graphics.Color;
import android.graphics.drawable.Drawable;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.LinearLayout;

public class MainActivity extends AppCompatActivity {
    SwitchCompat switchCompat;
    LinearLayout widget;
    Button btn_left, btn_right;
    ImageView imageViewKotki;

    Integer[] array = {R.drawable.kot1,R.drawable.kot2,R.drawable.kot3,R.drawable.kot4};
    int kotkiId=0;
    boolean switchCounter=true;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        switchCompat = findViewById(R.id.switchColourBackground);
        widget = findViewById(R.id.widget);
        btn_left = findViewById(R.id.buttonPreview);
        imageViewKotki = findViewById(R.id.imageViewKotki);
        btn_right = findViewById(R.id.buttonNext);
        switchCompat.setOnClickListener(new View.OnClickListener() {
            @SuppressLint("ResourceAsColor")
            @Override
            public void onClick(View view) {
                if(switchCounter){
                    widget.setBackgroundResource(R.color.black);
                }
                else {
                    widget.setBackgroundResource(R.color.white);
                }
                switchCounter = !switchCounter;
            }
        });
        btn_right.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                changePhoto(1);
            }
        });
        btn_left.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                changePhoto(-1);
            }
        });
    }
    void changePhoto(int number){
        kotkiId+=number;
        if(kotkiId<0){
            kotkiId=array.length-1;
        }

        if(kotkiId>=array.length){
            kotkiId=0;
        }
        imageViewKotki.setImageResource(array[kotkiId]);
    }
}