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

        public void Guardar(TipoProblema tipoProblema)
        {
            _repositorio.Guardar(tipoProblema);
        }

        public void Eliminar(Id id)
        {
            _repositorio.Eliminar(id);
        }

        public void Actualizar(TipoProblema tipoProblema)
        {
            _repositorio.Actualizar(tipoProblema);
        }
    }
}