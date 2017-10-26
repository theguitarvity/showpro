/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.showpro;

import java.io.IOException;
import javafx.application.Application;
import static javafx.application.Application.launch;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.layout.AnchorPane;
import javafx.stage.Stage;

/**
 *
 * @author mrlopito
 */
public class FxMain extends Application {
    
    @Override
    public void start(Stage primaryStage) throws IOException {
       Parent root = FXMLLoader.load(getClass().getResource("view/FXMLMain.fxml"));
       Scene scene = new Scene(root);
       
       primaryStage.setScene(scene);
       primaryStage.setTitle("Showpro - Administração");
       primaryStage.setMaximized(true);
       primaryStage.show();
       
    }

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        launch(args);
    }
    public void showEventosPage(){
        try{
            FXMLLoader loader = new FXMLLoader();
            loader.setLocation(FxMain.class.getResource("view/Cadastro_Evento.fxml"));
            AnchorPane cadastrosPage = (AnchorPane) loader.load();
            
        }catch (IOException e) {
            e.printStackTrace();
        }
    }
    
}
