package com.greenfoxacademy.springstart;

public class Greeting {
    long greetCount;
    String content;

    public long getGreetCount() {
        return greetCount;
    }

    public String getContent() {
        return content;
    }

    public Greeting(long greetCount, String content) {
        this.greetCount = greetCount;
        this.content = content;
    }
}
