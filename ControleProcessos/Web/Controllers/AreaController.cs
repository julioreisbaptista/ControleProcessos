using ControleProcessos.DAL.Data.Interface;
using ControleProcessos.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace ControleProcessos.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    /// <summary>
    /// Controller for managing areas
    /// </summary>
    public class AreaController : ControllerBase
    {
        private readonly IAreaRepository _areaRepository;

        /// <summary>
        /// Constructor for AreaController
        /// </summary>
        /// <param name="areaRepository">The area repository</param>
        public AreaController(IAreaRepository areaRepository)
        {
            _areaRepository = areaRepository ?? throw new ArgumentNullException(nameof(areaRepository));
        }

        /// <summary>
        /// Endpoint to add a new area
        /// </summary>
        /// <param name="area">The area to add</param>
        [HttpPost]
        public IActionResult Add(Area area)
        {
            _areaRepository.Add(area);
            return Ok();
        }

        /// <summary>
        /// Endpoint to get all areas
        /// </summary>
        [HttpGet]
        public IActionResult Get()
        {
            var ret = _areaRepository.GetAll();
            return Ok(ret);
        }

        /// <summary>
        /// Endpoint to get an area by ID
        /// </summary>
        /// <param name="id">The ID of the area</param>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var ret = _areaRepository.GetById(id);
            return Ok(ret);
        }

        /// <summary>
        /// Endpoint to update an existing area
        /// </summary>
        /// <param name="area">The area to update</param>
        [HttpPut]
        public IActionResult Update(Area area)
        {
            _areaRepository.Update(area);
            return Ok();
        }

        /// <summary>
        /// Endpoint to delete an area by ID
        /// </summary>
        /// <param name="id">The ID of the area to delete</param>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _areaRepository.Delete(id);
            return Ok();
        }
    }
}
