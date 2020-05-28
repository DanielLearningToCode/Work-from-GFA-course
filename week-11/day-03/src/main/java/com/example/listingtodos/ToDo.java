package com.example.listingtodos;

import lombok.Generated;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;

@Entity
public class ToDo {

    @Id
    @Generated
    private long id;
    @Column
    private String title;
    @Column
    private boolean urgent = false;
    @Column
    private boolean done = false;

    public ToDo() { }

    public ToDo(long id, String title, boolean urgent, boolean done) {
        this.id = id;
        this.title = title;
        this.urgent = urgent;
        this.done = done;
    }
}


