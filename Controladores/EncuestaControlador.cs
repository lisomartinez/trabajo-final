using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;
using Modelo;
using Servicios;
using Vistas;


namespace Controladores
{
    public class EncuestaControlador
    {
        private IEncuestaVista _vista;
        private EncuestaServicio _servicio;

        public EncuestaControlador(IEncuestaVista vista)
        {
            _vista = vista;
            _servicio = new EncuestaServicio();
        }

        public void MostrarEncuestas()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE )  return;

                _vista.Encuestas = _servicio.ObtenerEncuestas().Select(EncuestaModelo.From).ToList();
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void MostrarEncuesta()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                var seleccionada = _vista.EncuestaSeleccionada;
                _vista.Codigo = seleccionada.Codigo;
                _vista.FechaCreacion = seleccionada.FechaCreacion;
                _vista.Vigente = seleccionada.Vigente;
                _vista.Preguntas = _servicio.ObtenerPreguntasDeEncuesta(seleccionada.ToEntity())
                    .Select(PreguntaModelo.From).ToList();

            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void MostrarPregunta()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                var seleccionada = _vista.PreguntaSeleccionada;
                _vista.PreguntaNumero = seleccionada.Numero;
                _vista.PreguntaTexto = seleccionada.Texto;
                _vista.PesoRelativo = seleccionada.PesoRelativo;
                _vista.PuntajeMaximo = seleccionada.PuntajeMaximo;
                _vista.PuntajeMinimo = seleccionada.PuntajeMinimo;

            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void AgregarPregunta()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                ValidarCampos();

                var pregunta = new PreguntaModelo (
                    numero: _vista.PreguntaNumero,
                    texto: _vista.PreguntaTexto,
                    pesoRelativo: _vista.PesoRelativo,
                    puntajeMaximo: _vista.PuntajeMaximo,
                    puntajeMinimo: _vista.PuntajeMinimo
                );

                _vista.EncuestaSeleccionada.AgregarPregunta(pregunta);

            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void ModificarPregunta()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                ValidarCampos();

                var preguntaNueva = new PreguntaModelo(
                    numero: _vista.PreguntaNumero,
                    texto: _vista.PreguntaTexto,
                    pesoRelativo: _vista.PesoRelativo,
                    puntajeMaximo: _vista.PuntajeMaximo,
                    puntajeMinimo: _vista.PuntajeMinimo
                );

                var preguntaVieja = _vista.PreguntaSeleccionada;
                var indexOf = _vista.Preguntas.IndexOf(preguntaVieja);
                _vista.Preguntas[indexOf] = preguntaNueva;
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void EliminarPregunta()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;

                var seleccionada = _vista.PreguntaSeleccionada;
                _vista.Preguntas.Remove(seleccionada);
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void CrearEncuesta()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                ValidarCampos();

                var encuesta =  new Encuesta(
                    codigoEncuesta: new CodigoEncuesta(_vista.Codigo),
                    fechaCreacion: _vista.FechaCreacion,
                    vigente: true,
                    preguntas: _vista.Preguntas.Select(p => p.ToEntity()).ToList()
                    );

                _servicio.GuardarEncuesta(encuesta);
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        private void ValidarCampos()
        {
            throw new NotImplementedException();
        }

        public void ModificarEncuesta()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;
                ValidarCampos();

                var encuesta = new Encuesta(
                    codigoEncuesta: new CodigoEncuesta(_vista.Codigo),
                    fechaCreacion: _vista.FechaCreacion,
                    vigente: _vista.Vigente,
                    preguntas: _vista.Preguntas.Select(p => p.ToEntity()).ToList()
                );
                _servicio.ModificarEncuesta(encuesta);
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }

        public void EliminarEncuestas()
        {
            try
            {
                if (Sesion.Instance.Rol != Rol.JEFE) return;

                var seleccionada = _vista.EncuestaSeleccionada.ToEntity();
                _servicio.EliminarEncuesta(seleccionada);
            }
            catch (Exception e)
            {
                _vista.MostrarExcepcion(e);
            }
        }
    }
}