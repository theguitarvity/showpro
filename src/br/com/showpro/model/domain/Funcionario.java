/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.showpro.model.domain;

/**
 *
 * @author mrlopito
 */
public class Funcionario extends Usuario {
    
   private String cpf;

    public Funcionario(String cpf, String nomeUsuario, String emailUsuario, String senhaUsuario) {
        super(nomeUsuario, emailUsuario, senhaUsuario);
        this.cpf = cpf;
    }

    public String getCpf() {
        return cpf;
    }

    public void setCpf(String cpf) {
        this.cpf = cpf;
    }
    
   
    
}
