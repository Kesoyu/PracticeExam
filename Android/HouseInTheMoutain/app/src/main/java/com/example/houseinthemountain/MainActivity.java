package com.example.houseinthemountain;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    TextView textView_likeNumber;
    Button btn_like, btn_delete;
    String likeTextAsset = " polubień";
    int likeNumber = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        btn_like = findViewById(R.id.likeButton);
        btn_delete = findViewById(R.id.deleteButton);
        textView_likeNumber = findViewById((R.id.textView_likeNumber));
        btn_like.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                likeNumber++;
                updateLikeTextView();
            }
        });
        btn_delete.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(likeNumber>0)
                    likeNumber--;
                updateLikeTextView();
            }
        });

    }
    public void updateLikeTextView(){
        textView_likeNumber.setText(likeNumber+likeTextAsset);
    };
}