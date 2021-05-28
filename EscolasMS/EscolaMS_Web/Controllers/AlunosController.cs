using AutoMapper;
using EscolaMS_Domain.Entities;
using EscolaMS_Domain.Interfaces;
using EscolaMS_Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaMS_Web.Controllers
{
    public class AlunosController : Controller
    {
        IMapper _mapper;
        private readonly IAlunoRepositorio _alunoRepositorio;
        public AlunosController(IMapper mapper, IAlunoRepositorio alunoRepositorio)
        {
            _mapper = mapper;
            _alunoRepositorio = alunoRepositorio;
        }

        // GET: AlunosController
        public ActionResult Index()
        {
            var alunos = _alunoRepositorio.GetAll().ToList();
            var viewAlunos = _mapper.Map<IEnumerable<Aluno>, IEnumerable<AlunoViewModel>>(alunos);
            return View(viewAlunos);
        }

        // GET: AlunosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AlunosController/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: AlunosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm]Aluno aluno)
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

        // GET: AlunosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AlunosController/Edit/5
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

        // GET: AlunosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AlunosController/Delete/5
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
