using ApiTarefas.ModelViews;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Console;

namespace ApiTarefas.Controllers;

[ApiController]
[Route("/")]

public class HomeController : ControllerBase
{


    [HttpGet]

    public HomeView Index()
    {
        return new HomeView
        {
            Mensagem = "Bem Vinda a Api de tarefas",
            Documentacao = "/swagger"
        };
    }

}
