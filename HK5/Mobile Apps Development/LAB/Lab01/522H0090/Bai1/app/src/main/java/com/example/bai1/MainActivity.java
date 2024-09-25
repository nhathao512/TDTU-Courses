package com.example.bai1;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.EditText;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    EditText userET, passET;
    CheckBox remember_me;
    Button btn_login;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        userET = findViewById(R.id.userET);
        passET = findViewById(R.id.passET);
        remember_me = findViewById(R.id.remember_me);
        btn_login = findViewById(R.id.btn_login);

        btn_login.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String username = userET.getText().toString().trim();
                String password = passET.getText().toString().trim();

                if (username.isEmpty()) {
                    Toast.makeText(MainActivity.this, "Vui lòng nhập tên đăng nhập", Toast.LENGTH_SHORT).show();
                    userET.requestFocus();
                }
                else if (password.isEmpty()) {
                    Toast.makeText(MainActivity.this, "Vui lòng nhập mật khẩu", Toast.LENGTH_SHORT).show();
                    passET.requestFocus();
                }
                else if (username.equals("admin") && password.equals("123456")) {
                    Intent intent = new Intent(MainActivity.this, MainActivity2.class);
                    startActivity(intent);
                    finish();
                }
                else {
                    Toast.makeText(MainActivity.this, "Tên đăng nhập hoặc mật khẩu không chính xác", Toast.LENGTH_SHORT).show();
                    passET.requestFocus();
                }
            }
        });

        remember_me.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton compoundButton, boolean b) {
                String msg = "Bạn sẽ cần phải đăng nhập trong các lần tiếp theo";
                if(remember_me.isChecked()){
                    msg = "Tài khoản của bạn sẽ được ghi nhớ";
                }
                Toast.makeText(MainActivity.this, msg, Toast.LENGTH_SHORT).show();
            }
        });

    }
}