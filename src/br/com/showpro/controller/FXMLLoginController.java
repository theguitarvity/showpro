/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.showpro.controller;

import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.scene.control.*;

/**
 * FXML Controller class
 *
 * @author mrlopito
 */
public class FXMLLoginController {

    /**
     * Initializes the controller class.
     */
    @FXML
    private TextField email;
    @FXML
    private TextField password;
    @FXML
    private Button loginButton;

    public void initialize() {
        // TODO
    }

    public void initManager(final LoginManager loginManager) {
        loginButton.setOnAction(new EventHandler<ActionEvent>() {
            @Override
            public void handle(ActionEvent event) {
                String sessionID = authorize();
                if (sessionID != null) {
                    loginManager.authenticated(sessionID);
                }
            }
        });
    }

    public String authorize() {
        if (this.email.equals("dev@dev.com") && this.password.equals("admin")) {
            return generateSessionID();
        } else {
            return null;
        }
    }

    private static int sessionID = 0;

    private String generateSessionID() {
        sessionID++;
        return "xyzzy - session " + sessionID;
    }

}
