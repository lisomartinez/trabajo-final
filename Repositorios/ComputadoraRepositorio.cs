using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using AccesoDatos;
using Entidades;

namespace Repositorios
{
    public class ComputadoraRepositorio : SqlRepositorio<Computadora>
    {
        private const string ID = "@Id";
        private const string MARCA = "@Marca";
        private const string MODELO = "@Modelo";

        public ComputadoraRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override Computadora Guardar(Computadora entidad)
        {
            var id = _accesoADatos.Escribir("GuardarComputadora", Parametros(entidad));
            entidad.Id = new ComputadoraId(id);
            return entidad;
        }

        private Dictionary<string, object> Parametros(Computadora entidad)
        {
            return new Dictionary<string, object>
            {
                {ID, entidad.Id.AsInt() },
                {MARCA, entidad.Marca },
                {MODELO,  entidad.Modelo }
            };
        }

        public override void Actualizar(Computadora entidad)
        {
            _accesoADatos.Escribir("ActualizarComputadora", Parametros(entidad));
        }

        public override Computadora Obtener(Id id)
        {
            return _accesoADatos.Leer("ObtenerPorId", ParametroId(id))
                .AsEnumerable()
                .Select(ToComputadora)
                .ToList()[0];
        }

        private Computadora ToComputadora(DataRow fila)
        {
            return new Computadora(
                id: new ComputadoraId(fila["id"] as int? ?? 0),
                marca: fila["marca"] as string,
                modelo: fila["modelo"] as string,
                componentes: new List<Componente>(),
                software: new List<Software>()
                );
        }

        private Dictionary<string, object> ParametroId(Id id)
        {
            return new Dictionary<string, object>
            {
                {ID, id.AsInt() },
            };
        }

        public override List<Computadora> ObtenerTodos()
        {
            return _accesoADatos.Leer("ObtenerTodosComputadora", null)
                .AsEnumerable()
                .Select(ToComputadora)
                .ToList();
        }

        public override void Eliminar(Id id)
        {
            _accesoADatos.Escribir("EliminarPorId", ParametroId(id));
        }
    }
}