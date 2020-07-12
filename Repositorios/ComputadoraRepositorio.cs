using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using AccesoDatos;
using Entidades;

namespace Repositorios
{
    public class ComputadoraRepositorio : SqlRepositorio<Computadora>
    {
        private const string ID = "@Id";
        private const string MARCA = "@Marca";
        private const string MODELO = "@Modelo";

        private const string GuardarComputadora = "GuardarComputadora";
        private const string ActualizarComputadora = "ActualizarComputadora";
        private const string ObtenerTodosComputadora = "ObtenerTodosComputadora";
        private const string EliminarComputadoraPorId = "EliminarComputadoraPorId";
        private const string ObtenerComponentesPorComputadoraId = "ObtenerComponentesPorComputadoraId";

        private const string ObtenerSoftwarePorComputadoraId = "ObtenerSoftwarePorComputadoraId";
        

        public ComputadoraRepositorio(AccesoADatos accesoADatos) : base(accesoADatos)
        {
        }

        public override Computadora Guardar(Computadora entidad)
        {
            var id = _accesoADatos.Escribir(GuardarComputadora, Parametros(entidad));
            entidad.Id = new ComputadoraId(id);
            _accesoADatos.Escribir(GuardaComponenteComputadora(entidad.Id.AsInt(), entidad.Componentes), null);
            _accesoADatos.Escribir(GuardaSoftwareComputadora(entidad.Id.AsInt(), entidad.Software), null);
            return entidad;
        }

        private string GuardaSoftwareComputadora(int id, List<Software> softwares)
        {
            var sb = new StringBuilder();
            sb.Append("INSERT INTO ComputadoraSoftware(ComputadoraId,CodigoSoftware) ");
            softwares.Select(c => c.Id.AsInt())
                .ToList()
                .ForEach(cIds => sb.Append($"VALUES({id}, {cIds}) "));
            sb.Append(";");
            return sb.ToString();
        }

        private string GuardaComponenteComputadora(int id, List<Componente> componentes)
        {
            var sb = new StringBuilder();
            sb.Append("INSERT INTO ComputadoraComponente(ComputadoraId,NumeroDeSerie) ");
            componentes.Select(c => c.Id.AsInt())
                .ToList()
                .ForEach(cIds => sb.Append($"VALUES({id}, {cIds}) "));
            sb.Append(";");
            return sb.ToString();
        }

        private Dictionary<string, object> Parametros(Computadora entidad)
        {
            return new Dictionary<string, object>
            {
                {ID, entidad.Id.AsInt()},
                {MARCA, entidad.Marca},
                {MODELO, entidad.Modelo}
            };
        }

        public override void Actualizar(Computadora entidad)
        {
            _accesoADatos.Escribir(ActualizarComputadora, Parametros(entidad));
            _accesoADatos.Escribir(ActualizarComponentesComputadora(entidad.Id.AsInt(), entidad.Componentes));
            _accesoADatos.Escribir(ActualizarSoftwareComputadora(entidad.Id.AsInt(), entidad.Software));
        }

        private string ActualizarSoftwareComputadora(int id, List<Software> softwares)
        {
            return $"DELETE FROM ComputadoraSoftware WHERE ComputadoraId = {id}; " +
                   GuardaSoftwareComputadora(id, softwares);
        }

        private string ActualizarComponentesComputadora(int id, List<Componente> componentes)
        {
            return $"DELETE FROM ComputadoraComponente WHERE ComputadoraId = {id}; " +
                   GuardaComponenteComputadora(id, componentes);
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
                id: new ComputadoraId(fila["Id"] as int? ?? 0),
                marca: fila["Marca"] as string,
                modelo: fila["Modelo"] as string,
                componentes: new List<Componente>(),
                software: new List<Software>()
            );
        }

        private Dictionary<string, object> ParametroId(Id id)
        {
            return new Dictionary<string, object>
            {
                {ID, id.AsInt()},
            };
        }

        public override List<Computadora> ObtenerTodos()
        {
            return _accesoADatos.Leer(ObtenerTodosComputadora, null)
                .AsEnumerable()
                .Select(ToComputadora)
                .ToList();
        }

        public override void Eliminar(Id id)
        {
            _accesoADatos.Escribir(EliminarComputadoraPorId, ParametroId(id));
        }

        public List<Componente> ObtenerComponentesPorComputadora(Computadora computadora)
        {
            return _accesoADatos.Leer(ObtenerComponentesPorComputadoraId, ParametroId(computadora.Id))
                .AsEnumerable()
                .Select(ToComponenteComputadora)
                .ToList();
        }

        private Componente ToComponenteComputadora(DataRow fila)
        {
            return new Componente(
                numeroDeSerie: new NumeroDeSerie(fila["NumeroDeSerie"] as int? ?? 0),
                marca: fila["Marca"] as string,
                modelo: fila["Modelo"] as string,
                especificacionTecnicas: new List<EspecificacionTecnica>()
            );
        }

        public List<Software> ObtenerSoftwarePorComputadora(Computadora computadora)
        {
            return _accesoADatos.Leer(ObtenerSoftwarePorComputadoraId, ParametroId(computadora.Id))
                .AsEnumerable()
                .Select(ToSoftwareComputadora)
                .ToList();
        }

        private Software ToSoftwareComputadora(DataRow fila)
        {
            return new Software(
                codigo: new CodigoSoftware(fila["Codigo"] as int? ?? 0),
                nombre: fila["Nombre"] as string,
                version: fila["Version"] as string,
                desarrollador: fila["Desarrollador"] as string
            );
        }

        public List<Computadora> ObtenerSinAsignar()
        {
            return _accesoADatos.Leer("ObtenerComputadorasSinAsignar", null)
                .AsEnumerable()
                .Select(ToComputadora)
                .ToList();
        }
    }
}