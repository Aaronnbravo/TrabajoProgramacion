package com.idra.sistematurnos.entidades;

import java.time.LocalDate;
import java.time.LocalTime;

public class Turno {
    private int idTurno;
    private Cliente cliente;
    private Peluquero peluquero;
    private Servicio servicio;
    private LocalDate fecha;
    private LocalTime hora;
    private String estado;
    private String observaciones;

    // Constructores, Getters y Setters
    public Turno() {}
    
    public Turno(Cliente cliente, Peluquero peluquero, Servicio servicio, LocalDate fecha, LocalTime hora, String estado, String observaciones) {
        this.cliente = cliente;
        this.peluquero = peluquero;
        this.servicio = servicio;
        this.fecha = fecha;
        this.hora = hora;
        this.estado = estado;
        this.observaciones = observaciones;
    }
    
    // Getters y Setters
    public int getIdTurno() { return idTurno; }
    public void setIdTurno(int idTurno) { this.idTurno = idTurno; }
    
    public Cliente getCliente() { return cliente; }
    public void setCliente(Cliente cliente) { this.cliente = cliente; }
    
    public Peluquero getPeluquero() { return peluquero; }
    public void setPeluquero(Peluquero peluquero) { this.peluquero = peluquero; }
    
    public Servicio getServicio() { return servicio; }
    public void setServicio(Servicio servicio) { this.servicio = servicio; }
    
    public LocalDate getFecha() { return fecha; }
    public void setFecha(LocalDate fecha) { this.fecha = fecha; }
    
    public LocalTime getHora() { return hora; }
    public void setHora(LocalTime hora) { this.hora = hora; }
    
    public String getEstado() { return estado; }
    public void setEstado(String estado) { this.estado = estado; }
    
    public String getObservaciones() { return observaciones; }
    public void setObservaciones(String observaciones) { this.observaciones = observaciones; }
}