/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.showpro.model.domain;

import java.io.Serializable;

/**
 *
 * @author mrlopito
 */
public class Usuario implements Serializable {

    private int idUsuario;
    private String nomeUsuario;
    private String emailUsuario;
    private String senhaUsuario;

    public Usuario(String nomeUsuario, String emailUsuario, String senhaUsuario) {
        this.nomeUsuario = nomeUsuario;
        this.emailUsuario = emailUsuario;
        this.senhaUsuario = senhaUsuario;
    }

    public String getNomeUsuario() {
        return nomeUsuario;
    }

    public String getEmailUsuario() {
        return emailUsuario;
    }

    public void setNomeUsuario(String nomeUsuario) {
        this.nomeUsuario = nomeUsuario;
    }

    public void setEmailUsuario(String emailUsuario) {
        this.emailUsuario = emailUsuario;
    }

    public void setSenhaUsuario(String senhaUsuario) {
        this.senhaUsuario = senhaUsuario;
    }
    
    

}
