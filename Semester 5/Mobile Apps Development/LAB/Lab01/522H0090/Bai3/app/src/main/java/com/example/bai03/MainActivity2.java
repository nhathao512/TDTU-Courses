package com.example.bai03;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity2 extends AppCompatActivity {

    TextView tvName, tvGender, tvYeuThich, tvEmail, tvAddress, tvHobbies, tvSwimSkill, tvToeicScore, tvEmailNotification;
    Button btnCloseApp;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main2);

        tvName = findViewById(R.id.tvName);
        tvGender = findViewById(R.id.tvGender);
        tvYeuThich = findViewById(R.id.tvYeuThich);
        tvEmail = findViewById(R.id.tvEmail);
        tvAddress = findViewById(R.id.tvAddress);
        tvHobbies = findViewById(R.id.tvHobbies);
        tvSwimSkill = findViewById(R.id.tvSwimSkill);
        tvToeicScore = findViewById(R.id.tvToeicScore);
        tvEmailNotification = findViewById(R.id.tvEmailNotification);
        btnCloseApp = findViewById(R.id.btnCloseApp);

        String fullName = getIntent().getStringExtra("Họ và tên");
        String gioiTinh = getIntent().getStringExtra("Giới tính");
        String yeuThich = getIntent().getStringExtra("Yêu thích");
        String email = getIntent().getStringExtra("Email");
        String address = getIntent().getStringExtra("Địa chỉ");
        String soThich = getIntent().getStringExtra("Sở thích");
        int swimmingAbility = getIntent().getIntExtra("Khả năng bơi", 0);
        int toeicScore = getIntent().getIntExtra("Điểm TOEIC", 0);
        String nhanTB = getIntent().getStringExtra("Nhận thông báo");

        // Display data

        tvName.setText(fullName);
        tvGender.setText(gioiTinh);
        tvYeuThich.setText(yeuThich);
        tvHobbies.setText(yeuThich);
        tvEmail.setText(email);
        tvAddress.setText(address);
        tvHobbies.setText(soThich);
        tvSwimSkill.setText(String.valueOf(swimmingAbility));
        tvToeicScore.setText(String.valueOf(toeicScore));
        tvHobbies.setText(soThich);
        tvEmailNotification.setText(nhanTB);

        btnCloseApp.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finishAffinity();
            }
        });

    }
}