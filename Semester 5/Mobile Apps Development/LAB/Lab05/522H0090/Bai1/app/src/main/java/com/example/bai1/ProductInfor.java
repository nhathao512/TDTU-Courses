package com.example.bai1;

public class ProductInfor {
    private String name;
    private boolean selected;
    private int image;

    public ProductInfor(String name, boolean selected, int image) {
        this.name = name;
        this.selected = selected;
        this.image = image;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public boolean isSelected() {
        return selected;
    }

    public void setSelected(boolean selected) {
        this.selected = selected;
    }

    public int getImage() {
        return image;
    }

    public void setImage(int image) {
        this.image = image;
    }
}
