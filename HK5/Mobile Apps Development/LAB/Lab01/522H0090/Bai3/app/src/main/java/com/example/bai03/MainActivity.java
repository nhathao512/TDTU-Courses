package com.example.bai03;

import android.content.Intent;
import android.os.Bundle;
import android.text.InputType;
import android.util.Patterns;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.RatingBar;
import android.widget.SeekBar;
import android.widget.Switch;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    EditText etFullName, etEmail, etAddress;
    RadioButton radioGTNam, radioGTNu, radioYTNam, radioYTNu, radioYTCaHai;
    RadioGroup radio1, radio2;
    CheckBox chkBongDa, chkBoiLoi, chkChayBo;
    RatingBar ratingBar;
    SeekBar seekBar;
    Switch switchTBao;
    Button btnLuuTT;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        etFullName = findViewById(R.id.etFullName);
        etEmail = findViewById(R.id.etEmail);
        etAddress = findViewById(R.id.etAddress);
        radioGTNam = findViewById(R.id.radioGTNam);
        radioGTNu = findViewById(R.id.radioGTNu);
        radioYTNam = findViewById(R.id.radioYTNam);
        radioYTNu = findViewById(R.id.radioYTNu);
        radioYTCaHai = findViewById(R.id.radioYTCaHai);
        ratingBar = findViewById(R.id.ratingBar);
        chkBoiLoi = findViewById(R.id.chkBoiLoi);
        chkChayBo = findViewById(R.id.chkChayBo);
        chkBongDa = findViewById(R.id.chkBongDa);
        seekBar = findViewById(R.id.seekBar);
        switchTBao = findViewById(R.id.switchTBao);
        btnLuuTT = findViewById(R.id.btnLuuTT);
        radio1 = findViewById(R.id.radio1);
        radio2 = findViewById(R.id.radio2);


        etFullName.setInputType(InputType.TYPE_CLASS_TEXT | InputType.TYPE_TEXT_FLAG_CAP_WORDS);

        etEmail.setInputType(InputType.TYPE_CLASS_TEXT | InputType.TYPE_TEXT_VARIATION_EMAIL_ADDRESS);

        seekBar.setOnSeekBarChangeListener(new SeekBar.OnSeekBarChangeListener() {
            @Override
            public void onProgressChanged(SeekBar seekBar, int progress, boolean fromUser) {
                int value = progress * 5;
                seekBar.setContentDescription(String.valueOf(value));
            }

            @Override
            public void onStartTrackingTouch(SeekBar seekBar) { }

            @Override
            public void onStopTrackingTouch(SeekBar seekBar) { }
        });

        btnLuuTT.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (validateInput()) {
                    Intent intent = new Intent(MainActivity.this, MainActivity2.class);

                    RadioButton selectedGender = findViewById(radio1.getCheckedRadioButtonId());
                    intent.putExtra("Giới tính", selectedGender.getText().toString());

                    int selectedPreferenceId = radio2.getCheckedRadioButtonId();
                    RadioButton selectedPreference = findViewById(selectedPreferenceId);

                    if (selectedPreference == radioYTCaHai) {
                        intent.putExtra("Yêu thích", "Nam và Nữ");
                    } else {
                        intent.putExtra("Yêu thích", selectedPreference.getText().toString());
                    }

                    intent.putExtra("Họ và tên", etFullName.getText().toString());

                    intent.putExtra("Email", etEmail.getText().toString());

                    intent.putExtra("Địa chỉ", etAddress.getText().toString());

                    List<String> hobbies = new ArrayList<>();
                    if (chkBongDa.isChecked()) {
                        hobbies.add("Bóng đá");
                    }
                    if (chkBoiLoi.isChecked()) {
                        hobbies.add("Bơi lội");
                    }
                    if (chkChayBo.isChecked()) {
                        hobbies.add("Chạy bộ");
                    }
                    String hobbiesString = hobbies.isEmpty() ? "Không có sở thích" : String.join(", ", hobbies);
                    intent.putExtra("Sở thích", hobbiesString);

                    intent.putExtra("Khả năng bơi", (int) ratingBar.getRating());

                    int toeicScore = seekBar.getProgress() * 5;
                    intent.putExtra("Điểm TOEIC", toeicScore);

                    String notificationStatus = switchTBao.isChecked() ? "Có" : "Không";
                    intent.putExtra("Nhận thông báo", notificationStatus);

                    startActivity(intent);
                }
            }
        });
    }
    private boolean validateInput() {
        if (etFullName.getText().toString().isEmpty()) {
            Toast.makeText(this, "Họ và tên không được để trống", Toast.LENGTH_SHORT).show();
            return false;
        }
        else if (etEmail.getText().toString().isEmpty()) {
            Toast.makeText(this, "Email không được để trống", Toast.LENGTH_SHORT).show();
            return false;
        }
        else if (etAddress.getText().toString().isEmpty()) {
            Toast.makeText(this, "Địa chỉ không được để trống", Toast.LENGTH_SHORT).show();
            return false;
        }
        return true;
    }
}