using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO;
using Dominio;
using Dominio.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class TesteController : Controller
    {
        private readonly ServiceTeste service;

        public TesteController(ServiceTeste serviceTeste)
        {
            service = serviceTeste;
        }

        public void Salvar(TesteModel teste)
        {
            service.Inserir(teste);
        }
    }
}