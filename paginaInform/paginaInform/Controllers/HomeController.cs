using paginaInform.Models;
using paginaInform.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace paginaInform.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Index()
        {
            var ima = new ConexionUsuario();
            var model = ima.listaIm();
          return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       // [HttpPost]
        //public ActionResult insertar(String nombre, String apellidos, String telefono, String correo, String mensaje)
        //{
        //    ViewBag.Nombre = nombre;
        //    ViewBag.Apellido = apellidos;
        //    ViewBag.Telefono = telefono;
        //    ViewBag.Correo = correo;
        //    ViewBag.Mensaje = mensaje;
        //    Usuario usr = new Usuario();
        //    usr.Nombre = nombre;
        //    usr.Apellido = apellidos;
        //    usr.telefono = telefono;
        //    usr.correo = correo;
        //    usr.mensaje = mensaje;
        //    var ima = new ConexionUsuario();
        //    ima.insertarUsuarios(usr);
        //    return View();
        //}




    }

}