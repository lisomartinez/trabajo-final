using System;
using System.Collections.Generic;
using AccesoDatos;
using Entidades;
using Repositorios;
using Reposotorios;

namespace Servicios
{
    public class ComponenteServicio
    {
        private ComponenteRepositorio _repositorio;

        public ComponenteServicio()
        {
            _repositorio = new ComponenteRepositorio(AccesoADatos.Instance);
        }

        public List<Componente> ObtenerTodos()
        {
            return _repositorio.ObtenerTodos();
        }

        public void Guardar(Componente componente)
        {
            _repositorio.Guardar(componente);
        }

        public void Modificar(Componente componente)
        {
            _repositorio.Actualizar(componente);
        }

        public void Eliminar(Componente componente)
        {
            _repositorio.Eliminar(componente.Id);
        }
    }
}