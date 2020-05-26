package com.company;

import java.util.*;

public class BookShelf {

    private List<Book> books;

    public BookShelf() {
        books = new ArrayList<>();
    }

    public void addBook(Book book) {
        books.add(book);
    }

    public List<String> getBooksByYear(int year) {
        List<String> result = new ArrayList<>();
        for (var book : books
        ) {
            if (book.year == year) {
                result.add(String.format("<%s> , <%s>", book.author, book.title));
                //result.add(book.author + ", " + book.title);

                //MessageFormat.format("A string {0}.", aVariable);
                //String.format("A String %s %2d", aStringVar, anIntVar);
            }
        }
        return result;
    }

    public String getLightestAuthor() {
        Book lightestOne = books.get(0);
        for (var book : books
        ) {
            if (book.weight < lightestOne.weight) {
                lightestOne = book;
            }
        }
        return lightestOne.author;
    }

    public String getMaxAuthor() {
        HashMap<String, Integer> authorsWithPages = new HashMap<>();
        for (var book : books
        ) {
            if (authorsWithPages.containsKey(book.author)) {
                authorsWithPages.put(book.author, authorsWithPages.get(book.author) + book.pageCount);
            } else {
                authorsWithPages.put(book.author, book.pageCount);
            }
        }
        int maxPageCount = 0;
        for (Map.Entry<String, Integer> author : authorsWithPages.entrySet()
        ) {
            if (author.getValue() > maxPageCount) {
                maxPageCount = author.getValue();
            }
        }

        //for (var author : authorsWithPages.entrySet()
        //) {
        //    if (author.getValue().equals(maxPageCount)) {
        //        return author.getKey();
        //    }
        //}

        //using stream
        final int maxPageCountFinal = maxPageCount;
        var result = authorsWithPages.entrySet().stream().
                filter(entry -> entry.getValue().equals(maxPageCountFinal)).
                map(Map.Entry::getKey).findFirst().get();

        String formattedResult = String.format("The most prolific author is %s with %s pages", result, maxPageCount);
        return formattedResult;
    }

    public void printBooks() {
        for (var book : books
        ) {
            System.out.println(book.GetBookInfo());
        }
    }
}
