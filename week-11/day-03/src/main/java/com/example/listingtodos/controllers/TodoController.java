package com.example.listingtodos.controllers;

import com.example.listingtodos.ToDo;
import com.example.listingtodos.repositories.ToDoRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

import java.util.ArrayList;
import java.util.List;

@Controller
@RequestMapping("/todo")
public class TodoController {
//   @Autowired
   // ToDoRepository repo;

 //   @Autowired
   /* public TodoController(ToDoRepository repo) {
        this.repo = repo;
    }*/

    @RequestMapping(value = {"/list", "/"})
    @ResponseBody
    public List<ToDo> list() {
        ///@ResponseBody annotation tells a controller that
        // the object returned is automatically serialized into
        // JSON and passed back into the HttpResponse object.
        List<ToDo> result = new ArrayList<>();
        ToDo todo = new ToDo(1, "run", false, false);
        result.add(todo);
        return result;
    }
}
