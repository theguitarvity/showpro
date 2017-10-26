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
public class Ingresso {
    private long codigoIngresso;
    private TipoIngresso tipoIngresso;
    private Cliente cliente;
    private Evento evento;
    private Lote lote;

    public Ingresso(long codigoIngresso, TipoIngresso tipoIngresso, Cliente cliente, Evento evento, Lote lote) {
        this.codigoIngresso = codigoIngresso;
        this.tipoIngresso = tipoIngresso;
        this.cliente = cliente;
        this.evento = evento;
        this.lote = lote;
    }

    public long getCodigoIngresso() {
        return codigoIngresso;
    }

    public TipoIngresso getTipoIngresso() {
        return tipoIngresso;
    }

    public Cliente getCliente() {
        return cliente;
    }

    public Evento getEvento() {
        return evento;
    }

    public Lote getLote() {
        return lote;
    }

    public void setTipoIngresso(TipoIngresso tipoIngresso) {
        this.tipoIngresso = tipoIngresso;
    }

    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }
    
    
    
}
