package com.example.todos.controllers;

import com.example.todos.models.Todo;
import com.example.todos.repositories.ToDoRepository;
import net.bytebuddy.asm.Advice;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import javax.annotation.Resource;
import java.net.URI;
import java.util.ArrayList;
import java.util.List;


@RestController
public class TodoController {

    private ToDoRepository repo;

    public TodoController(ToDoRepository repo) {
        this.repo = repo;
    }

    @GetMapping("/")
    //@ResponseBody
    public ResponseEntity<Iterable<Todo>> List() {
        var result = repo.findAll();
        return ResponseEntity.status(200).body(result);
    }

    @GetMapping("/{id}")
    public ResponseEntity<Todo> getById(@PathVariable long id) {
        return ResponseEntity.status(200).body(repo.findById(id).get());
    }

    @PostMapping("/")
    public ResponseEntity<Todo> createTodo(@RequestBody Todo todo) {
        repo.save(todo);
        return ResponseEntity.status(201).body(todo);
    }

    @PutMapping("/{id}")
    public ResponseEntity<Todo> update(@PathVariable long id, @RequestBody Todo todo) {
        todo.id = id;
        repo.save(todo);
        return ResponseEntity.status(200).body(todo);
    }

    @DeleteMapping("/{id}")
    public ResponseEntity delete(@PathVariable long id) {
        repo.deleteById(id);
        return ResponseEntity.status(200).body("");
    }
}
