package gf.chatapp.Models;

import javax.persistence.Entity;
import javax.persistence.Id;

@Entity
public class ApiKeyHolder {

    @Id
    private long id;
    private String apiKey;

    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public String getApiKey() {
        return apiKey;
    }

    public void setApiKey(String apiKey) {
        this.apiKey = apiKey;
    }
}
