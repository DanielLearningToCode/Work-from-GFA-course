package com.company;

public class Paperback extends Book {

    public Paperback(String title, String author, int year, int pageCount) {
        super(title, author, year, pageCount);
        coverWeight = 20;
        weight = pageWeight * pageCount + coverWeight;
    }
}
