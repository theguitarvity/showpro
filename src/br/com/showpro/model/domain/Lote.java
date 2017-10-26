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
public class Lote {
    private int idLote;
    private String nomeLote;
    private Double precoLote;

    public Lote(int idLote, String nomeLote, Double precoLote) {
        this.idLote = idLote;
        this.nomeLote = nomeLote;
        this.precoLote = precoLote;
    }

    public String getNomeLote() {
        return nomeLote;
    }

    public void setNomeLote(String nomeLote) {
        this.nomeLote = nomeLote;
    }

    public Double getPrecoLote() {
        return precoLote;
    }

    public void setPrecoLote(Double precoLote) {
        this.precoLote = precoLote;
    }

    public int getIdLote() {
        return idLote;
    }
    
    
}
