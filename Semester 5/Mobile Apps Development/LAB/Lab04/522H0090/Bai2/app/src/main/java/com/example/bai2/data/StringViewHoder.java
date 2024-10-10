package com.example.bai2.data;

import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.bai2.R;

public class StringViewHoder extends RecyclerView.ViewHolder implements View.OnClickListener{
    StringAdapter adapter;

    public StringViewHoder(@NonNull View itemView, StringAdapter adapter) {
        super(itemView);
        this.adapter = adapter;
    }

    public void setAdapter(int position) {
        String s = adapter.getData().get(position);
        TextView tvItem = itemView.findViewById(R.id.tvItem);
        tvItem.setText(s);
        Button btnRemove = itemView.findViewById(R.id.btnRemove);
        btnRemove.setTag(position);
        btnRemove.setOnClickListener(this);
    }


    @Override
    public void onClick(View view) {
        int position = (int) view.getTag();
        adapter.getData().remove(position);
        adapter.notifyDataSetChanged();
    }
}
