using ChallengeOrigin.Models;
using DB;
using DB.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeOrigin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarjetaController : ControllerBase
    {
        private readonly ITarjetaRepository _tarjetaRepository;
        private ResponseDto _response;

        public TarjetaController(ITarjetaRepository tarjetaRepository)
        {
            _tarjetaRepository = tarjetaRepository;
            _response = new ResponseDto();
        }

        [HttpGet("GetTarjetas")]
        public ResponseDto GetTarjeta()
        {
            try
            {
                IEnumerable<Tarjeta> tarjetas = _tarjetaRepository.GetTarjetas();
                _response.Data = tarjetas;
            }
            catch (Exception ex)
            {
                _response.Success = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet("GetTarjetas/{id}")]
        public ResponseDto GetTarjetaById(int id)
        {
            try
            {
                var tarjeta = _tarjetaRepository.GetTarjetaById(id);
                _response.Data = tarjeta;
            }
            catch (Exception ex)
            {
                _response.Success = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut("DesactivarTarjeta/{id}")]
        public ResponseDto DesactivarTarjeta(int id)
        {
            try
            {
                _tarjetaRepository.DesactivarTarjeta(id);
                _response.Message = "Tarjeta desactivada correctamente";
            }
            catch (Exception ex)
            {
                _response.Success = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut("RetiroSaldo/{id}/{amount}")]
        public IActionResult UpdateBalance(int id, int amount)
        {
            try
            {
                _tarjetaRepository.UpdateBalance(id, amount);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
