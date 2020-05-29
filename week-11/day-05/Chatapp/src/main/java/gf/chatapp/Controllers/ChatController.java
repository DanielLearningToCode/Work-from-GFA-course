package gf.chatapp.Controllers;

import gf.chatapp.Models.IndexViewModel;
import gf.chatapp.Services.ChatService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.stereotype.Service;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;

import javax.swing.text.View;
import java.io.IOException;
import java.net.http.HttpClient;

@Controller
public class ChatController {

    private ChatService service;

    @Autowired
    public ChatController(ChatService service) {
        this.service = service;
    }

    @GetMapping("/")
    public String index(Model model) throws IOException, InterruptedException {

        service.sendPost();
        model.addAttribute("messages", service.sendPost());

        return "Index";
    }

   /* @PostMapping("/")
    public String newMessage(@)*/
}
