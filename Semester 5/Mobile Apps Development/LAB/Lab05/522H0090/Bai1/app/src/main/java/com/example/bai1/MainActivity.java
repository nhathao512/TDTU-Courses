package com.example.bai1;

import android.content.DialogInterface;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import androidx.appcompat.widget.Toolbar;
import androidx.activity.EdgeToEdge;
import androidx.annotation.NonNull;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {
    private RecyclerView recyclerView;
    private ProductAdapter adapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        recyclerView = findViewById(R.id.recyclerView);
        List<ProductInfor> products = new ArrayList<>();
        int images[] = {R.drawable.phone_android,
                R.drawable.phone_iphone,
                R.drawable.smartphone};
        for (int i = 1; i < 100; i++) {
            products.add(new ProductInfor("Product " + i,
                    false, images[i % 3]));
        }
        adapter = new ProductAdapter(this, products);
        recyclerView.setLayoutManager(new LinearLayoutManager(this,
                LinearLayoutManager.VERTICAL, false));
        recyclerView.setAdapter(adapter);
    }


    @Override
    public boolean onCreateOptionsMenu(@NonNull Menu menu) {
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        int id = item.getItemId();
        if (id == R.id.check_all) {
            boolean hasChecked = false;
            for (int i = 0; i < adapter.getData().size() && !hasChecked; i++) {
                hasChecked = adapter.getData().get(i).isSelected();
            }
            hasChecked = !hasChecked;
            for (int i = 0; i < adapter.getData().size(); i++) {
                adapter.getData().get(i).setSelected(hasChecked);
            }
            adapter.notifyDataSetChanged();
            return true;
        }
        else if (id == R.id.delete_selected) {
            AlertDialog.Builder builder = new AlertDialog.Builder(this);
            builder.setTitle("Xóa sản phẩm").setMessage("Bạn có chắc chắn muốn xóa sản phẩm đang chọn?");
            builder.setPositiveButton("Xóa", new DialogInterface.OnClickListener() {
                @Override
                public void onClick(DialogInterface dialogInterface, int which) {
                    for (int i = 0; i < adapter.getData().size(); ) {
                        if (adapter.getData().get(i).isSelected()) {
                            adapter.getData().remove(i);
                        } else {
                            i++;
                        }
                    }
                    adapter.notifyDataSetChanged();
                    dialogInterface.dismiss();
                }
            });
            builder.setNegativeButton("Hủy bỏ", new DialogInterface.OnClickListener() {
                @Override
                public void onClick(DialogInterface dialogInterface, int i) {
                    dialogInterface.dismiss();
                }
            });
            builder.create().show();
            return true;
        }
        else if (id == R.id.delete_all) {
            adapter.getData().clear();
            adapter.notifyDataSetChanged();
            return true;
        }
        else {
            return super.onOptionsItemSelected(item);
        }
    }

}