package gf.chatapp.Controllers;

import gf.chatapp.Models.IndexViewModel;
import gf.chatapp.Models.Message;
import gf.chatapp.Models.MessageRequest;
import gf.chatapp.Services.ChatService;
import org.hibernate.engine.spi.ManagedEntity;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.stereotype.Service;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;
import org.springframework.web.servlet.view.RedirectView;

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

    @GetMapping("/submit")
    public String sendMessage(@ModelAttribute("message") MessageRequest message, Model model){
        return "Submit";
    }

    @PostMapping("/submit")
    public RedirectView send(RedirectAttributes attributes, @ModelAttribute("message") MessageRequest message, Model model) throws IOException, InterruptedException {
        service.sendMessage(message.content);
       // attributes.addFlashAttribute("flashAttribute", "/");
        //attributes.addAttribute("attribute", "/Index");
        return new RedirectView("/");  // tohle staci
    }
}
