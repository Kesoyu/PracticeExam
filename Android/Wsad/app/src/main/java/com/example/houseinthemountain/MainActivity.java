package com.example.houseinthemountain;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    Button btn_subbmit;
    EditText editTextEmail, editTextPassword1, editTextPassword2;
    TextView textViewAn;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        btn_subbmit = findViewById(R.id.buttonSubmit);
        editTextEmail = findViewById(R.id.editTextEmail);
        editTextPassword1 = findViewById(R.id.password1);
        editTextPassword2 = findViewById(R.id.password2);
        textViewAn = findViewById(R.id.textViewAnchor);
        btn_subbmit.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String email = String.valueOf(editTextEmail.getText());
                if(email.contains("@")){
                    String pass1= String.valueOf(editTextPassword1.getText());
                    String pass2= String.valueOf(editTextPassword2.getText());
                    if(pass1.equals(pass2)){
                        textViewAn.setText("Witaj "+email);
                    }
                    else {
                        textViewAn.setText("hasła się różnią");
                    }
                }
                else{
                    textViewAn.setText("Nieprawidłowy adres email");
                }
            }
        });
    }
}