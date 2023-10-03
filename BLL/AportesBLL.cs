using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Yokaira_AP1_P1.DAL;
using Yokaira_AP1_P1.Models;

namespace Yokaira_AP1_P1.BLL
{
    public class AportesBLL
    {
        public Context _context { get; set; }
        public AportesBLL(Context context)
        {
            _context = context;
        }

        public bool Existe(int aporteId)
        {
            return _context.aporte.Any(a => a.AporteId == aporteId);
        }

        public bool Insertar(Aportes aportes)
        {
            _context.aporte.Add(aportes);
            return _context.SaveChanges() > 0;
        }
        public bool Guardar( Aportes aportes)
        {
            if (!Existe(aportes.AporteId))
                return Insertar(aportes);
            else
                return Modificar(aportes);
        }
        public bool Modificar(Aportes aportes)
        {
            _context.aporte.Entry(_context.aporte.Find(aportes)!).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
        public bool Eliminar(Aportes aportes)
        {
            _context.aporte.Remove(aportes);
            int eliminado = _context.SaveChanges();
            return eliminado > 0;
        }

        public Aportes? Buscar(int aporteId)
        {
            return _context.aporte.Where(a => a.AporteId == aporteId)
                .AsNoTracking()
                .SingleOrDefault();
        }
        public List<Aportes> Listar(Expression<Func<Aportes, bool>> Criterio)
        {
            return _context.aporte
                .Where(Criterio)
                .AsNoTracking().ToList();
        }
    }
}
