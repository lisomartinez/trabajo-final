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
        public const string ID = "@Id";
        public const string DURACION = "@Duracion";
        public const string TECNICO = "@TecnicoId";
        private const string GuardarTurno = "GuardarTurno";
        private const string ActualizarTurno = "ActualizarTurno";
        private const string ObtenerTurnoPorId = "ObtenerTurnoPorId";
        private const string ObtenerTodosTurno = "ObtenerTodosTurno";
        private const string EliminarTurnoPorId = "EliminarTurnoPorId";
        private const string ObtenerTurnoPorFechaMayorOIgual = "ObtenerTurnoPorFechaMayorOIgual";

        public TurnoRepositorio() : base(AccesoADatos.Instance)
        {
        }

        public override Turno Guardar(Turno entidad)
        {
            var id = _accesoADatos.Escribir(GuardarTurno, CrearParametrosGuardar(entidad));
            entidad.Id = new TurnoId(id);
            return entidad;
        }

        private Dictionary<string, object> CrearParametrosGuardar(Turno entidad)
        {
            var parametros = new Dictionary<string, object>
            {
                
                {"@Inicio", entidad.Inicio },
                {DURACION, entidad.Duracion},
                {TECNICO, entidad.Tecnico.Id.AsInt()},
            };

            if (!entidad.Id.Equals(new TurnoId(-1)))
            {
                parametros.Add(ID, entidad.TurnoId.AsInt());
            }

            return parametros;
        }

        public override void Actualizar(Turno entidad)
        {
            var id = _accesoADatos.Escribir(ActualizarTurno, CrearParametrosGuardar(entidad));
        }

        public override Turno Obtener(Id id)
        {
            return _accesoADatos.Leer(ObtenerTurnoPorId, new Dictionary<string, object> {{ID, id.AsInt()}})
                .AsEnumerable()
                .Select(ToTurno)
                .ToList()[0];
        }

        private Turno ToTurno(DataRow fila)
        {
            return new Turno(
                id: new TurnoId(fila["Id"] as int? ?? 0),
                inicio: fila["Inicio"] as DateTime? ?? new DateTime(),
                duracion: fila["Duracion"] as TimeSpan? ?? TimeSpan.Zero,
                tecnico: ToTecnico(fila)
            );
        }


        private Usuario ToTecnico(DataRow fila)
        {
            return new Usuario(
                legajo: new Legajo(fila["LegajoT"] as int? ?? 0),
                nombre: fila["NombreT"] as string,
                apellido: fila["ApellidoT"] as string,
                rol: Rol.TECNICO,
                categoria: ToJerarquiaTecnico(fila),
                computadora: ComputadoraSoloId(fila, Rol.TECNICO)
            );
        }

        private Jerarquia ToJerarquiaTecnico(DataRow fila)
        {
            return new Jerarquia(
                id: new JerarquiId(fila["IdTJ"] as int? ?? 0),
                denominacion: fila["DenominacionTJ"] as string,
                valor: fila["ValorTJ"] as int? ?? 0
            );
        }

        private static Computadora ComputadoraSoloId(DataRow fila, Rol rol)
        {
            var id = rol == Rol.USUARIO ? "ComputadoraIdU" : "ComputadoraIdT";
            return new Computadora(new ComputadoraId(fila[id] as int? ?? 0));
        }

        public override List<Turno> ObtenerTodos()
        {
            return _accesoADatos.Leer(ObtenerTodosTurno, null)
                .AsEnumerable()
                .Select(ToTurno)
                .ToList();
        }

        public override void Eliminar(Id id)
        {
            _accesoADatos.Escribir(EliminarTurnoPorId, new Dictionary<string, object> {{ID, id.AsInt()}});
        }

        public List<Turno> ObtenerTurnosDesdeFecha(DateTime hoy)
        {
            return _accesoADatos.Leer(ObtenerTurnoPorFechaMayorOIgual, ParametrosFecha(hoy))
                .AsEnumerable()
                .Select(ToTurno)
                .ToList();
        }

        private Dictionary<string, object> ParametrosFecha(DateTime hoy)
        {
            return new Dictionary<string, object>
            {
                {"@Fecha", hoy }
            };
        }

        public List<Turno> ObtenerPorSolicitud(SolicitudAsistenciaTecnica solicitud)
        {
            return _accesoADatos.Leer("ObtenerTurnoPorSolicitud", ParametrosPorSolicitud(solicitud) )
                .AsEnumerable()
                .Select(ToTurno)
                .ToList();
        }

        private Dictionary<string, object> ParametrosPorSolicitud(SolicitudAsistenciaTecnica solicitud)
        {
            return new Dictionary<string, object>
            {
                { "@SolicitudId", solicitud.Id.AsInt()}
            };
        }

        public Turno GuardarConReserva(SolicitudAsistenciaTecnica solicitud, Turno turno)
        {
            var guardado = Guardar(turno);
            _accesoADatos.Escribir("GuardarTurnoConReserva", CrearParametrosGuardarConReserva(solicitud, guardado));
            return guardado;
        }

        private Dictionary<string, object> CrearParametrosGuardarConReserva(SolicitudAsistenciaTecnica solicitud, Turno turno)
        {
            return new Dictionary<string, object>
            {
                {"@TurnoId", turno.Id.AsInt() },
                {"@SolicitudId", solicitud.Id.AsInt() }
            };
        }


        public void EliminarReserva(SolicitudAsistenciaTecnica solicitud)
        {
            _accesoADatos.Escribir("EliminarReserva", ParametrosEliminarReserva(solicitud));
        }

        private Dictionary<string, object> ParametrosEliminarReserva(SolicitudAsistenciaTecnica solicitud)
        {
            return new Dictionary<string, object>
            {
                {"@SolicitudId", solicitud.Id.AsInt() }
            };
        }
    }
}