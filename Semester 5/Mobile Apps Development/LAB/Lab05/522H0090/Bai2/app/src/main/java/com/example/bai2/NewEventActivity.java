package com.example.bai2;

import android.app.Activity;
import android.app.DatePickerDialog;
import android.app.TimePickerDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.DatePicker;
import android.widget.TextView;
import android.widget.TimePicker;

import androidx.activity.EdgeToEdge;
import androidx.annotation.NonNull;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.Calendar;
import java.util.Locale;

public class NewEventActivity extends AppCompatActivity {
    public static final String TITLE = "TITLE";
    public static final String PLACE = "PLACE";
    public static final String DATE = "DATE";
    public static final String TIME = "TIME";
    private TextView etName;
    private TextView etPlace;
    private TextView etDate;
    private TextView etTime;
    private String[] places = new String[] {"C201", "C202", "C203", "C204"};
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_new_event);

        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        // bind ui controls
        etName = findViewById(R.id.et_name);
        etPlace = findViewById(R.id.et_place);
        etDate = findViewById(R.id.et_date);
        etTime = findViewById(R.id.et_time);

        etPlace.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                showPlaceSelectionDialog();
            }
        });

        etDate.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                showDateSelectionDialog();
            }
        });

        etTime.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                showTimeSelectionDialog();
            }
        });
    }
    private void showTimeSelectionDialog() {
        // get current time
        int mHourOfDay = 0;
        int mMinute = 0;

        TimePickerDialog timePickerDialog = new TimePickerDialog(this, new TimePickerDialog.OnTimeSetListener() {
            @Override
            public void onTimeSet(TimePicker timePicker, int hourOfDay, int minute) {
                etTime.setText(hourOfDay + ":" + minute);
            }
        }, mHourOfDay, mMinute, false);
        timePickerDialog.show();
    }

    private void showDateSelectionDialog() {
        // get current date
        Calendar c = Calendar.getInstance();
        int startYear = c.get(Calendar.YEAR);
        int startMonth = c.get(Calendar.MONTH);
        int startDay = c.get(Calendar.DAY_OF_MONTH);

        DatePickerDialog datePickerDialog = new DatePickerDialog(this, new DatePickerDialog.OnDateSetListener() {
            @Override
            public void onDateSet(DatePicker datePicker, int year, int monthOfYear, int dayOfMonth) {
                etDate.setText(dayOfMonth + "/" + monthOfYear + "/" + year);
            }
        }, startYear, startMonth, startDay);
        datePickerDialog.show();
    }

    private void showPlaceSelectionDialog() {
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setTitle("Select place");
        builder.setSingleChoiceItems(places, 2, new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialogInterface, int i) {
                etPlace.setText(places[i]);
            }
        });

        AlertDialog alertDialog = builder.create();
        alertDialog.show();
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        MenuInflater menuInflater = getMenuInflater();
        menuInflater.inflate(R.menu.createn_screen_option_menu, menu);
        return super.onCreateOptionsMenu(menu);
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        if (item.getItemId() == R.id.miSave) {
            Intent exercise02ActivityIntent = new Intent();

            Bundle bundle = new Bundle();
            bundle.putString(TITLE, etName.getText().toString());
            bundle.putString(PLACE, etPlace.getText().toString());
            bundle.putString(DATE, etDate.getText().toString());
            bundle.putString(TIME, etTime.getText().toString());

            exercise02ActivityIntent.putExtras(bundle);

            setResult(Activity.RESULT_OK, exercise02ActivityIntent);
            finish();
        }
        return super.onOptionsItemSelected(item);
    }
}