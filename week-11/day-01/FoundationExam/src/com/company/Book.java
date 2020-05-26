package com.company;

public abstract class Book {
    protected int pageWeight = 10;
    protected int coverWeight;
    protected int year;
    protected int pageCount;
    protected String title;
    protected String author;
    protected int weight;


    public Book(int pageWeight, int coverWeight, int year, int pageCount, String title, String author) {
        this.pageWeight = pageWeight;
        this.coverWeight = coverWeight;
        this.year = year;
        this.pageCount = pageCount;
        this.title = title;
        this.author = author;
    }

    public int getYear() {
        return year;
    }

    public void setPageCount(int pageCount) {
        this.pageCount = pageCount;
    }

    public int getPageWeight() { return pageWeight; }
    public int getCoverWeight() { return coverWeight; }
    public String getTitle() { return title; }
    public String getAuthor() { return author; }

    public Book(String title, String author, int year, int pageCount)
    {
        this.title = title;
        this.author = author;
        this.year = year;
        this.pageCount = pageCount;
    }

    public Book(){}

    public String GetBookInfo()
    {
        return author + ":" + title + " " + year;
    }

}
