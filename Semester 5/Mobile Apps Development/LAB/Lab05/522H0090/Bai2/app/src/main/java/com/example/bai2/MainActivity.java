package com.example.bai2;

import android.app.Activity;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.ContextMenu;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.CompoundButton;
import android.widget.ListView;
import android.widget.Switch;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {
    private ListView mListView;

    private EventAdapter mAdapter;
    private List<Event> mData;
    private List<Event> originalData; // Danh sách gốc lưu toàn bộ sự kiện
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
        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        initViews();
        initData();

        registerForContextMenu(mListView);
    }
    private void initViews() {
        mListView = findViewById(R.id.listView);
    }

    private void initData() {
        mData = new ArrayList<>();
        mData.add(new Event("Sinh hoat chu nhiem", "C120", "09/03/2020", "04:43", false));
        mData.add(new Event("Huong dan luan van", "C120", "09/03/2020", "04:43", false));

        originalData = new ArrayList<>(mData);
        mAdapter = new EventAdapter(this, R.layout.row_layout, mData);
        mListView.setAdapter(mAdapter);
    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        MenuInflater menuInflater = getMenuInflater();
        menuInflater.inflate(R.menu.menu_main, menu);

        MenuItem menuItem = menu.findItem(R.id.miSwitch);
        menuItem.setActionView(R.layout.actionbar_switch);

        Switch switchEvent = menuItem.getActionView().findViewById(R.id.sw_event);

        switchEvent.setOnCheckedChangeListener((compoundButton, isChecked) -> {
            mData.clear(); // Xóa mData để cập nhật lại từ originalData

            if (isChecked) {
                // Hiển thị tất cả sự kiện từ originalData
                mData.addAll(originalData);
            } else {
                // Chỉ hiển thị sự kiện enabled từ originalData
                for (Event event : originalData) {
                    if (event.getDone()) { // Nếu event đang enable (checked)
                        mData.add(event);
                    }
                }
            }
            mAdapter.notifyDataSetChanged(); // Cập nhật lại giao diện
        });

        return super.onCreateOptionsMenu(menu);
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        if (item.getItemId() == R.id.miDeleteAll) {
            showConfirmDialog();
        } else if (item.getItemId() == R.id.miAbout) {
            showAboutDialog();
        } else if (item.getItemId() == R.id.miCreate) {
            openCreateNewEventActivity();
        }
        return super.onOptionsItemSelected(item);
    }
    @Override
    public void onCreateContextMenu(ContextMenu menu, View v, ContextMenu.ContextMenuInfo menuInfo) {
        super.onCreateContextMenu(menu, v, menuInfo);
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.context_menu, menu); // Đảm bảo bạn có context_menu.xml
    }

    @Override
    public boolean onContextItemSelected(@NonNull MenuItem item) {
        AdapterView.AdapterContextMenuInfo info = (AdapterView.AdapterContextMenuInfo) item.getMenuInfo();
        int position = info.position;

        if (item.getItemId() == R.id.context_delete) {
            mData.remove(position);
            mAdapter.notifyDataSetChanged();
            return true;
        } else if (item.getItemId() == R.id.context_edit) {
            // Xử lý chỉnh sửa sự kiện (có thể mở một Activity hoặc Dialog)
            editEvent(position);
            return true;
        } else {
            return super.onContextItemSelected(item);
        }
    }


    private void editEvent(int position) {
        // Xử lý logic chỉnh sửa sự kiện
        Event event = mData.get(position);
        // Hiển thị một Activity hoặc Dialog để chỉnh sửa event
    }


    private void openCreateNewEventActivity() {
        // create intent to call NewEventActivity
        Intent newEventActivityIntent = new Intent(MainActivity.this, NewEventActivity.class);
        startActivityForResult(newEventActivityIntent, 100);
    }

    private void showConfirmDialog() {
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setTitle("Confirm");
        builder.setMessage("Are you sure to delete all events?");
        builder.setPositiveButton("YES", (dialogInterface, i) -> {
            mData.clear();
            originalData.clear(); // Xóa cả danh sách gốc
            mAdapter.notifyDataSetChanged();
            Toast.makeText(MainActivity.this, "All events deleted!", Toast.LENGTH_LONG).show();
        });
        builder.setNegativeButton("NO", null);

        AlertDialog confirmDialog = builder.create();
        confirmDialog.show();
    }



    private void showAboutDialog() {
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setTitle("About");
        builder.setMessage("StudentID: 522H0090");
        builder.setPositiveButton("OK", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialogInterface, int i) {
                Toast.makeText(MainActivity.this, "SEE YOU AGAIN!", Toast.LENGTH_LONG).show();
            }
        });

        AlertDialog alertDialog = builder.create();
        alertDialog.show();
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        super.onActivityResult(requestCode, resultCode, data);

        if (requestCode == 100 && resultCode == Activity.RESULT_OK) {
            Bundle returnedBundle = data.getExtras();
            String title = returnedBundle.getString(NewEventActivity.TITLE);
            String place = returnedBundle.getString(NewEventActivity.PLACE);
            String date = returnedBundle.getString(NewEventActivity.DATE);
            String time = returnedBundle.getString(NewEventActivity.TIME);
            Event newEvent = new Event(title, place, date, time, false);

            // Thêm sự kiện mới vào cả originalData và mData
            originalData.add(newEvent); // Cập nhật danh sách gốc
            mData.add(newEvent); // Cập nhật danh sách hiển thị
            mAdapter.notifyDataSetChanged(); // Cập nhật giao diện
        }
    }

}