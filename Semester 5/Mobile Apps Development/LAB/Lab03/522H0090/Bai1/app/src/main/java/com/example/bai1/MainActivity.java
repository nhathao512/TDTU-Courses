package com.example.bai1;

import android.content.Intent;
import android.os.Bundle;
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

    private Button btn_Login;
    private TextView tv_content;
    private EditText et_content;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        btn_Login = findViewById(R.id.btn_Login);
        tv_content = findViewById(R.id.tv_content);
        et_content = findViewById(R.id.et_content);

        btn_Login.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                if (validateInput()) {
                    String username = et_content.getText().toString().trim();

                    if (username.isEmpty()) {
                        Toast.makeText(MainActivity.this, "Vui lòng nhập email", Toast.LENGTH_SHORT).show();
                        et_content.requestFocus();
                    } else {
                        Intent intent = new Intent(MainActivity.this, MainActivity2.class);
                        intent.putExtra("Email", et_content.getText().toString());
                        startActivity(intent);
                        finish();
                    }
                }
            }
        });

        String ten = getIntent().getStringExtra("Tên");
        if (ten != null) {
            tv_content.setText("Hẹn gặp lại");
            et_content.setText(ten);
            et_content.setVisibility(View.VISIBLE);
            btn_Login.setVisibility(View.GONE);
        }
    }

    private boolean validateInput() {
        if (et_content.getText().toString().isEmpty()) {
            Toast.makeText(this, "Email không được để trống", Toast.LENGTH_SHORT).show();
            return false;
        }

        return true;
    }
}