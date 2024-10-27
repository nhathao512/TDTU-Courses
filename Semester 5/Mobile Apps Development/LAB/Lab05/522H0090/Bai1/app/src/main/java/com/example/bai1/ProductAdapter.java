package com.example.bai1;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.List;

public class ProductAdapter extends RecyclerView.Adapter<ProductHolder> {
    List<ProductInfor> products;
    LayoutInflater inflater;
    public ProductAdapter(Context context, List<ProductInfor> products) {
        inflater = LayoutInflater.from(context);
        this.products = products;
    }

    @NonNull
    @Override
    public ProductHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View v = inflater.inflate(R.layout.list_product_item, parent, false);
        return new ProductHolder(v, this);
    }

    @Override
    public void onBindViewHolder(@NonNull ProductHolder holder, int position) {
        holder.setData(position);
    }

    public List<ProductInfor> getData() {
        return products;
    }

    @Override
    public int getItemCount() {
        return products.size();
    }
}
