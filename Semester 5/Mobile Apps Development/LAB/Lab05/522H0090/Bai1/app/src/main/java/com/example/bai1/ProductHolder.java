package com.example.bai1;

import android.view.View;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

public class ProductHolder extends RecyclerView.ViewHolder implements
        CompoundButton.OnCheckedChangeListener {
    ProductAdapter adapter;
    public ProductHolder(@NonNull View itemView, ProductAdapter adapter) {
        super(itemView);
        this.adapter = adapter;
    }

    public void setData(int pos) {
        ProductInfor product = adapter.getData() .get(pos);
        TextView lblText = itemView.findViewById(R.id.phone_name);
        lblText.setText(product.getName());
        ImageView imgProduct = itemView.findViewById(R.id.phone_icon);
        imgProduct.setImageResource(product.getImage());
        CheckBox chkSelected = itemView.findViewById(R.id.phone_checkbox);
        chkSelected.setOnCheckedChangeListener(null);
        chkSelected.setChecked(product.isSelected());
        chkSelected.setTag(pos);
        chkSelected.setOnCheckedChangeListener(this);
    }

    @Override
    public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
        adapter.getData().get((int)buttonView.getTag()).setSelected(isChecked);
    }
}
