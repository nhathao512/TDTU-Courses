package com.example.bai2;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    private CheckBox cbAndroid, cbIos, cbWin, cbRim;
    private Button btnClick, btnNext;
    private TextView tvResults1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        cbAndroid = findViewById(R.id.cbAndroid);
        cbIos = findViewById(R.id.cbIos);
        cbWin = findViewById(R.id.cbWin);
        cbRim = findViewById(R.id.cbRim);
        btnClick = findViewById(R.id.btnClick);
        btnNext = findViewById(R.id.btnNext);
        tvResults1 = findViewById(R.id.tvResults1);

        btnClick.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                displayResults();
            }
        });

        btnNext.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(MainActivity.this, MainActivity2.class);
                startActivity(intent);
                finish();
            }
        });
    }

    private void displayResults() {
        StringBuilder result = new StringBuilder("The following were selected...\n");
        result.append("Android: ").append(cbAndroid.isChecked()).append("\n");
        result.append("iOS: ").append(cbIos.isChecked()).append("\n");
        result.append("Windows: ").append(cbWin.isChecked()).append("\n");
        result.append("RIM: ").append(cbRim.isChecked());

        tvResults1.setText(result.toString());
    }
}