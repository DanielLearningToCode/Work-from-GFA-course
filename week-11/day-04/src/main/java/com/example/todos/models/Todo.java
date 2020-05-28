package com.example.todos.models;


import javax.persistence.*;

@Entity
public class Todo {

    @Column
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public long id;
    @Column
    public String title;
    @Column
    public boolean urgent;
    @Column
    public boolean done;

    public Todo() {}

    public Todo(long id, String title, boolean urgent, boolean done) {
        this.id = id;
        this.title = title;
        this.urgent = urgent;
        this.done = done;
    }
}
