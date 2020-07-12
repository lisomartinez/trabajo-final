namespace Entidades
{
    public class SolicitudAsistenciaTecnica : Entidad
    {
        public NumeroSolicitud Numero => new NumeroSolicitud(Id.AsInt());
        public Usuario Usuario { get; }
        public string Descripcion { get; }
        public TipoProblema TipoProblema { get; }
        public Turno Turno { get; set; }

        public SolicitudAsistenciaTecnica(NumeroSolicitud id) : base(id)
        {
        }

        public SolicitudAsistenciaTecnica(Usuario usuario, string descripcion, TipoProblema tipoProblema) : base(Entidades.Id.Empty)
        {
            Usuario = usuario;
            Descripcion = descripcion;
            TipoProblema = tipoProblema;
        }

        public SolicitudAsistenciaTecnica(Usuario usuario, string descripcion, TipoProblema tipoProblema, Turno turno) : base(Entidades.Id.Empty)
        {
            Usuario = usuario;
            Descripcion = descripcion;
            TipoProblema = tipoProblema;
            Turno = turno;
        }

        public SolicitudAsistenciaTecnica(NumeroSolicitud id, Usuario usuario, string descripcion, TipoProblema tipoProblema) : base(id)
        {
            Usuario = usuario;
            Descripcion = descripcion;
            TipoProblema = tipoProblema;
        }

        public SolicitudAsistenciaTecnica(NumeroSolicitud id, Usuario usuario, string descripcion, TipoProblema tipoProblema, Turno turno) : base(id)
        {
            Usuario = usuario;
            Descripcion = descripcion;
            TipoProblema = tipoProblema;
            Turno = turno;
        }


        public void AsignarTurno(Turno turno)
        {
            Turno = turno;
        }

        public AsistenciaTecnica CrearAsistencia()
        {
            return new AsistenciaTecnica(new CodigoAsistencia(Id.AsInt()), Turno.Inicio, Usuario, Turno.Tecnico, TipoProblema, Descripcion);
        }
    }
}