using Microsoft.EntityFrameworkCore;

public class ScheduleSystemContext : DbContext
{
    public ScheduleSystemContext(DbContextOptions<ScheduleSystemContext> options) : base(options) { }

    public DbSet<Maestros> Maestros { get; set; }
    public DbSet<Materias> Materias { get; set; }
    public DbSet<Grados> Grados { get; set; }
    public DbSet<Grupos> Grupos { get; set; }
    public DbSet<HoraInicio> HoraInicios { get; set; }
    public DbSet<HoraFin> HoraFins { get; set; }
    public DbSet<Horario> Horarios { get; set; }
}
