using System;
using System.Collections.Generic;
using AccesoDatos;
using Entidades;

namespace Repositorios
{
    public class EstadisticasTecnicosRepositorio
    {
        private AccesoADatos _accesoADatos;

        public EstadisticasTecnicosRepositorio(AccesoADatos instance)
        {
            _accesoADatos = instance;
        }

        public Dictionary<TipoProblemaId, EstadisticaTecnico> ObtenerPorTipoProblemaId(Legajo legajo)
        {
            throw new NotImplementedException();
        }
    }
}