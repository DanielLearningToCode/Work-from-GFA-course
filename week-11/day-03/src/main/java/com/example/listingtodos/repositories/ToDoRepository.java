package com.example.listingtodos.repositories;

import com.example.listingtodos.ToDo;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Component;


public interface ToDoRepository extends CrudRepository<ToDo, Long> {
}
