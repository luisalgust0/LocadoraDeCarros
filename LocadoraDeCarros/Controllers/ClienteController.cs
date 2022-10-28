using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Negocio.ServicoNegocio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LocadoraDeCarros.Models;
using Negocio.Models;

namespace LocadoraDeCarros.Controllers
{
    //adicionar as menssagens de validação e o dataValidation

    public class ClienteController : Controller
    {
        private readonly IClienteServico _clienteService;
        private readonly Mapper _mapper;

        public ClienteController(IClienteServico clienteService,Mapper mapper)
        {
            _clienteService = clienteService;
            _mapper = mapper;
        }
        // GET: ClienteController
        public ActionResult Index()
        {
            var listaCliente = _clienteService.ObterListaCliente();
            List<ClienteViewModel> listaClienteVm = _mapper.Map<List<ClienteViewModel>>(listaCliente);
            return View(listaClienteVm);
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            ClienteViewModel clienteVM = _mapper.Map<ClienteViewModel>(_clienteService.ObterClientePorId(id));
            return View(clienteVM);
        }


        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel novoClienteVM)
        {
            try
            {
                var novoCliente = _mapper.Map<Cliente>(novoClienteVM);
                if (_clienteService.InserirCliente(novoCliente))
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                    return View(novoClienteVM);             
            }
            catch
            {
                return View(novoClienteVM);
            }
        }


        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            ClienteViewModel clienteEditar = _mapper.Map<ClienteViewModel>(_clienteService.ObterClientePorId(id));
            return View(clienteEditar);
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel clienteEditarVM)
        {
            try
            {
                var clienteEditar = _mapper.Map<Cliente>(clienteEditarVM);
                if (_clienteService.EditarCliente(clienteEditar))
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                    return View(clienteEditarVM);
            }
            catch
            {
                return View(clienteEditarVM);
            }
        }


        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            ClienteViewModel clienteDeletar = _mapper.Map<ClienteViewModel>(_clienteService.ObterClientePorId(id));
            return View(clienteDeletar);
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ClienteViewModel clienteDeletarVM)
        {
            try
            {
                var clienteDeletar = _mapper.Map<Cliente>(clienteDeletarVM);
                if (_clienteService.DeletarCliente(clienteDeletar.Id))
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                    return View(clienteDeletarVM);
            }
            catch
            {
                return View(clienteDeletarVM);
            }
        }
    }
}
