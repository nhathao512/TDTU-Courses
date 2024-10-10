package com.example.bai3;

import android.view.View;
import android.widget.CheckBox;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

public class ViewHolder extends RecyclerView.ViewHolder {
    TextView tvPhone;
    CheckBox cbPhone;

    public ViewHolder(@NonNull View itemView) {
        super(itemView);
        tvPhone = itemView.findViewById(R.id.tvPhone);
        cbPhone = itemView.findViewById(R.id.cbPhone);
    }
}
