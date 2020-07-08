using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using AccesoDatos;
using Entidades;

namespace Repositorios
{
    public class TurnoRepositorio : SqlRepositorio<Turno>
    {
        public const string ID = "@TurnoId";
        public const string DURACION = "@Duracion";
        public const string TECNICO = "@TECNICO";

        public TurnoRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override Turno Guardar(Turno entidad)
        {
            var consulta = "GuardarTurno";
            Dictionary<string, object> parametros = CrearParametrosGuardar(entidad);
            var id = _accesoADatos.Escribir(consulta, parametros);
            entidad.Id = new TurnoId(id);
            return entidad;
        }

        private Dictionary<string, object> CrearParametrosGuardar(Turno entidad)
        {
            return new Dictionary<string, object>
            {
                {ID, entidad.TurnoId.AsInt()},
                {DURACION, entidad.Duracion},
                {TECNICO, entidad.Tecnico.Id.AsInt()}
            };
        }

        public override void Actualizar(Turno entidad)
        {
            var consulta = "ActualizarTurno";
            Dictionary<string, object> parametros = CrearParametrosGuardar(entidad);
            var id = _accesoADatos.Escribir(consulta, parametros);
        }

        public override Turno Obtener(Id id)
        {
            var consulta = "ObtenerTurnoPorId";
            Dictionary<string, object> parametros = new Dictionary<string, object>{{ID, id.AsInt()}};
            return _accesoADatos.Leer(consulta, parametros)
                .AsEnumerable()
                .Select(ToTurno)
                .ToList()[0];
        }

        private Turno ToTurno(DataRow fila)
        {
            return new Turno(
                id: new TurnoId(fila["id"] as int? ?? 0),
                duracion: fila["duracion"] as TimeSpan? ?? TimeSpan.Zero,
                tecnico: ObtenerTecnico(fila["tecnicoId"] as int? ?? 0)
            );
        }

        private Usuario ObtenerTecnico(int i)
        {
            throw new NotImplementedException();
        }

        public override List<Turno> ObtenerTodos()
        {
            var consulta = "ObtenerTodosTurno";
            return _accesoADatos.Leer(consulta, null)
                .AsEnumerable()
                .Select(ToTurno)
                .ToList();
        }

        public override void Eliminar(Id id)
        {
            var consulta = "EliminarTurnoPorId";
            Dictionary<string, object> parametros = new Dictionary<string, object> { { ID, id.AsInt() } };
            _accesoADatos.Escribir(consulta, parametros);
        }
    }
}