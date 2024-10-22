package com.hibernate.main;

import com.hibernate.dao.ManufactureDAO;
import com.hibernate.dao.PhoneDAO;
import com.hibernate.entity.Manufacture;
import com.hibernate.entity.Phone;

public class Program {
    public static void main(String[] args) {
        ManufactureDAO manufactureDAO = new ManufactureDAO();
        PhoneDAO phoneDAO = new PhoneDAO();

        // Create and add manufacturers
        Manufacture m1 = new Manufacture("M001", "Samsung", "South Korea", 200);
        Manufacture m2 = new Manufacture("M002", "Apple", "USA", 150);
        Manufacture m3 = new Manufacture("M003", "Xiaomi", "China", 180);
        Manufacture m4 = new Manufacture("M004", "Sony", "Japan", 120);
        Manufacture m5 = new Manufacture("M005", "OnePlus", "China", 100);
        Manufacture m6 = new Manufacture("M006", "Google", "USA", 140);
        Manufacture m7 = new Manufacture("M007", "Huawei", "China", 170);
        Manufacture m8 = new Manufacture("M008", "Oppo", "China", 160);
        Manufacture m9 = new Manufacture("M009", "LG", "South Korea", 110);
        Manufacture m10 = new Manufacture("M010", "Nokia", "Finland", 90);

        manufactureDAO.add(m1);
        manufactureDAO.add(m2);
        manufactureDAO.add(m3);
        manufactureDAO.add(m4);
        manufactureDAO.add(m5);
        manufactureDAO.add(m6);
        manufactureDAO.add(m7);
        manufactureDAO.add(m8);
        manufactureDAO.add(m9);
        manufactureDAO.add(m10);

        // Create and add phones
        Phone p1 = new Phone("P001", "Galaxy S21", 30000000, "Black", "South Korea", 50, m1);
        Phone p2 = new Phone("P002", "iPhone 13", 50000000, "White", "USA", 30, m2);
        Phone p3 = new Phone("P003", "Mi 11", 20000000, "Blue", "China", 60, m3);
        Phone p4 = new Phone("P004", "Xperia 5", 25000000, "Gray", "Japan", 40, m4);
        Phone p5 = new Phone("P005", "OnePlus 9", 28000000, "Red", "China", 35, m5);
        Phone p6 = new Phone("P006", "Pixel 6", 45000000, "Black", "USA", 25, m6);
        Phone p7 = new Phone("P007", "P40 Pro", 32000000, "White", "China", 45, m7);
        Phone p8 = new Phone("P008", "Find X3", 27000000, "Blue", "China", 55, m8);
        Phone p9 = new Phone("P009", "LG Velvet", 23000000, "Pink", "South Korea", 20, m9);
        Phone p10 = new Phone("P010", "Nokia 8.3", 19000000, "Green", "Finland", 30, m10);

        phoneDAO.add(p1);
        phoneDAO.add(p2);
        phoneDAO.add(p3);
        phoneDAO.add(p4);
        phoneDAO.add(p5);
        phoneDAO.add(p6);
        phoneDAO.add(p7);
        phoneDAO.add(p8);
        phoneDAO.add(p9);
        phoneDAO.add(p10);

        // Test CRUD operations
        System.out.println("All Phones: " + phoneDAO.getAll());
        System.out.println("Get Phone P001: " + phoneDAO.get("P001"));

        // Update phone price
        p1.setPrice(32000000);
        phoneDAO.update(p1);
        System.out.println("Updated Phone P001: " + phoneDAO.get("P001"));

        // Remove a phone
        phoneDAO.remove("P002");
        System.out.println("All Phones after removal: " + phoneDAO.getAll());

        // Get phone with highest price
        System.out.println("Phone with highest price: " + phoneDAO.getPhoneWithHighestPrice());

        // Check if there are phones above 50 million
        System.out.println("Is there a phone above 50 million? " + phoneDAO.hasPhoneAbove50Million());

        // Get all manufacturers
        System.out.println("All Manufacturers: " + manufactureDAO.getAll());
        // Check if all manufacturers have more than 100 employees
        System.out.println("All manufacturers have more than 100 employees: " + manufactureDAO.allManufacturersHaveMoreThan100Employees());

        // Sum of all employees
        System.out.println("Total employees: " + manufactureDAO.sumAllEmployees());

        // Get last manufacturer based in US
        try {
            System.out.println("Last manufacturer based in US: " + manufactureDAO.getLastManufacturerBasedInUS());
        } catch (IllegalStateException e) {
            System.out.println(e.getMessage());
        }
    }
}
