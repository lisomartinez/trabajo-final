using System.Collections.Generic;
using AccesoDatos;
using Entidades;
using Repositorios;

namespace Servicios
{
    public class TipoProblemaServicio
    {
        private TipoProblemaRepositorio _repositorio;

        public TipoProblemaServicio()
        {
            _repositorio = new TipoProblemaRepositorio(AccesoADatos.Instance);
        }

        public List<TipoProblema> ObtenerTodos()
        {
            return _repositorio.ObtenerTodos();
        }
    }
}