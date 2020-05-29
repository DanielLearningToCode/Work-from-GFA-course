package com.example.todos.services;

import com.example.todos.models.Todo;
import com.example.todos.repositories.ToDoRepository;
import org.springframework.stereotype.Service;

import java.util.Collection;

@Service
public class TodoService {

    ToDoRepository repo;

    public TodoService(ToDoRepository repo) {
        this.repo = repo;
    }

    public Iterable<Todo> getAll() {
        return repo.findAll();
    }

    public Todo getById(long id) {
        return repo.findById(id).get();
    }

    public Todo create(Todo todo){
        repo.save(todo);
        return todo;
    }

    public Todo update(Todo todo, long id){
        todo.id = id;
        repo.save(todo);
        return todo;
    }

    public boolean exists(long id){
        return repo.existsById(id);
    }

    public void delete(long id){
        repo.deleteById(id);
    }
}
