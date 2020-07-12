using System;
using System.Collections.Generic;
using AccesoDatos;
using Entidades;
using Repositorios;

namespace Servicios
{
    public class AsistenciaTecnicaServicio
    {
        private AsistenciaTecnicaRepositorio _repositorio;
        private EstadisticasAsistenciaTecnicaServicio _estadisticasAsistenciasTecnicas;

        public AsistenciaTecnicaServicio()
        {
            _repositorio = new AsistenciaTecnicaRepositorio(AccesoADatos.Instance);
            _estadisticasAsistenciasTecnicas = new EstadisticasAsistenciaTecnicaServicio();
        }

        public void ActualizarEstado(AsistenciaTecnica asistenciaTecnica)
        {
            ComputarEstadisticas(asistenciaTecnica);
        }

        private void ComputarEstadisticas(AsistenciaTecnica asistenciaTecnica)
        {
           _estadisticasAsistenciasTecnicas.ComputarEstadisticasActualizacionEstado(asistenciaTecnica);
        }

        public List<AsistenciaTecnica> ObtenerAsistenciaTecnico(Legajo legajo)
        {
           return _repositorio.ObtenerPorTecnico(legajo);
        }

        public List<AsistenciaTecnica> ObtenerAsistenciasUsuario(Legajo legajo)
        {
           return _repositorio.ObtenerPorLegajo(legajo);
        }

        public List<AsistenciaTecnica> ObtenerAsistenciasJefe(Legajo legajo)
        {
           return _repositorio.ObtenerTodos();
        }

        public void Modificar(AsistenciaTecnica asistencia)
        {
            _repositorio.Actualizar(asistencia);
        }

        public void EliminarAsistencia(CodigoAsistencia codigoAsistencia)
        {
            _repositorio.Eliminar(codigoAsistencia);
        }

        public void CalificarAsistencia(AsistenciaTecnica asistencia)
        {
            _repositorio.Actualizar(asistencia);
        }

        public void ReemplazarComponente(AsistenciaTecnica asistencia, Componente anterior, Componente componenteNuevo)
        {
            asistencia.ReemplazarComponente(anterior, componenteNuevo);
        }
    }
}