package com.greenfoxacademy.springstart;

import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Component;


@Qualifier("Service")
@Component
public class Service implements ServicesInterface {

    public String print(String text){
        return text + "from service";
    }
}
