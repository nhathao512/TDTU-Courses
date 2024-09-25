package com.example.bai2;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.RatingBar;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.Random;

public class MainActivity extends AppCompatActivity {

    private TextView tvFollower, tvFollowing;
    private Button btnFollow;
    private boolean isFollowing = false;
    private int followersCount;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        tvFollower = findViewById(R.id.tvFollower);
        tvFollowing = findViewById(R.id.tvFollowing);
        btnFollow = findViewById(R.id.btnFollow);
        RatingBar ratingBar = findViewById(R.id.ratingBar);

        Random random = new Random();
        followersCount = random.nextInt(9901) + 100;
        int followingCount = random.nextInt(9901) + 100;

        tvFollower.setText(String.valueOf(followersCount));
        tvFollowing.setText(String.valueOf(followingCount));

        ratingBar.setRating(4.5f);
        ratingBar.setIsIndicator(true);

        btnFollow.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (isFollowing) {
                    followersCount--;
                    tvFollower.setText(String.valueOf(followersCount));
                    btnFollow.setText("FOLLOW");
                    isFollowing = false;
                    Toast.makeText(MainActivity.this, "Unfollowed", Toast.LENGTH_SHORT).show();
                } else {
                    followersCount++;
                    tvFollower.setText(String.valueOf(followersCount));
                    btnFollow.setText("UNFOLLOW");
                    isFollowing = true;
                    Toast.makeText(MainActivity.this, "Followed", Toast.LENGTH_SHORT).show();
                }
            }
        });

    }
}