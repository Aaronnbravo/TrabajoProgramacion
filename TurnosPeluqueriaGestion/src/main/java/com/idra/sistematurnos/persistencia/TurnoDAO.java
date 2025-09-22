package com.idra.sistematurnos.persistencia;

import com.idra.sistematurnos.entidades.Turno;
import java.time.LocalDate;
import java.util.List;

public interface TurnoDAO {
    void crear(Turno turno) throws Exception;
    Turno leer(int idTurno) throws Exception;
    void actualizar(Turno turno) throws Exception;
    void eliminar(int idTurno) throws Exception;
    List<Turno> listarTodos() throws Exception;
    List<Turno> listarPorPeluqueroYFecha(int idPeluquero, LocalDate fecha) throws Exception;
    boolean existeTurnoEnHorario(int idPeluquero, int idTurnoAExcluir) throws Exception;
}