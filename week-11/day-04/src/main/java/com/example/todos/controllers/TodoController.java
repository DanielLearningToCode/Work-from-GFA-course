package com.example.todos.controllers;

import com.example.todos.models.Todo;
import com.example.todos.repositories.ToDoRepository;
import com.example.todos.services.TodoService;
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

    private TodoService service;

    public TodoController(TodoService service) {
        this.service = service;
    }

    @GetMapping("/")
    //@ResponseBody   converts output to JSON. Restcontroller does by default
    // alternativa - @PostMapping(value = "/content", produces = MediaType.APPLICATION_JSON_VALUE)
    public ResponseEntity<Iterable<Todo>> List() {
        var result = service.getAll();
        return ResponseEntity.status(200).body(result);
    }

    @GetMapping("/{id}")
    public ResponseEntity<Todo> getById(@PathVariable long id) {
        return ResponseEntity.status(200).body(service.getById(id));
    }

    @PostMapping("/")
    public ResponseEntity<Todo> createTodo(@RequestBody Todo todo) {
        service.create(todo);
        return ResponseEntity.status(201).body(todo);
    }

    @PutMapping("/{id}")
    public ResponseEntity update(@PathVariable long id, @RequestBody Todo todo) {
        if (!service.exists(id)) {
            //var objResult = new Object() {String message = "The provided id does not exists in the database";}; nefunguje, vraci 500
            return ResponseEntity.status(HttpStatus.NOT_FOUND).body("id not found");
        }
        todo = service.update(todo, id);
        return ResponseEntity.status(200).body(todo);
    }

    @DeleteMapping("/{id}")
    //misto responseEntity lze poslat responseTransfer
    public ResponseEntity delete(@PathVariable long id) {
        if (!service.exists(id)){
            return ResponseEntity.status(HttpStatus.NOT_FOUND).build();
        }
        service.delete(id);
        return ResponseEntity.ok(HttpStatus.OK);
    }
}
