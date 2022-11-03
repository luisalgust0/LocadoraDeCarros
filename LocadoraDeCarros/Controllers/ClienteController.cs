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
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using LocadoraDeCarros.Models.Base;

namespace LocadoraDeCarros.Controllers
{
    //adicionar as menssagens de validação e o dataValidation

    public class ClienteController : Controller
    {
        private readonly IClienteServico _clienteService;
        private readonly IMapper _mapper;

        public ClienteController(IClienteServico clienteService,IMapper mapper)
        {
            _clienteService = clienteService;
            _mapper = mapper;
        }
        // GET: ClienteController
        public ActionResult Index()
        {
            List<ClienteViewModel> ClienteVm = _mapper.Map<List<ClienteViewModel>>(_clienteService.ObterListaCliente());
            var lista = new ListaViewModel<ClienteViewModel>();
            lista.Lista = ClienteVm; 
            return View(lista);
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
        public ActionResult Create(ClienteViewModel novoClienteVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var novoCliente = _mapper.Map<Cliente>(novoClienteVM);

                    if (_clienteService.InserirCliente(novoCliente))
                    {
                        novoClienteVM.Tipo = TipoAlerta.sucesso;
                        novoClienteVM.Alert = "Inserido com sucesso";
                        return RedirectToAction(nameof(Index));
                    }
                }
                else
                    novoClienteVM.Tipo = TipoAlerta.erro;
                    novoClienteVM.Alert = "Erro ao inserir";
                    return View(novoClienteVM);
            }
            catch(Exception ex)
            {
                novoClienteVM.Tipo = TipoAlerta.erro;
                novoClienteVM.Alert = ex.ToString();
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
                if(ModelState.IsValid)
                {
                    var clienteEditar = _mapper.Map<Cliente>(clienteEditarVM);
                    if (_clienteService.EditarCliente(clienteEditar))
                    {

                        clienteEditarVM.Tipo = TipoAlerta.sucesso;
                        clienteEditarVM.Alert = "Editado com sucesso";
                        return RedirectToAction(nameof(Index));
                    }
                }
                else
                    clienteEditarVM.Tipo = TipoAlerta.erro;
                    clienteEditarVM.Alert = "Erro ao editar cliente";
                    return View(clienteEditarVM);
            }
            catch(Exception ex)
            {
                clienteEditarVM.Tipo = TipoAlerta.erro;
                clienteEditarVM.Alert = ex.ToString();
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
                if (_clienteService.DeletarCliente(clienteDeletar))
                {
                    clienteDeletarVM.Alert = "Deletado com sucesso";
                    clienteDeletarVM.Tipo = TipoAlerta.sucesso;
                    return RedirectToAction(nameof(Index));
                }          
                else
                    clienteDeletarVM.Alert = "Erro ao deletar o cliente";
                    clienteDeletarVM.Tipo = TipoAlerta.erro;
                    return View(clienteDeletarVM);
            }
            catch(Exception ex)
            {
                clienteDeletarVM.Alert = ex.ToString();
                clienteDeletarVM.Tipo = TipoAlerta.erro;
                return View(clienteDeletarVM);
            }
        }
    }
}
