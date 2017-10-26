/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.showpro.model.domain;

import java.security.Timestamp;
import java.util.Date;

/**
 *
 * @author mrlopito
 */
public class Evento {

    private int idEvento;
    private String nomeEvento;
    private TipoEvento tipoEvento;
    private Date dataEvento;
    private Local localEvento;
    private Timestamp creactedAt;
    private Timestamp updatedAt;

    public int getIdEvento() {
        return idEvento;
    }

    public String getNomeEvento() {
        return nomeEvento;
    }

    public TipoEvento getTipoEvento() {
        return tipoEvento;
    }

    public Date getDataEvento() {
        return dataEvento;
    }

    public Local getLocalEvento() {
        return localEvento;
    }

    public Timestamp getCreactedAt() {
        return creactedAt;
    }

    public Timestamp getUpdatedAt() {
        return updatedAt;
    }

    public Evento(int idEvento, String nomeEvento, TipoEvento tipoEvento, Date dataEvento, Local localEvento, Timestamp creactedAt, Timestamp updatedAt) {
        this.idEvento = idEvento;
        this.nomeEvento = nomeEvento;
        this.tipoEvento = tipoEvento;
        this.dataEvento = dataEvento;
        this.localEvento = localEvento;
        this.creactedAt = creactedAt;
        this.updatedAt = updatedAt;
    }

}
