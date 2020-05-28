package com.example.todos.models;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;

@Entity
public class Todo {

    @Column
    @Id
    @GeneratedValue
    private long id;
    @Column
    private String title;
    @Column
    private boolean urgent;
    @Column
    private boolean done;

    public Todo() {}

    public Todo(long id, String title, boolean urgent, boolean done) {
        this.id = id;
        this.title = title;
        this.urgent = urgent;
        this.done = done;
    }
}
