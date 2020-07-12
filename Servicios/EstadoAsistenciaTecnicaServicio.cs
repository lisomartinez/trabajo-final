using System;
using System.Collections.Generic;
using Entidades;

namespace Servicios
{
    public class EstadoAsistenciaTecnicaServicio
    {
        private EstadoAsistenciaRepositorio _repositorio;

        public EstadoAsistenciaTecnicaServicio()
        {
            _repositorio = new EstadoAsistenciaRepositorio();
        }

        public List<EstadoAsistenciaTecnica> ObtenerTodos()
        {
            return _repositorio.ObtenerTodos();
        }

        public void EliminarEstado(EstadoAsistenciaTecnica estado)
        {
            _repositorio.Eliminar(estado.Id);
        }

        public void Actualizar(EstadoAsistenciaTecnica estado)
        {
            _repositorio.Actualizar(estado);
        }

        public void Guardar(EstadoAsistenciaTecnica estado)
        {
            _repositorio.Guardar(estado);
        }
    }
}