using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

public class PrioridadesBLL
{
    private Contexto _contexto;
    public PrioridadesBLL(Contexto contexto)
    {
        _contexto = contexto;
    }
    public bool Existe(int id)
    {
        return _contexto.Prioridades.Any(p => p.PrioridadId == id);
    }

    private bool Insertar (Prioridades prioridad)
    {
        _contexto.Prioridades.Add(prioridad);
        return  _contexto.SaveChanges()> 0;
    }

    private bool Modificar(Prioridades prioridad)
    {
        _contexto.Entry(prioridad).State = EntityState.Modified;
        return _contexto.SaveChanges() > 0;
    }

    public bool Guardar(Prioridades prioridad)
    {
        
     if(prioridad.DiasCompromiso <31){

            if(!Existe(prioridad.PrioridadId))
            return Insertar(prioridad);
        else
            return Modificar(prioridad);
        }
        return true;

    }

    public Prioridades? Buscar (int PrioridadId){

        return _contexto.Prioridades
        .Where( O => O.PrioridadId == PrioridadId)
        .AsNoTracking()
        .SingleOrDefault();
    }
    
    public bool Eliminar(Prioridades prioridad){

        if(Existe(prioridad.PrioridadId))

        _contexto.Entry(prioridad).State = EntityState.Deleted;
        return _contexto.SaveChanges() > 0;
        

    }

     public List<Prioridades> Listar(Expression<Func<Prioridades, bool>> Criterio){
        return _contexto.Prioridades
            .Where(Criterio)
            .AsNoTracking().ToList();
    }


}