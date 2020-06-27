using System;
using System.Linq;
using Entidades;
using Modelo;
using Servicios;
using Vistas;

namespace Controladores
{
    public class CompletarEncuestaControlador
    {
        private ICompletarEncuestaVista _vista;
        private EncuestaServicio _encuestaServicio;
        private AsistenciaTecnicaServicio _asistenciaTecnicaServicio;
        private AsistenciaTecnicaModelo _asistenciaTecnicaModelo;

        public void CompletarEncuesta()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.USUARIO) return;
                ;
                Encuesta encuesta = _encuestaServicio.ObtenerEncuestaVigente();
                var preguntas = encuesta.Preguntas.Select(PreguntaModelo.From).ToList();
                var calificaciones = preguntas.Select(SolicitarRespuesta).ToList();
                int calificacionFinal = _encuestaServicio.Calificar(calificaciones);
                _asistenciaTecnicaModelo.Calificacion = calificacionFinal;
                _asistenciaTecnicaServicio.CalificarAsistencia(_asistenciaTecnicaModelo.ToEntity());
            }
            catch (Exception e)
            {
                _vista.MostrarException(e);
            }
        }

        private Calificacion SolicitarRespuesta(PreguntaModelo preguntaModelo)
        {
            _vista.IngresoRespuesta(preguntaModelo);
            var nota = _vista.Calificacion;
            return new Calificacion(nota);
        }
    }
}