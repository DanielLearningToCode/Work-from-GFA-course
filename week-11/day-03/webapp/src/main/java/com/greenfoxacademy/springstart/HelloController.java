package com.greenfoxacademy.springstart;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class HelloController {

    //  @Autowired
    //Qualifier("Service")
    ServicesInterface service;

    // dependency injection

    public HelloController(@Qualifier("ServiceTwo") ServicesInterface service) {
        this.service = service;
    }

    @RequestMapping("/")
    public String Index() {
        return service.print("Hello");
    }
}