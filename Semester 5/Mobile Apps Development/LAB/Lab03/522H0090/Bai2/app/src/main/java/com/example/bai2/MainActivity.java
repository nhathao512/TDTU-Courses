package com.example.bai2;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {
    private TextView tv_content;
    private EditText et_content;
    private Button btn_Open;

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

        tv_content = findViewById(R.id.tv_content);
        et_content = findViewById(R.id.et_content);
        btn_Open = findViewById(R.id.btn_Open);

        btn_Open.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent url = new Intent(Intent.ACTION_VIEW, Uri.parse(
                        "https://" + et_content.getText().toString()));
                startActivity(url);
            }
        });
    }
}