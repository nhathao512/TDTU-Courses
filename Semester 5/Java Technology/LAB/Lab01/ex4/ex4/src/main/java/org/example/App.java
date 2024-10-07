package org.example;

import org.apache.commons.validator.routines.UrlValidator;
import org.apache.commons.io.FileUtils;

import java.io.File;
import java.io.IOException;
import java.net.MalformedURLException;
import java.net.URL;

public class App {
    public static void main(String[] args) {
        if (args.length == 0) {
            System.out.println("Please specify a URL to a file");
            return;
        }

        String fileUrl = args[0];
        UrlValidator urlValidator = new UrlValidator();

        if (!urlValidator.isValid(fileUrl)) {
            System.out.println("This is not a valid URL");
            return;
        }

        try {
            URL url = new URL(fileUrl);
            String fileName = new File(url.getPath()).getName();
            File destination = new File(fileName);
            System.out.println("Downloading " + fileName + "...");
            FileUtils.copyURLToFile(url, destination);
            System.out.println("Downloaded: " + fileName);
        } catch (MalformedURLException e) {
            System.out.println("Malformed URL: " + e.getMessage());
        } catch (IOException e) {
            System.out.println("Error downloading file: " + e.getMessage());
        }
    }
}
