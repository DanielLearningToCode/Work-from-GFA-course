package com.greenfoxacademy.springstart;

import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Service;

@Qualifier("ServiceTwo")
// lze vytvorit tridu s anotaci @Configuration a v ni udelat registraci trid v kontejneru pro dependency injection

@Service
public class ServiceTwo implements ServicesInterface {

    public String print(String text) {
        return "service Two";
    }
}
