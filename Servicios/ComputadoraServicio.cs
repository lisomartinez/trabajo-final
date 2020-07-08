﻿using System;
using System.Collections.Generic;
using AccesoDatos;
using Entidades;
using Repositorios;

namespace Servicios
{
    public class ComputadoraServicio
    {
        private ComputadoraRepositorio _repositorio;

        public ComputadoraServicio()
        {
            _repositorio = new ComputadoraRepositorio(AccesoADatos.Instance);
        }

        public List<Computadora> ObtenerTodas()
        {
            return _repositorio.ObtenerTodos();
        }

        public void CrearComputadora(Computadora computadora)
        {
            _repositorio.Guardar(computadora);
        }

        public void ActualizarComputadora(Computadora computadora)
        {
            _repositorio.Actualizar(computadora);
        }

        public void EliminarComputadora(Computadora computadora)
        {
            _repositorio.Eliminar(computadora.Id);
        }

        public void ActualizarSoftwareComputadora(Computadora computadora)
        {
            _repositorio.Actualizar(computadora);
        }

        public void EliminarComponenteDeComputadora(Computadora computadora, Componente componente)
        {
            throw new NotImplementedException();
        }

        public void EliminarSoftwareDeComputadora(Computadora computadora, Software software)
        {
            throw new NotImplementedException();
        }

        public List<Computadora> ObtenerComputadorasSinAsignar()
        {

            throw new NotImplementedException();

        }
    }
}