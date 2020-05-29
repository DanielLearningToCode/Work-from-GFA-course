package gf.chatapp.Services;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.annotation.JsonSerialize;
import gf.chatapp.Models.GetMessages;
import gf.chatapp.Models.IndexViewModel;
import gf.chatapp.Models.Message;
import org.springframework.http.HttpMethod;

import java.io.IOException;
import java.net.Authenticator;
import java.net.InetSocketAddress;
import java.net.ProxySelector;
import java.net.URI;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse;
import java.nio.ByteBuffer;
import java.time.Duration;
import java.lang.System;
import java.util.ArrayList;
import java.util.concurrent.Flow;

@org.springframework.stereotype.Service
public class ChatService {

    public static String getAddress = "https://rascals-chat.herokuapp.com/API/CHANNEL/Get-messages";

    HttpClient client = HttpClient.newBuilder()
            .version(HttpClient.Version.HTTP_1_1)
            .followRedirects(HttpClient.Redirect.NORMAL)
            .connectTimeout(Duration.ofSeconds(10))
            .build();

    public IndexViewModel sendPost() throws IOException, InterruptedException {
        //StringBuilder builder = new StringBuilder();
        //builder.append();
        ObjectMapper mapper = new ObjectMapper();
        GetMessages getMessages = new GetMessages();
        String bodyString = mapper.writeValueAsString(getMessages);
        HttpRequest.BodyPublisher body = HttpRequest.BodyPublishers.ofString(bodyString);
        HttpRequest request = HttpRequest.newBuilder().POST(body).
                uri(URI.create(getAddress)).timeout(Duration.ofSeconds(30)).
                header("apiKey", "73a71e33").header("Content-Type", "application/json").build();

        HttpResponse<String> response = client.send(request,HttpResponse.BodyHandlers.ofString());
        String responseBody = response.body();
        IndexViewModel model = mapper.readValue(responseBody, IndexViewModel.class);
        return model;

    }


}
