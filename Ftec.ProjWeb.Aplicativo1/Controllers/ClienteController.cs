﻿using Ftec.ProjWeb.Aplicativo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ftec.ProjWeb.Aplicativo1.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastrar(Cliente cliente)
        {
            return View();
        }
    }
}