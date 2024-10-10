package com.example.bai1.data;

import android.view.View;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.bai1.R;

public class StringViewHoder extends RecyclerView.ViewHolder {
    StringAdapter adapter;

    public StringViewHoder(@NonNull View itemView, StringAdapter adapter) {
        super(itemView);
        this.adapter = adapter;
    }

    public void setAdapter(int position) {
        String s = adapter.getData().get(position);
        TextView tvName = itemView.findViewById(R.id.tvName);
        tvName.setText(s);
    }
}

