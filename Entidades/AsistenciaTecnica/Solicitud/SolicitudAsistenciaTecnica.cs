namespace Entidades
{
    public class SolicitudAsistenciaTecnica : Entidad
    {
        public NumeroSolicitud Numero { get; }
        public Usuario usuario { get; }
        public string Descripcion { get; }
        public TipoProblema TipoProblema { get; }
        public Turno Turno { get; set; }

        public SolicitudAsistenciaTecnica(NumeroSolicitud id) : base(id)
        {
        }

        public SolicitudAsistenciaTecnica(Usuario usuario, string descripcion, TipoProblema tipoProblema) : base(Entidades.Id.Empty)
        {
            this.usuario = usuario;
            Descripcion = descripcion;
            TipoProblema = tipoProblema;
        }

        public AsistenciaTecnica CrearAsistencia()
        {
            throw new System.NotImplementedException();
        }
    }
}