package com.example.todos.controllers;

import com.example.todos.models.Todo;
import com.example.todos.repositories.ToDoRepository;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

import java.util.ArrayList;
import java.util.List;


@RestController
public class TodoController {

private ToDoRepository repo;

    public TodoController(ToDoRepository repo) {
        this.repo = repo;
    }

    @RequestMapping("/")
    @ResponseBody
    public List<Todo> List(){
        return new ArrayList<Todo>();
    }
}
