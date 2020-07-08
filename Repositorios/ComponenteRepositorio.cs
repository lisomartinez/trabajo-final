using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using AccesoDatos;
using Entidades;

namespace Repositorios
{
    public class ComponenteRepositorio : SqlRepositorio<Componente>
    {
        private const string NRO_SERIE = "@NroSerie";
        private const string MARCA = "@Marca";
        private const string MODELO = "@Modelo";

        public ComponenteRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
            
        }

        public override Componente Guardar(Componente entidad)
        {
            var id = _accesoADatos.Escribir("GuardarComponente", Parametros(entidad));
            entidad.Id = new NumeroDeSerie(id);
            return entidad;
        }

        private Dictionary<string, object> Parametros(Componente entidad)
        {
            return new Dictionary<string, object>
            {
                {NRO_SERIE, entidad.NumeroDeSerie.AsInt() },
                {MARCA, entidad.Marca },
                {MODELO, entidad.Modelo }
            };
        }

        public override void Actualizar(Componente entidad)
        {
            _accesoADatos.Escribir("ActualizarComponente", Parametros(entidad));
        }

        public override Componente Obtener(Id id)
        {
            return _accesoADatos.Leer("ObtenerComponentePorId", ParametroId(id))
                .AsEnumerable()
                .Select(ToComponente)
                .ToList()[0];
        }

        private Componente ToComponente(DataRow fila)
        {
            return new Componente(
                numeroDeSerie: new NumeroDeSerie(fila["nroSerie"] as int? ?? 0),
                marca: fila["marca"] as string,
                modelo: fila["modelo"] as string,
                especificacionTecnicas: new List<EspecificacionTecnica>()
                );
        }
        private Dictionary<string, object> ParametroId(Id id)
        {
            return new Dictionary<string, object>
            {
                {NRO_SERIE, id.AsInt() }
            };
        }

        public override List<Componente> ObtenerTodos()
        {
            return _accesoADatos.Leer("ObtenerTodosComponente", null)
                .AsEnumerable()
                .Select(ToComponente)
                .ToList();
        }

        public override void Eliminar(Id id)
        {
            _accesoADatos.Escribir("EliminarComponentePorId", ParametroId(id));
        }
    }
}