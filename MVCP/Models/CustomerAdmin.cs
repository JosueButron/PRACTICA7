using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCP.Models;

namespace MVCP.Datos
{
    public class CustomerAdmin
    {
        public IEnumerable<producto> Consultar()
        {
            using (VentasEntities contexto = new VentasEntities())
            {
                return contexto.producto.AsNoTracking().ToList();
            }
        }
        public producto Consultar(int id)
        {
            using (VentasEntities contexto = new VentasEntities())
            {
                return contexto.producto.AsNoTracking().FirstOrDefault(c => c.codpro == id);
            }
        }
        public void Guardar(producto modelo)
        {
            using (VentasEntities contexto = new VentasEntities())
            {
                contexto.producto.Add(modelo);
                contexto.SaveChanges();
            }
        }
        public void Modificar(producto modelo)
        {
            using (VentasEntities contexto = new VentasEntities())
            {
                contexto.Entry(modelo).State =
               System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Eliminar(producto modelo)
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