using Fiap.Exemplo04.MVC.Models;
using Fiap.Exemplo04.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo04.MVC.Controllers
{
    public class JogadorController : Controller
    {
        private FutebolContext _context = new FutebolContext();
        // GET: Jogador
        [HttpGet]
        public ActionResult Cadastrar()
        {
            ListarTimes();
            return View();
        }

        private void ListarTimes()
        {
            var lista = _context.Times.ToList();
            ViewBag.times = new SelectList(lista, "TimeId", "Nome");
        }

        [HttpPost]
        public ActionResult Cadastrar(Jogador jogador)
        {
            _context.Jogadores.Add(jogador);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado com sucesso!";
            ListarTimes();
            return RedirectToAction("Cadastrar");
        }

        public ActionResult Listar()
        {
            return View(_context.Jogadores.Include("Time").ToList());
        }
    }
}