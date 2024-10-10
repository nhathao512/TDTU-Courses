package com.example.bai2.data;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.bai2.R;

import java.util.List;

public class StringAdapter extends RecyclerView.Adapter<StringViewHoder> {
    List<String> data;
    LayoutInflater inflater;
    Context context;

    public StringAdapter(Context context, List<String> data) {
        this.data = data;
        inflater = LayoutInflater.from(context);
        this.context = context;
    }

    @NonNull
    @Override
    public StringViewHoder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = inflater.inflate(R.layout.list_view_remove, parent, false);
        return new StringViewHoder(view, this);
    }

    @Override
    public void onBindViewHolder(@NonNull StringViewHoder holder, int position) {
        int position2 = position;
        holder.itemView.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Toast.makeText(StringAdapter.this.context, data.get(position2), Toast.LENGTH_LONG).show();
            }
        });
        holder.setAdapter(position);
    }


    public List<String> getData() {
        return data;
    }

    @Override
    public int getItemCount() {
        return data.size();
    }
}
