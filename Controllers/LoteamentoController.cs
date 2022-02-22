using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Etapa_No._2.Models;

namespace Etapa_No._2.Controllers
{
    public class LoteamentoController : Controller
    {

   /*   public IActionResult Login()
        {
            return View();
        }
      
     [HttpPost]
     public IActionResult Login(Usuario u){
       UsuarioRepositorio ur = new UsuarioRepositorio();
       Usuario UsurioEncontrado = ur.ValidarLogin(u);
       if (UsurioEncontrado == null)
       {
          ViewBag.Mensagem = "Falha no Login!!!";
          return View();
       }
       else
       {
         // registrar na seção o ID e nome da usuario logado
         HttpContext.Session.SetInt32("IdUsuario", UsurioEncontrado.Id);
         HttpContext.Session.SetString("NomeUsuario", UsurioEncontrado.Nome);
         return RedirectToAction("Listagem","Usuario");

       }
     }
      

       public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login","Usuario");
        }*/
      
      public IActionResult Cadastro()
        {
          return View();
        }


     [HttpPost]
     public IActionResult Cadastro(Loteamento lote)
        {
           LoteamentoRepositorio lt = new LoteamentoRepositorio();
           lote.Id = Convert.ToInt32(HttpContext.Session.GetInt32("Id"));
           lt.Cadastrar(lote);
           
           return RedirectToAction("Listagem","Loteamento");
        }


      public IActionResult Listagem()
        {

            LoteamentoRepositorio lt = new LoteamentoRepositorio();
            List<Loteamento> Lista = lt.Listar();
            return View(Lista);
          
        }

    // Editar
      public IActionResult Editar(int Id)
        {
                 
           LoteamentoRepositorio lt = new LoteamentoRepositorio();
           Loteamento loteEncontrado = lt.BuscarId(Id);
           return View(loteEncontrado);
        
        }

 
    [HttpPost]
     public IActionResult Editar(Loteamento l)
        {

         LoteamentoRepositorio lt = new LoteamentoRepositorio();
         lt.Editar(l);
           
           return RedirectToAction("Servicos","Home");
        }


      // Excluir


     public IActionResult Excluir(int Id)
        {
         
           LoteamentoRepositorio lt = new LoteamentoRepositorio();
           Loteamento loteEncontrado = lt.BuscarId(Id);
           lt.Excluir(loteEncontrado);
           return RedirectToAction("Servicos","Home");
        }



    }
}