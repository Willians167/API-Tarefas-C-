using ApiTarefas.DataBase;
using ApiTarefas.ModelViews;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Console;
using ApiTarefas.Models;
using ApiTarefas.Dto;
using ApiTarefas.Servicos;
using ApiTarefas.Model.Erros;
using ApiTarefas.Servicos.Interfaces;


namespace ApiTarefas.Controllers;

[ApiController]
[Route("/tarefas")]

public class TarefasController : ControllerBase
{
    public TarefasController(ITarefaServico servico)
    {
        _servico = servico;
    }


    private ITarefaServico _servico;

    [HttpGet]

    public IActionResult Index(int page =1)
    {
        var tarefas = _servico.Listar(page);
        return StatusCode(200, tarefas);
    }


    [HttpPost]
    public IActionResult Create([FromBody] TarefaDto tarefaDto)
    {
        try
        {

            var tarefa = _servico.Incluir(tarefaDto);
            return StatusCode(201, tarefa);
        }
        catch (TarefaError error)
        {
            return StatusCode(400, new ErrorView { Mensagem = error.Message });
        }
        {
        }
    }
    [HttpPut("{id}")]
    public IActionResult Update([FromRoute] int id, [FromBody] TarefaDto tarefaDto)
    {
        try
        {
            var tarefaDb = _servico.Update(id, tarefaDto);

            return StatusCode(200, tarefaDb);
        }
        catch (TarefaError error)
        {
            return StatusCode(400, new ErrorView { Mensagem = error.Message });
        }


    }

    [HttpGet("{id}")]
    public IActionResult Show([FromRoute] int id)
    {
        try
        {

            var tarefa = _servico.BuscaPorId(id);
            return StatusCode(201, tarefa);
        }
        catch (TarefaError error)
        {
            return StatusCode(400, new ErrorView { Mensagem = error.Message });
        }
    }

    [HttpDelete("{id}")]
    public IActionResult Delete([FromRoute] int id)
    {
        try
        {
            _servico.Delete(id);
            return StatusCode(204);
        }
        catch (TarefaError error)
        {

            return StatusCode(400, new ErrorView { Mensagem = error.Message });

        }

    }
}




