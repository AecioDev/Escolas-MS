using AutoMapper;
using EscolaMS_Domain.Entities;
using EscolaMS_Domain.Interfaces;
using EscolaMS_Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace EscolaMS_Web.Controllers
{
    public class AlunosController : Controller
    {
        IMapper _mapper;
        private readonly IAlunoRepositorio _alunoDb;
        private readonly IResponsavelRepositorio _ResponsavelDb;
        public AlunosController(IMapper mapper, IAlunoRepositorio alunoRepositorio,
            IResponsavelRepositorio ResponsavelDb)
        {
            _mapper = mapper;
            _alunoDb = alunoRepositorio;
            _ResponsavelDb = ResponsavelDb;
        }

        // GET: AlunosController
        public ActionResult Index()
        {
            var alunos = _alunoDb.GetAll().ToList();
            var viewAlunos = _mapper.Map<IEnumerable<Aluno>, IEnumerable<AlunoViewModel>>(alunos);
            return View(viewAlunos);
        }

        // GET: AlunosController/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            var aluno = _alunoDb.GetById(id);
            var viewAluno = _mapper.Map<Aluno, AlunoViewModel>(aluno);
            return View(viewAluno);
        }

        // GET: AlunosController/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Responsaveis = _ResponsavelDb.GetAll().Select(r => new SelectListItem()
            {
                Text = r.Nome,
                Value = r.ResponsavelId.ToString()
            }).ToList();                
            return View();
        }

        // POST: AlunosController/Create
        [HttpPost]
        public ActionResult Create(AlunoViewModel aluno)
        {
            ViewBag.Responsaveis = _ResponsavelDb.GetAll().Select(r => new SelectListItem()
            {
                Text = r.Nome,
                Value = r.ResponsavelId.ToString()
            }).ToList();

            //Valida Idade Mínima
            var AnoIdade = aluno.DataNascimento.Year;
            if(DateTime.Now.Year - AnoIdade < 6)
            {
                ModelState.AddModelError("DataNascimento", "O Aluno deve ter no mínimo 6 anos de idade!");
            } 
            else if (DateTime.Now.Year - AnoIdade < 18 && aluno.ResponsavelId == null)
            {
                ModelState.AddModelError("ResponsavelId", "Para aluno menor de 18 anos o Responsável deve ser informado!");
            }

            //Valida o Documento Informado
            if (string.IsNullOrEmpty(aluno.NumeroCertidaoNova) && string.IsNullOrEmpty(aluno.CPF))
            {
                ModelState.AddModelError("NumeroCertidaoNova", "Informe o número da Certidão Nova ou do CPF do Aluno!");
                ModelState.AddModelError("CPF", "Informe o número do CPF ou da Certidão Nova do Aluno!");
            }

            if (ModelState.IsValid)
            {
                var alunoDomain = _mapper.Map<AlunoViewModel, Aluno>(aluno);
                _alunoDb.Add(alunoDomain);

                //TempData["MSG_S"] = "Cadastro realizado com Sucesso!";
                return RedirectToAction(nameof(Index));
            }

            return View(aluno);
        }

        // GET: AlunosController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Responsaveis = _ResponsavelDb.GetAll().Select(r => new SelectListItem()
            {
                Text = r.Nome,
                Value = r.ResponsavelId.ToString()
            }).ToList();

            var aluno = _alunoDb.GetById(id);
            var viewAluno = _mapper.Map<Aluno, AlunoViewModel>(aluno);
            return View(viewAluno);
        }

        // POST: AlunosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AlunoViewModel aluno)
        {
            ViewBag.Responsaveis = _ResponsavelDb.GetAll().Select(r => new SelectListItem()
            {
                Text = r.Nome,
                Value = r.ResponsavelId.ToString()
            }).ToList();

            //Valida Idade Mínima
            var AnoIdade = aluno.DataNascimento.Year;
            if (DateTime.Now.Year - AnoIdade < 6)
            {
                ModelState.AddModelError("DataNascimento", "O Aluno deve ter no mínimo 6 anos de idade!");
            }
            else if (DateTime.Now.Year - AnoIdade < 18 && aluno.ResponsavelId == null)
            {
                ModelState.AddModelError("ResponsavelId", "Para aluno menor de 18 anos o Responsável deve ser informado!");
            }

            //Valida o Documento Informado
            if (string.IsNullOrEmpty(aluno.NumeroCertidaoNova) && string.IsNullOrEmpty(aluno.CPF))
            {
                ModelState.AddModelError("NumeroCertidaoNova", "Informe o número da Certidão Nova ou do CPF do Aluno!");
                ModelState.AddModelError("CPF", "Informe o número do CPF ou da Certidão Nova do Aluno!");
            }

            if (ModelState.IsValid)
            {
                var alunoDomain = _mapper.Map<AlunoViewModel, Aluno>(aluno);
                _alunoDb.Update(alunoDomain);

                //TempData["MSG_S"] = "Cadastro realizado com Sucesso!";
                return RedirectToAction(nameof(Index));
            }

            return View(aluno);
        }

        // GET: AlunosController/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var aluno = _alunoDb.GetById(id);
            var viewAluno = _mapper.Map<Aluno, AlunoViewModel>(aluno);
            return View(viewAluno);
        }

        // POST: AlunosController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {            
            var aluno = _alunoDb.GetById(id);
            _alunoDb.Remove(aluno);

            return RedirectToAction(nameof(Index));
         
        }
    }
}
