﻿using System.Collections.Generic;
using AccesoDatos;
using Entidades;
using Repositorios;

namespace Servicios
{
    public class EncuestaServicio
    {
        private EncuestaRepositorio _repositorio;

        public EncuestaServicio()
        {
            _repositorio = new EncuestaRepositorio(AccesoADatos.Instance);
        }

        public List<Encuesta> ObtenerEncuestas()
        {
            return _repositorio.ObtenerTodos();
        }

        public void GuardarEncuesta(Encuesta encuesta)
        {
            _repositorio.Guardar(encuesta);
        }

        public void ModificarEncuesta(Encuesta encuesta)
        {
            _repositorio.Guardar(encuesta);
        }

        public void EliminarEncuesta(Encuesta encuesta)
        {
            _repositorio.Eliminar(encuesta.Id);
        }

        public Encuesta ObtenerEncuestaVigente()
        {
            return _repositorio.ObtenerMasReciente();
        }

        public int ObtenerCalificacionFinal(List<Calificacion> calificaciones)
        {
            throw new System.NotImplementedException();
        }

        public List<Pregunta> ObtenerPreguntasDeEncuesta(Encuesta encuesta)
        {
            return _repositorio.ObtenerPreguntasDeEncuesta(encuesta);
        }
    }
}