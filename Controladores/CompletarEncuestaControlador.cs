using System;
using System.Collections.Generic;
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
        private Dictionary<int, RespuestaModelo> _respuestas;

        public CompletarEncuestaControlador(ICompletarEncuestaVista vista, AsistenciaTecnicaModelo asistenciaTecnicaModelo)
        {
            _vista = vista;
            _asistenciaTecnicaModelo = asistenciaTecnicaModelo;
            _respuestas = new Dictionary<int, RespuestaModelo>();
        }

        private void CompletarEncuesta()
        {
            try
            {
                var calificacions = _respuestas.Select(r => new Calificacion(r.Key, r.Value.Puntaje)).ToList();
                int calificacionFinal = _encuestaServicio.Calificar(calificacions);
                _asistenciaTecnicaModelo.Calificacion = calificacionFinal;
                _asistenciaTecnicaServicio.CalificarAsistencia(_asistenciaTecnicaModelo.ToEntity());
            }
            catch (Exception e)
            {
                _vista.MostrarException(e);
            }
        }

        public void MostrarPreguntas()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.USUARIO) return;
                _respuestas.Clear();
                Encuesta encuesta = _encuestaServicio.ObtenerEncuestaVigente();
                var preguntas = encuesta.Preguntas
                    .Select(PreguntaModelo.From)
                    .OrderBy(p => p.Numero)
                    .ToList();
                _respuestas = preguntas.ToDictionary(p => p.Numero, p => new RespuestaModelo(0, false));
                _vista.Preguntas = preguntas;
            }
            catch (Exception e)
            {
                _vista.MostrarException(e);
            }
        }

        public void MostrarPregunta()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.USUARIO) return;
                var seleccionada = _vista.PreguntaSeleccionada;
                _vista.PreguntaNro = seleccionada.Numero;
                _vista.PreguntaTexto = seleccionada.Texto;
            }
            catch (Exception e)
            {
                _vista.MostrarException(e);
            }
        }

        public void ResponderPregunta()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.USUARIO) return;
                ValidarCampos();
                var seleccionada = _vista.PreguntaSeleccionada;
                var respuesta = _respuestas[seleccionada.Numero];
                var puntaje = _vista.Respuesta;
                respuesta.Puntaje = puntaje;
                respuesta.Respondida = true;
            }
            catch (Exception e)
            {
                _vista.MostrarException(e);
            }
        }

        public void EnviarCalificacion()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.USUARIO) return;
                var completa = _respuestas.Values.Any(r => !r.Respondida);
                if (!completa) throw new NotImplementedException();
                CompletarEncuesta();
            }
            catch (Exception e)
            {
                _vista.MostrarException(e);
            }
            
        }

        private void ValidarCampos()
        {
            throw new NotImplementedException();
        }
    }
}