using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCP.Models;
using MVCP.Datos;

namespace MVCP.Datos
{
    public class VendedorAdmin
    {
        public IEnumerable<Ventas> Consultar()
        {
            using (VentasEntities contexto = new VentasEntities())
            {
                return contexto.Ventas.AsNoTracking().ToList();
            }
        }
        public Ventas Consultar(int id)
        {
            using (VentasEntities contexto = new VentasEntities())
            {
                return contexto.Ventas.AsNoTracking().FirstOrDefault(c =>
               c.codigo == id);
            }
        }
        public void Guardar(Ventas modelo)
        {
            using (VentasEntities contexto = new VentasEntities())
            {
                contexto.Ventas.Add(modelo);
                contexto.SaveChanges();
            }
        }
        public void Modificar(Ventas modelo)
        {
            using (VentasEntities contexto = new VentasEntities())
            {
                contexto.Entry(modelo).State =
               System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Eliminar(Ventas modelo)
        {
            using (VentasEntities contexto = new VentasEntities())
            {
                contexto.Entry(modelo).State =
               System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}
