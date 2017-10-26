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
public class Local {
    private int idLocal;
    private String nomeLocal;
    private String endereço;
    private String bairro;
    private String cidade;
    private String estado;

    public Local(int idLocal, String nomeLocal, String endereço, String bairro, String cidade, String estado) {
        this.idLocal = idLocal;
        this.nomeLocal = nomeLocal;
        this.endereço = endereço;
        this.bairro = bairro;
        this.cidade = cidade;
        this.estado = estado;
    }
    
}
