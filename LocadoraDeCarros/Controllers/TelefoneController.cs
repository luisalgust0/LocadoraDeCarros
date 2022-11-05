using AutoMapper;
using LocadoraDeCarros.Models;
using LocadoraDeCarros.Models.Base;
using Microsoft.AspNetCore.Mvc;
using Negocio.Models;
using Negocio.ServicoNegocio.Base;
using System;
using System.Collections.Generic;

namespace LocadoraDeCarros.Controllers
{
    public class TelefoneController : Controller
    {
        private readonly ITelefoneServico _telefoneServico;
        private readonly IMapper _mapper;

        public TelefoneController(ITelefoneServico telefoneServico, IMapper mapper)
        {
            _telefoneServico = telefoneServico;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            List<TelefoneModelView> telefones = _mapper.Map<List<TelefoneModelView>>(_telefoneServico.ObterListaTelefone()); 
            ListaViewModel<TelefoneModelView> listaTelefone = new ListaViewModel<TelefoneModelView>();
            listaTelefone.Lista = telefones;
            return View(listaTelefone);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TelefoneModelView telefoneModelView)
        {
            try
            { 
                if (ModelState.IsValid)
                {
                    Telefone telefone = _mapper.Map<Telefone>(telefoneModelView);

                    if (_telefoneServico.InserirTelefone(telefone))
                    {
                        RedirectToAction(nameof(Index));
                    }                                    
                }
                telefoneModelView.Alert = "Erro ao inserir o telefone";
                telefoneModelView.Tipo = TipoAlerta.erro;
                return View(telefoneModelView);
               
            }
            catch (Exception ex)
            {
                telefoneModelView.Alert = ex.Message;
                telefoneModelView.Tipo = TipoAlerta.erro;
                return View(telefoneModelView);
            }
        }

        public IActionResult Delete(int id)
        {
            return View(id);
        }

        [HttpPost]
        public IActionResult Delete(TelefoneModelView telefoneModelView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Telefone telefone = _mapper.Map<Telefone>(telefoneModelView);
                    if (_telefoneServico.RemoverTelefone(telefone))
                    {
                        RedirectToAction(nameof(Index));
                    }
                }
                telefoneModelView.Alert = "Erro ao Remover o telefone";
                telefoneModelView.Tipo = TipoAlerta.erro;
                return View(telefoneModelView);
            }
            catch (Exception ex)
            {
                telefoneModelView.Alert = ex.Message;
                telefoneModelView.Tipo = TipoAlerta.erro;
                return View(telefoneModelView);
            }
        }
    }
}
