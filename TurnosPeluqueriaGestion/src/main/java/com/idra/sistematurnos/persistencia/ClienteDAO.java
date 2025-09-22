package com.idra.sistematurnos.persistencia;

import com.idra.sistematurnos.entidades.Cliente;
import java.util.List;

public interface ClienteDAO {
    void crear(Cliente cliente) throws Exception;
    Cliente leer(int idCliente) throws Exception;
    void actualizar(Cliente cliente) throws Exception;
    void eliminar(int idCliente) throws Exception;
    List<Cliente> listarTodos() throws Exception;
    List<Cliente> listarActivos() throws Exception;
}