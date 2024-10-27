package com.example.bai2;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.CheckBox;
import android.widget.Switch;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import java.util.List;

public class EventAdapter extends ArrayAdapter<Event> {
    private Context context;
    private int layout;
    private List<Event> data;

    public EventAdapter(@NonNull Context context, int resource, @NonNull List<Event> objects) {
        super(context, resource, objects);
        this.context = context;
        this.layout = resource;
        this.data = objects;
    }
    @NonNull
    @Override
    public View getView(final int position, @Nullable View convertView, @NonNull ViewGroup parent) {
        ViewHolder holder;
        if (convertView == null) {
            convertView = LayoutInflater.from(context).inflate(layout, parent, false);

            holder = new ViewHolder();
            holder.name = convertView.findViewById(R.id.tv_name);
            holder.place = convertView.findViewById(R.id.tv_place);
            holder.datetime = convertView.findViewById(R.id.tv_datetime);
            holder.eventSwitch = convertView.findViewById(R.id.sw_switch);

            convertView.setTag(holder);
        } else {
            holder = (ViewHolder) convertView.getTag();
        }

        Event e = data.get(position);

        holder.name.setText(e.getName());
        holder.place.setText(e.getPlace());
        holder.datetime.setText(e.getDate() + " " + e.getTime());
        holder.eventSwitch.setChecked(e.getDone());

        holder.eventSwitch.setOnCheckedChangeListener((buttonView, isChecked) -> {
            e.setDone(isChecked);
            notifyDataSetChanged();
        });

        return convertView;
    }


    public static class ViewHolder {
        TextView name;
        TextView place;
        TextView datetime;
        Switch eventSwitch;
    }
}
