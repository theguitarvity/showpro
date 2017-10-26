/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.showpro.model.domain;

import java.util.Calendar;
import java.util.Date;

/**
 *
 * @author mrlopito
 */
public class Cliente {
    private int idCliente;
    private String nomeCliente;
    private String cpfCliente;
    private String rgCliente;
    private Date dtNascimento;
    private Local endereco;

    public Cliente(int idCliente, String nomeCliente, String cpfCliente, String rgCliente, Date dtNascimento, Local endereco) {
        this.idCliente = idCliente;
        this.nomeCliente = nomeCliente;
        this.cpfCliente = cpfCliente;
        this.rgCliente = rgCliente;
        this.dtNascimento = dtNascimento;
        this.endereco = endereco;
    }

    public int getIdCliente() {
        return idCliente;
    }

    public String getNomeCliente() {
        return nomeCliente;
    }

    public String getCpfCliente() {
        return cpfCliente;
    }

    public String getRgCliente() {
        return rgCliente;
    }

    public Date getDtNascimento() {
        return dtNascimento;
    }

    public Local getEndereco() {
        return endereco;
    }
    
    public boolean menorDeIdade(){
        boolean menor = false;
        Calendar cal = Calendar.getInstance();
        if(cal.get(Calendar.YEAR)- getDtNascimento().getYear()<18)
            menor = true;
        return menor;
    }
    
    
}
