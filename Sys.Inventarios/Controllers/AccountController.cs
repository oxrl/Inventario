using Model;
using Repository;
using Sys.Inventarios.Helpers;
using Sys.Inventarios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sys.Inventarios.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string email, string password, bool? recordar)
        {
            IRepository repository = new Model.Repository();
            var objUsu = repository.FindEntity<Usuarios>(c => c.CorreoElectronico == email && c.Activo == true);
            int id = 0;
            string strMensaje = "El usuario y/o contraseña son incorrectos.";
            recordar = recordar == null ? false : true;
            if (objUsu != null)
            {
                if (CryproHelper.Confirm(password, objUsu.Password, CryproHelper.Supported_HA.SHA512))
                {
                    id = -1;
                    SessionHelper.AddUserToSession(objUsu.Id.ToString(), (bool)recordar);
                    SessionHelper.ActualizarSession(objUsu);
                    if (objUsu.Rol_Id == 1)
                    {
                        strMensaje = Url.Content("~/Home");
                    }
                }
            }
            return Json(new Response { IsSuccess = true, Message = strMensaje, Id = id }, JsonRequestBehavior.AllowGet);
        }
    }
}