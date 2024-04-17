using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControleProcessos.DAL.Data;
using ControleProcessos.DAL.Models;
using ControleProcessos.DAL.Data.Interface;

namespace ControleProcessos.Web.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class ProcessoTipoesController : ControllerBase
{
    private readonly IProcessoTipoRepository _processoTipoRepository;

    public ProcessoTipoesController(IProcessoTipoRepository processoTipoRepository)
    {
        _processoTipoRepository = processoTipoRepository;
    }

    /// <summary>
    /// Get all processo tipos.
    /// </summary>
    [HttpGet]
    public IActionResult Get()
    {
        var ret = _processoTipoRepository.GetAll().ToList();
        return Ok(ret);
    }

    /// <summary>
    /// Get a processo tipo by ID.
    /// </summary>
    /// <param name="id">The ID of the processo tipo.</param>
    [HttpGet("{id}")]
    public IActionResult GetProcessoTipo(int id)
    {
        var processoTipo = _processoTipoRepository.GetByID(id);
        return Ok(processoTipo); 
    }

    /// <summary>
    /// Add a new processo tipo.
    /// </summary>
    /// <param name="processoTipo">The processo tipo to add.</param>
    [HttpPost]
    public IActionResult Add(ProcessoTipo processoTipo)
    {
        _processoTipoRepository.Add(processoTipo);
        return Ok();
    }

    /// <summary>
    /// Update an existing processo tipo.
    /// </summary>
    /// <param name="processoTipo">The processo tipo to update.</param>
    [HttpPut]
    public IActionResult Update(ProcessoTipo processoTipo)
    {
        _processoTipoRepository.Update(processoTipo);
        return Ok();
    }

    /// <summary>
    /// Delete a processo tipo by ID.
    /// </summary>
    /// <param name="id">The ID of the processo tipo to delete.</param>
    [HttpDelete]
    public IActionResult Delete(int id)
    {
        _processoTipoRepository.Delete(id);
        return Ok();
    }
}
}
