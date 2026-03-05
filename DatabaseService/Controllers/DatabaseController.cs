using DatabaseService.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DatabaseController : ControllerBase
    {
        private readonly IDbservice _dbservice;

        public DatabaseController(IDbservice dbservice)
        {
            _dbservice = dbservice;
        }

        [HttpPost("connect")]
        public async Task<IActionResult> Connect()
        {
            try
            {
                await _dbservice.ConnectAsync();
                return Ok("Connected to DB");
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to connect: {ex.Message}");
            }
        }

        [HttpGet("version")]
        public async Task<IActionResult> GetVersion()
        {
            try
            {
                var version = await _dbservice.GetVersionAsync();
                return Ok(version);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error getting version: {ex.Message}");
            }
        }

        [HttpPost("disconnect")]
        public async Task<IActionResult> Disconnect()
        {
            try
            {
                await _dbservice.DisconnectAsync();
                return Ok("Disconnected from DB");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error disconnecting: {ex.Message}");
            }
        }
    }
}