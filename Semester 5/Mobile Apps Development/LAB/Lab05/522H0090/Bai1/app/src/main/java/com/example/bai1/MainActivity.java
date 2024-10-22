package com.example.bai1;

import android.os.Bundle;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;
import androidx.recyclerview.widget.RecyclerView;

public class MainActivity extends AppCompatActivity {
    private RecyclerView recyclerView;
    private PhoneAdapter adapter;
    private List<Phone> phoneList = new ArrayList<>();
    private boolean allSelected = false;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
        recyclerView = findViewById(R.id.recycler_view);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));

        // Tạo dữ liệu mẫu
        phoneList.add(new Phone("Apple", false));
        phoneList.add(new Phone("Samsung", false));
        phoneList.add(new Phone("Nokia", false));
        phoneList.add(new Phone("Oppo", false));

        adapter = new PhoneAdapter(this, phoneList);
        recyclerView.setAdapter(adapter);
    }
    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.menu_options, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        switch (item.getItemId()) {
            case R.id.menu_check_all:
                adapter.selectAll(!allSelected); // `allSelected` là biến boolean để kiểm tra trạng thái chọn
                allSelected = !allSelected;
                return true;
            case R.id.menu_delete_selected:
                showDeleteConfirmationDialog(() -> adapter.deleteSelected());
                return true;
            case R.id.menu_delete_all:
                showDeleteConfirmationDialog(() -> adapter.deleteAll());
                return true;
            default:
                return super.onOptionsItemSelected(item);
        }
    }

    private void showDeleteConfirmationDialog(Runnable onConfirm) {
        new AlertDialog.Builder(this)
                .setMessage("Are you sure you want to delete?")
                .setPositiveButton("Yes", (dialog, which) -> onConfirm.run())
                .setNegativeButton("No", null)
                .show();
    }

}