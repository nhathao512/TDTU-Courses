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

public class MainActivity2 extends AppCompatActivity {
    private TextView tv_content;
    private EditText et_content;
    private Button btn_Save;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main2);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        tv_content = findViewById(R.id.tv_content);
        et_content = findViewById(R.id.et_content);
        btn_Save = findViewById(R.id.btn_Save);

        String email = getIntent().getStringExtra("Email");
        tv_content.setText("Xin chào," + email +". Vui lòng nhập tên");

        btn_Save.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (validateInput()) {
                    String username = et_content.getText().toString().trim();

                    if (username.isEmpty()) {
                        Toast.makeText(MainActivity2.this, "Vui lòng nhập tên", Toast.LENGTH_SHORT).show();
                        et_content.requestFocus();
                    }
                    Intent intent = new Intent(MainActivity2.this, MainActivity.class);
                    intent.putExtra("Tên", et_content.getText().toString());
                    startActivity(intent);
                    finish();
                }
            }
        });
    }

    private boolean validateInput() {
        if (et_content.getText().toString().isEmpty()) {
            Toast.makeText(this, "Tên không được để trống", Toast.LENGTH_SHORT).show();
            return false;
        }

        return true;
    }
}