/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.showpro.controller;

import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.control.MenuBar;
import javafx.scene.control.MenuItem;
import javafx.scene.layout.AnchorPane;

/**
 * FXML Controller class
 *
 * @author mrlopito
 */
public class FXMLMainController implements Initializable {
    

    /**
     * Initializes the controller class.
     */
    @FXML
    private AnchorPane anchorPane;
    @FXML
    private MenuBar menuBar;
    @FXML
    private MenuItem MenuItemEvento;
    @FXML
    private MenuItem meniItemAtracoes;
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        // TODO
    }

    @FXML
    public void handleMenuItemEventos() throws IOException{
        AnchorPane a = (AnchorPane) FXMLLoader.load(getClass().getResource("/br/com/showpro/view/Cadastro_Evento.fxml"));
        anchorPane.getChildren().setAll(a);
        
    }
    
}
