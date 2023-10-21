using AutoMapper;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiVersion("1.0")]
[ApiVersion("1.1")]
[Authorize(Roles = "Empleado, Administrador, Gerente")]
public class CargoController : BaseApiController
{
  private readonly IUnitOfWork _unitOfWork;
  private readonly IMapper _mapper;
  public CargoController(IMapper mapper, IUnitOfWork unitOfWork)
  {
    _mapper = mapper;
    _unitOfWork = unitOfWork;
  }

  
  [HttpGet]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<ActionResult<IEnumerable<Cargo>>> Get()
  {
      var nameVar = await unitOfWork.nameClassInterface.GetAllAsync();
      return Ok(nameVar);
  }

  [HttpGet]
  [ApiVersion(1.1)]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<ActionResult<Pager<CargoDto>>> Get([FromQuery] Params entidadP)
  {
  var (totalRegistros, registros) = await _unitOfWork.Citas.GetAllAsync(entidadP.PageIndex,entidadP.PageSize,entidadP.Search);
  var lista = _mapper.Map<List<Dto>>(registros);
  return new Pager<CargoDto>(totalRegistros,entidadP.PageIndex,entidadP.PageSize,entidadP.Search);
  }

  [HttpPost]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<ActionResult<IEnumerable<Cargo>>> Post(Dto CargoDto)
  {
  var resultado = _mapper.Map<Clase>(CargoDto);
      _unitOfWork.nameClases.Add(resultado);
      await _unitOfWork.SaveAsync();
      if (resultado == null)
      {
          return BadRequest();
      }
      return NoContent();
  }

  [HttpPut("{id}")]
  [ProducesResponseType(StatusCodes.Status204NoContent)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<IActionResult> Update(int id, [FromBody] Dto CargoDto)
  {
      if (id != unameDto.Id)
      {
          return BadRequest();
      }
  
      var existe = await _unitOfWork.nameClass.GetByIdAsync(id);
      if (existe == null)
      {
          return NotFound();
      }
  
  
        _mapper.Map(nameDto, existe);
      unitOfWork.nameClass.Update(existe);
      await unitOfWork.SaveAsync();
  
      return NoContent();
  }

  [HttpDelete("{id}")]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<IActionResult> Delete(int id)
  {
    var resultado = await unitOfWork.nameClass.GetByIdAsync(id);
    if (resultado == null)
    {
      return NotFound();
    }
  
    _unitOfWork.nameClass.Remove(resultado);
    await _unitOfWork.SaveAsync();
  
    return Ok();
  }
}