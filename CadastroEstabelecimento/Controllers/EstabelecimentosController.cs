using CadastroEstabelecimento.Models;
using CadastroEstabelecimento.Models.ViewModels;
using CadastroEstabelecimento.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroEstabelecimento.Controllers
{
    public class EstabelecimentosController : Controller
    {
        private readonly EstabelecimentosServices _estabelecimentosServices;
        private readonly CategoriasServices _categoriasServices;
        public EstabelecimentosController(EstabelecimentosServices estabelecimentosServices, CategoriasServices categoriasServices)
        {
            _estabelecimentosServices = estabelecimentosServices;
            _categoriasServices = categoriasServices;
        }
        public IActionResult Index()
        {
            var list = _estabelecimentosServices.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var categorias = _categoriasServices.FindAll();
            var viewModel = new EstabelecimentosFormViewModel { Categorias = categorias };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Create(Estabelecimentos estabelecimentos)
        {
            if (!ModelState.IsValid)
            {
                var categorias = _categoriasServices.FindAll();
                var viewModel = new EstabelecimentosFormViewModel { Estabelecimentos = estabelecimentos, Categorias = categorias };
                return View(viewModel);
            }
            _estabelecimentosServices.Insert(estabelecimentos);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof (Error ), new { message = " ID NÃO FORNECIDO" });
                //return (IActionResult)Task.FromResult(NotFound());
            }

            var obj =  _estabelecimentosServices.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id NÃO ENCONTRADO" });
                //return (IActionResult)Task.FromResult(NotFound());
            }

            return await Task.FromResult(View(obj));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            
                _estabelecimentosServices.Remove(id);
                return await Task.FromResult(RedirectToAction(nameof(Index)));
           
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof (Error ), new { message = " Id não fornecido" });
                //return NotFound();
            }

            var obj = _estabelecimentosServices.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
                //return NotFound();
            }

            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
                //return NotFound();
            }

            var obj = _estabelecimentosServices.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
                //return NotFound();
            }

            List<Categorias> categorias = _categoriasServices.FindAll();
            EstabelecimentosFormViewModel viewModel = new EstabelecimentosFormViewModel { Estabelecimentos = obj, Categorias = categorias };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Estabelecimentos estabelecimentos)
        {
            if (!ModelState.IsValid)
            {
                var categorias = _categoriasServices.FindAll();
                var viewModel = new EstabelecimentosFormViewModel { Estabelecimentos = estabelecimentos, Categorias = categorias };
                return View(viewModel);
            }
            if (id != estabelecimentos.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não correspondente" });
                //return BadRequest();
            }
            try
            {
                _estabelecimentosServices.Update(estabelecimentos);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
                //return BadRequest();
            }
        }

        public IActionResult Error(string message)
            {
                var viewModel = new ErrorViewModel
                {
                    Message = message,
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
                };
                return View(viewModel);
            }



        }

    }

