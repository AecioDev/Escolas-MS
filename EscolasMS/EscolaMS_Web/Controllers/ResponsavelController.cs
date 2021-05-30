using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using AutoMapper;
using EscolaMS_Domain.Entities;
using EscolaMS_Domain.Interfaces;
using EscolaMS_Web.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace EscolaMS_Web.Controllers
{
    public class ResponsavelController : Controller
    {
        IMapper _mapper;
        private readonly IAlunoRepositorio _alunoDb;
        private readonly IResponsavelRepositorio _ResponsavelDb;
        public ResponsavelController(IMapper mapper, IResponsavelRepositorio ResponsavelDb,
            IAlunoRepositorio alunoRepositorio)
        {
            _mapper = mapper;
            _alunoDb = alunoRepositorio;
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
            var resp = _ResponsavelDb.GetById(id);
            var viewResp = _mapper.Map<Responsavel, ResponsavelViewModel>(resp);
            return View(viewResp);
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
            //Valida Idade Mínima
            var AnoIdade = responsavel.DataNascimento.Year;
            if (DateTime.Now.Year - AnoIdade <= 18)
            {
                ModelState.AddModelError("DataNascimento", "O Responsável deve ter 18 anos de idade ou mais!");
            }

            if (ModelState.IsValid)
            {
                var responsavelDomain = _mapper.Map<ResponsavelViewModel, Responsavel>(responsavel);
                _ResponsavelDb.Add(responsavelDomain);

                //TempData["MSG_S"] = "Cadastro realizado com Sucesso!";
                return RedirectToAction(nameof(Index));
            }

            return View(responsavel);
        }

        // GET: ResponsavelController/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var resp = _ResponsavelDb.GetById(id);
            var viewResp = _mapper.Map<Responsavel, ResponsavelViewModel>(resp);
            return View(viewResp);
        }

        // POST: ResponsavelController/Edit/5
        [HttpPost]
        public ActionResult Edit(ResponsavelViewModel responsavel)
        {
            //Valida Idade Mínima
            var AnoIdade = responsavel.DataNascimento.Year;
            if (DateTime.Now.Year - AnoIdade <= 18)
            {
                ModelState.AddModelError("DataNascimento", "O Responsável deve ter 18 anos de idade ou mais!");
            }

            if (ModelState.IsValid)
            {
                var responsavelDomain = _mapper.Map<ResponsavelViewModel, Responsavel>(responsavel);
                _ResponsavelDb.Update(responsavelDomain);

                //TempData["MSG_S"] = "Cadastro realizado com Sucesso!";
                return RedirectToAction(nameof(Index));
            }

            return View(responsavel);
        }

        // GET: ResponsavelController/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            TempData["MSG_E"] = null;
            var resp = _ResponsavelDb.GetById(id);
            var viewResp = _mapper.Map<Responsavel, ResponsavelViewModel>(resp);
            return View(viewResp);
        }

        // POST: ResponsavelController/Delete/5       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TempData["MSG_E"] = null;
            var aluno = _alunoDb.GetAlunoByResp(id);
            if (aluno != null)
            {
                var resp = _ResponsavelDb.GetById(id);
                var viewResp = _mapper.Map<Responsavel, ResponsavelViewModel>(resp);
                TempData["MSG_E"] = "O responsável está vinculado ao aluno <b>" + aluno.Nome + "!</b> Não é possível Deletar!";

                return View(viewResp);
            }

            var responsavel = _ResponsavelDb.GetById(id);
            _ResponsavelDb.Remove(responsavel);

            return RedirectToAction(nameof(Index));
        }
    }
}
