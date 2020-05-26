package com.company;

import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.HashMap;

public class Main {

    public static void main(String[] args) {
        // write your code here
       //String[] inputArr1 = {"apple", "apply", "tuple", "alter"};
       //String word1 = "apple";
       //String[] inputArr2 = {"donkey", "monday", "shaker"};
       //String word2 = "monkey";

       //System.out.println(GetElementsWithLessThanThreeDifferences(word2, inputArr2));
       //String path ="C:\\Users\\Dan\\greenfox\\DanielLearningToCode\\week-11\\FoundationExam\\src\\com\\company\\file.txt";
       //System.out.println(GetMostProductiveYear(path));
        //Book book = new Book("title", "author", 2008, 255);

        BookShelf shelf = new BookShelf();
        shelf.addBook(new Hardcover("Harry Potter 1", "J.k.Rowling", 2000, 300));
        shelf.addBook(new Hardcover("Harry Potter 2", "J.k.Rowling", 2001, 352));
        shelf.addBook(new Hardcover("Harry Potter 3", "J.k.Rowling", 2003, 541));
        shelf.addBook(new Hardcover("Harry Potter 4", "J.k.Rowling", 2005, 452));
        shelf.addBook(new Hardcover("Harry Potter 5", "J.k.Rowling", 2007, 652));
        shelf.addBook(new Hardcover("LOTR 1", "J.R.R.Tolkien", 1946, 354));
        shelf.addBook(new Hardcover("LOTR 2", "J.R.R.Tolkien", 1947, 355));
        shelf.addBook(new Hardcover("LOTR 3", "J.R.R.Tolkien", 1947, 398));
        shelf.addBook(new Hardcover("Henry V", "W. Shakespeare", 1600, 210));
        shelf.addBook(new Hardcover("Romeo and Juliet", "W. Shakespeare", 1598, 150));
       //shelf.printBooks();
       //System.out.println(shelf.getBooksByYear(1600));
       //System.out.println(shelf.getLightestAuthor());
       System.out.println(shelf.getMaxAuthor());
    }

    public static ArrayList<String> GetElementsWithLessThanThreeDifferences(String input, String[] inputArray) {
        ArrayList<String> result = new ArrayList<String>();
        int differences = 0;
        boolean match;
        for (int j = 0; j < inputArray.length; j++) {
            match = true;
            differences = 0;
            for (int i = 0; i < input.length(); i++) {
                if (input.toCharArray()[i] != inputArray[j].toCharArray()[i]) {
                    differences++;
                    if (differences > 3) {
                        match = false;
                        break;
                    }
                }
            }
            if (match) {
                result.add(inputArray[j]);
            }
        }
        return result;
    }



    public static int GetMostProductiveYear(String path) {
        int result = 0;
        int year;
        String[] line;
        ArrayList<String> records = null;

        try {
            Path filePath = Paths.get(path);
            records = (ArrayList<String>) Files.readAllLines(filePath, StandardCharsets.UTF_8);
        } catch (Exception e) {
            System.out.println("could not read the file!");
        }
        if (records == null) {
            System.out.println("No records found");
            return 0;
        }

        HashMap<Integer, Integer> occuranceOfYears = new HashMap<Integer, Integer>();
        int highestOccurance = 0;
        for (var song : records) {
            line = song.split(";");
            year = Integer.parseInt(line[3]);
            if (!occuranceOfYears.containsKey(year)) {
                occuranceOfYears.put(year, 1);
            }
            else {
                occuranceOfYears.put(year, occuranceOfYears.get(year) + 1);
            }
        }
        for (var publishingYear : occuranceOfYears.entrySet())
        {
            if (publishingYear.getValue() > highestOccurance)
            {
                highestOccurance = publishingYear.getValue();
                result = publishingYear.getKey();
            }
        }
        return result;
    }
}
