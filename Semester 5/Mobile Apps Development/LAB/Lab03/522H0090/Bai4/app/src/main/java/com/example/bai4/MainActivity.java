package com.example.bai4;

import android.content.Intent;
import android.graphics.Bitmap;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import com.google.android.material.imageview.ShapeableImageView;

public class MainActivity extends AppCompatActivity {
    private static final int EDIT_PROFILE_REQUEST = 1;
    private static final int EDIT_PROFILE_REQUEST_CODE = 1;
    private TextView tvTitle, tvIcon ,tvMajor, tvName, tvPhone, tvEmail, tvAddress, tvHomepage;
    private ShapeableImageView imgAvatar;
    private Bitmap avatarBitmap;

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

        tvIcon = findViewById(R.id.tvIcon);
        tvTitle = findViewById(R.id.tvTitle);
        tvMajor = findViewById(R.id.tvMajor);
        tvName = findViewById(R.id.tvName);
        tvPhone = findViewById(R.id.tvPhone);
        tvEmail = findViewById(R.id.tvEmail);
        tvAddress = findViewById(R.id.tvAddress);
        tvHomepage = findViewById(R.id.tvHomepage);
        imgAvatar = findViewById(R.id.imgAvatar);

        tvIcon.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(MainActivity.this, MainActivity2.class);
                intent.putExtra("name", tvName.getText().toString());
                intent.putExtra("major", tvMajor.getText().toString());
                intent.putExtra("phone", tvPhone.getText().toString());
                intent.putExtra("email", tvEmail.getText().toString());
                intent.putExtra("address", tvAddress.getText().toString());
                intent.putExtra("homepage", tvHomepage.getText().toString());
                startActivityForResult(intent, EDIT_PROFILE_REQUEST_CODE);
            }
        });
    }

    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        super.onActivityResult(requestCode, resultCode, data);

        if (requestCode == EDIT_PROFILE_REQUEST && resultCode == RESULT_OK && data != null) {
            String name = data.getStringExtra("name");
            String major = data.getStringExtra("major");
            String phone = data.getStringExtra("phone");
            String email = data.getStringExtra("email");
            String address = data.getStringExtra("address");
            String homepage = data.getStringExtra("homepage");

            String formattedName = name.toLowerCase().replaceAll(" ", "_");
            tvTitle.setText(formattedName);
            tvName.setText(name);
            tvMajor.setText(major);
            tvPhone.setText(phone);
            tvEmail.setText(email);
            tvAddress.setText(address);
            tvHomepage.setText(homepage);

            Bitmap avatarBitmap = data.getParcelableExtra("avatar");
            if (avatarBitmap != null) {
                imgAvatar.setImageBitmap(avatarBitmap);
            }
        }
    }
}