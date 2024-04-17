using FluentResults;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ControleProcessos.DAL;
using ControleProcessos.DAL.Data;
using ControleProcessos.DAL.Data.Interface;
using ControleProcessos.DAL.Models;

namespace ControleProcessos.API.WEB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProcessoController : Controller
    {
        /// <summary>
        /// Controller for managing processos
        /// </summary>
        private readonly IProcessoRepository _processoRepository;

        /// <summary>
        /// Constructor for ProcessoController
        /// </summary>
        /// <param name="processoRepository">The repository for processos</param>
        public ProcessoController(IProcessoRepository processoRepository)
        {
            _processoRepository = processoRepository;
        }

        /// <summary>
        /// Get all processos
        /// </summary>
        /// <returns>ActionResult with all processos</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_processoRepository.GetAllProcessos());
        }

        /// <summary>
        /// Add a processo
        /// </summary>
        /// <param name="processo">The processo to add</param>
        /// <returns>ActionResult</returns>
        [HttpPost]
        public IActionResult Add(Processo processo)
        {
            _processoRepository.CreateProcesso(processo);
            return Ok();
        }

        /// <summary>
        /// Get a processo by ID
        /// </summary>
        /// <param name="id">The ID of the processo to retrieve</param>
        /// <returns>ActionResult with the processo</returns>
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_processoRepository.GetProcesso(id));
        }

        /// <summary>
        /// Update a processo
        /// </summary>
        /// <param name="processo">The processo to update</param>
        /// <returns>ActionResult</returns>
        [HttpPut]
        public IActionResult Update(Processo processo)
        {
            _processoRepository.UpdateProcesso(processo);
            return Ok();
        }

        /// <summary>
        /// Delete a processo by ID
        /// </summary>
        /// <param name="id">The ID of the processo to delete</param>
        /// <returns>ActionResult</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _processoRepository.DeleteProcesso(id);
            return Ok();
        }
    }
}
