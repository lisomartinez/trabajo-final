using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using AccesoDatos;
using Entidades;
using Microsoft.Win32;

namespace Servicios
{
    public class ColaTurnosRepositorio
    {
        private AccesoADatos _accesoDatos = AccesoADatos.Instance;

        public List<EntradaCola> ObtenerEntradas()
        {
            return _accesoDatos.Leer("ObtenerColaTurnos", null)
                .AsEnumerable()
                .Select(ToEntradaCola)
                .ToList();
        }

        private EntradaCola ToEntradaCola(DataRow fila)
        {
            return new EntradaCola(
                id: new ColaTurnoId(fila["Id"] as int? ?? 0),
                turno: ToTurno(fila),
                solicitud: ToSolicitud(fila)
            );
        }

        private SolicitudAsistenciaTecnica ToSolicitud(DataRow fila)
        {
            return new SolicitudAsistenciaTecnica(
                id: new NumeroSolicitud(fila["SolicitudId"] as int? ?? 0),
                tipoProblema: ToTipoProblema(fila),
                descripcion: fila["Descripcion"] as string,
                usuario: new Usuario(new Legajo(fila["LegajoU"] as int? ?? 0), ToJerarquiaUsuario(fila), Rol.USUARIO)
            );
        }

        private TipoProblema ToTipoProblema(DataRow fila)
        {
            return new TipoProblema(
                id: new TipoProblemaId(fila["CodigoTP"] as int? ?? 0),
                nombre: fila["NombreTP"] as string
            );
        }

        private Jerarquia ToJerarquiaUsuario(DataRow fila)
        {
            return new Jerarquia(
                id: new JerarquiId(fila["IdUJ"] as int? ?? 0),
                denominacion: fila["DenominacionUJ"] as string,
                valor: fila["ValorUJ"] as int? ?? 0
            );
        }

        private Turno ToTurno(DataRow fila)
        {
            return new Turno(
                id: new TurnoId(fila["TurnoId"] as int? ?? 0),
                inicio: fila["InicioT"] as DateTime? ?? DateTime.Now,
                duracion: fila["DuracionT"] as TimeSpan? ?? TimeSpan.Zero,
                tecnico: new Usuario(new Legajo(fila["LegajoT"] as int? ?? 0), ToJerarquiaTecnico(fila), Rol.TECNICO)
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

        public void GuardarCola(ColaTurnos colaTurnos)
        {
            var lookup = colaTurnos.Entradas
                .GroupBy(e => e.Id.AsInt() == 0)
                .ToDictionary(n => n.Key, ne => ne.ToList());
            var hayNuevos = lookup.TryGetValue(true, out var nuevos);

            var hayParaactualizar = lookup.TryGetValue(false, out var actualizar);
            string consulta = "";
            if (hayNuevos)
                consulta += GuardarNuevos(nuevos);
            if (hayParaactualizar)
                consulta += ActualizarExistentes(actualizar);
            if (consulta.Length != 0)
            {
                _accesoDatos.Escribir(consulta, null);
            }
        }

        private string ActualizarExistentes(List<EntradaCola> actualizar)
        {
            var sb = new StringBuilder();
            actualizar?.ForEach(en =>
            {
                sb.Append(
                    $"UPDATE EntradaCola TurnoId = {en.Turno.Id.AsInt()}, SolicitudId = {en.Solicitud.Id.AsInt()}  SET WHERE Id = {en.Id.AsInt()};\n");
            });
            return sb.ToString();
        }

        private string GuardarNuevos(List<EntradaCola> nuevos)
        {
            var sb = new StringBuilder();
            nuevos?.ForEach(en =>
            {
                sb.Append(
                    $"INSERT INTO EntradaSolicitud(TurnoId, SolicitudId) VALUES({en.Turno.Id.AsInt()}, {en.Solicitud.Id.AsInt()}); \n");
            });
            return sb.ToString();
        }
    }
}