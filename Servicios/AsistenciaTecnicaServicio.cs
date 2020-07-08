using System;
using System.Collections.Generic;
using AccesoDatos;
using Controladores;
using Entidades;
using Repositorios;

namespace Servicios
{
    public class AsistenciaTecnicaServicio
    {
        private AsistenciaTecnicaRepositorio _asistenciaTecnicaRepositorio;
        private EstadisticasAsistenciaTecnicaServicio _estadisticasAsistenciasTecnicas;

        public AsistenciaTecnicaServicio()
        {
            _asistenciaTecnicaRepositorio = new AsistenciaTecnicaRepositorio(AccesoADatos.Instance);
            _estadisticasAsistenciasTecnicas = new EstadisticasAsistenciaTecnicaServicio();
        }

        public void ActualizarEstado(AsistenciaTecnica asistenciaTecnica)
        {
            ComputarEstadisticas(asistenciaTecnica);
        }

        private EstadisticasAsistenciasTecnicas ComputarEstadisticas(AsistenciaTecnica asistenciaTecnica)
        {
            _estadisticasAsistenciasTecnicas.ComputarEstadisticasActualizacionEstado(asistenciaTecnica);
            throw new NotImplementedException();
        }

        public List<AsistenciaTecnica> ObtenerAsistenciaTecnico(Legajo usuarioLegajo)
        {
            throw new NotImplementedException();
        }

        public List<AsistenciaTecnica> ObtenerAsistenciasUsuario(Legajo usuarioLegajo)
        {
            throw new NotImplementedException();
        }

        public List<AsistenciaTecnica> ObtenerAsistenciasJefe(Legajo usuarioLegajo)
        {
            throw new NotImplementedException();
        }

        public void Modificar(AsistenciaTecnica toEntity)
        {
            throw new NotImplementedException();
        }

        public void EliminarAsistencia(CodigoAsistencia codigoAsistencia)
        {
            throw new NotImplementedException();
        }

        public void CalificarAsistencia(AsistenciaTecnica seleccionada)
        {
            throw new NotImplementedException();
        }

        public void ReemplazarComponente(AsistenciaTecnica asistenciaTecnica, Componente componente)
        {
            throw new NotImplementedException();
        }
    }
}