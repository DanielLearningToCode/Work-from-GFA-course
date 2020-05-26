package com.company;

public class Hardcover extends Book{
    public Hardcover(String title, String author, int year, int pageCount) {
        super(title, author, year, pageCount);
        coverWeight = 100;
        weight = pageWeight*pageCount+coverWeight;
    }
}
