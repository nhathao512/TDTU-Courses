package com.example.bai4;

import android.Manifest;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.graphics.Bitmap;
import android.os.Bundle;
import android.provider.MediaStore;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;
import androidx.core.content.ContextCompat;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import com.google.android.material.imageview.ShapeableImageView;

public class MainActivity2 extends AppCompatActivity {

    private static final int EDIT_PROFILE_REQUEST_CODE = 1;
    private static final int CAMERA_REQUEST_CODE = 2;
    private EditText etMajor, etName, etPhone, etEmail, etAddress, etHomepage;
    private ShapeableImageView shapeableImageView;
    private ImageButton btnCamera;
    private Button btnSave;
    private Bitmap avatarBitmap;
    private TextView tvTitle;

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

        etMajor = findViewById(R.id.etMajor);
        etName = findViewById(R.id.etName);
        etPhone = findViewById(R.id.etPhone);
        etEmail = findViewById(R.id.etEmail);
        etAddress = findViewById(R.id.etAddress);
        etHomepage = findViewById(R.id.etHomepage);
        shapeableImageView = findViewById(R.id.shapeableImageView);
        btnCamera = findViewById(R.id.btnCamera);
        btnSave = findViewById(R.id.btnSave);
        tvTitle = findViewById(R.id.tvTitle);

        Intent intent = getIntent();
        etName.setText(intent.getStringExtra("name"));
        etMajor.setText(intent.getStringExtra("major"));
        etPhone.setText(intent.getStringExtra("phone"));
        etEmail.setText(intent.getStringExtra("email"));
        etAddress.setText(intent.getStringExtra("address"));
        etHomepage.setText(intent.getStringExtra("homepage"));
        tvTitle.setText(intent.getStringExtra("name").replaceAll(" ", "_"));

        btnSave.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent resultIntent = new Intent();
                resultIntent.putExtra("name", etName.getText().toString());
                resultIntent.putExtra("major", etMajor.getText().toString());
                resultIntent.putExtra("phone", etPhone.getText().toString());
                resultIntent.putExtra("email", etEmail.getText().toString());
                resultIntent.putExtra("address", etAddress.getText().toString());
                resultIntent.putExtra("homepage", etHomepage.getText().toString());

                if (avatarBitmap != null) {
                    resultIntent.putExtra("avatar", avatarBitmap);
                }

                setResult(RESULT_OK, resultIntent);
                finish();
            }
        });

        btnCamera.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (ContextCompat.checkSelfPermission(MainActivity2.this, android.Manifest.permission.CAMERA) != PackageManager.PERMISSION_GRANTED) {
                    ActivityCompat.requestPermissions(MainActivity2.this, new String[]{Manifest.permission.CAMERA}, CAMERA_REQUEST_CODE);
                } else {
                    Intent cameraIntent = new Intent(MediaStore.ACTION_IMAGE_CAPTURE);
                    startActivityForResult(cameraIntent, CAMERA_REQUEST_CODE);

                }
            }
        });
    }

    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        super.onActivityResult(requestCode, resultCode, data);

        if (requestCode == CAMERA_REQUEST_CODE && resultCode == RESULT_OK) {
            if (data != null && data.getExtras() != null) {
                avatarBitmap = (Bitmap) data.getExtras().get("data");
                shapeableImageView.setImageBitmap(avatarBitmap);
            }
        }
    }
}