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
public class TipoIngresso {
    private int idTipoIngresso;
    private String nomeTipoIngresso;

    public TipoIngresso(int idTipoIngresso, String nomeTipoIngresso) {
        this.idTipoIngresso = idTipoIngresso;
        this.nomeTipoIngresso = nomeTipoIngresso;
    }

    public String getNomeTipoIngresso() {
        return nomeTipoIngresso;
    }

    public void setNomeTipoIngresso(String nomeTipoIngresso) {
        this.nomeTipoIngresso = nomeTipoIngresso;
    }
    
    
}
