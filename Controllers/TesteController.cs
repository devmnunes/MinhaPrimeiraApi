using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TesteController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            mensagem = "API funcionando, Sucesso no retorno",
            status = "OK"
        });
    }

    [HttpGet("erro")]
    public IActionResult Erro()
    {
        return BadRequest(new
        {
            mensagem = "Ocorreu um erro na requisição."
        });
    }
}

