using ApiTarefas.DataBase;
using ApiTarefas.Dto;
using ApiTarefas.Model.Erros;
using ApiTarefas.Models;

namespace ApiTarefas.Servicos.Interfaces;

public interface ITarefaServico
{

    List<Tarefa> Listar(int page);

    public Tarefa Incluir(TarefaDto tarefaDto);


    Tarefa Update(int id, TarefaDto tarefaDto);


    Tarefa BuscaPorId(int id);

   
     public Tarefa Delete(int id);
    object Lista();
    object Lista(int v);
}