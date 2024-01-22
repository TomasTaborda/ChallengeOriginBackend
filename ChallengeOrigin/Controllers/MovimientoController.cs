using ChallengeOrigin.Models;
using DB;
using DB.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeOrigin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimientoController : ControllerBase
    {
        private readonly IMovimientoRepository _movimientoRepository;
        private ResponseDto _response;

        public MovimientoController(IMovimientoRepository movimientoRepository)
        {
            _movimientoRepository = movimientoRepository;
            _response = new ResponseDto();
        }

        [HttpGet("GetMovimientoByTarjeta/{id}")]
        public ResponseDto GetMovimientoById(int id)
        {
            try
            {
                var movimiento = _movimientoRepository.GetMovimientoByIdTarjeta(id);
                _response.Data = movimiento;
            }
            catch (Exception ex)
            {
                _response.Success = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost("AddMovimiento")]
        public ResponseDto AddMovimiento([FromBody] Movimiento movimiento)
        {
            try
            {
                _movimientoRepository.AddMovimiento(movimiento);
                _response.Message = "Movimiento agregado correctamente";
            }
            catch (Exception ex)
            {
                _response.Success = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

    }
}
