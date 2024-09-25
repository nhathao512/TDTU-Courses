package com.example.bai2;

import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    private Button btnClickme;
    private EditText et_content;
    private TextView tv_content;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        btnClickme = findViewById(R.id.btn_Clickme);
        et_content = findViewById(R.id.et_content);
        tv_content = findViewById(R.id.tv_content);

        btnClickme.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String content = et_content.getText().toString().trim();
                if (content.isEmpty()) {
                    Toast.makeText(MainActivity.this, "Vui lòng nhập thông tin", Toast.LENGTH_SHORT).show();
                }
                else {
                    tv_content.setText(content);
                    et_content.getText().clear();
                }
            }
        });

        et_content.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {

            }

            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {
                String content = et_content.getText().toString().trim();
                if(content.equals("off")){
                    btnClickme.setEnabled(false);
                } else if (content.equals("on")) {
                    btnClickme.setEnabled(true);
                }
            }

            @Override
            public void afterTextChanged(Editable editable) {

            }
        });

    }
}