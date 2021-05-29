using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using AutoMapper;
using EscolaMS_Domain.Entities;
using EscolaMS_Domain.Interfaces;
using EscolaMS_Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace EscolaMS_Web.Controllers
{
    public class ResponsavelController : Controller
    {
        IMapper _mapper;
        private readonly IResponsavelRepositorio _ResponsavelDb;
        public ResponsavelController(IMapper mapper, IResponsavelRepositorio ResponsavelDb)
        {
            _mapper = mapper;
            _ResponsavelDb = ResponsavelDb;
        }

        // GET: ResponsavelController
        public ActionResult Index()
        {
            var responsaveis = _ResponsavelDb.GetAll().ToList();
            var viewResponsaveis = _mapper.Map<IEnumerable<Responsavel>, IEnumerable<ResponsavelViewModel>>(responsaveis);
            return View(viewResponsaveis);
        }

        // GET: ResponsavelController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ResponsavelController/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: ResponsavelController/Create
        [HttpPost]
        public ActionResult Create(ResponsavelViewModel responsavel)
        {
            if (ModelState.IsValid)
            {
                var responsavelDomain = _mapper.Map<ResponsavelViewModel, Responsavel>(responsavel);
                _ResponsavelDb.Add(responsavelDomain);

                TempData["MSG_S"] = "Cadastro realizado com Sucesso!";
                return RedirectToAction(nameof(Index));
            }

            return View(responsavel);
        }

        // GET: ResponsavelController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ResponsavelController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ResponsavelController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ResponsavelController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
