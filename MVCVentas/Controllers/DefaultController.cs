using MVCVentas.Datos;
using MVCVentas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MVCVentas.Controllers
{
    public class CustomerController : Controller
    {
        CustomerAdmin admin = new CustomerAdmin();
        // GET: Customer
        public ActionResult Index()
        {
            return View(admin.Consultar());
        }
        public ActionResult Detalle(int id)
        {
            return View(admin.Consultar(id));
        }
        public ActionResult Crear()
        {
            return View();
        }
        public ActionResult Guardar(Ventas modelo)
        {
            admin.Guardar(modelo);
            return View("Crear", modelo);
        }
        public ActionResult Editar(int id)
        {
            return View(admin.Consultar(id));
        }
        public ActionResult Modificar(Ventas modelo)
        {
            admin.Modificar(modelo);
            return View("Editar", modelo);
        }
        public ActionResult Eliminar(int id)
        {
            Ventas modelo = admin.Consultar(id);
            admin.Eliminar(modelo);
            return View("Index", admin.Consultar());
        }
    }
}
