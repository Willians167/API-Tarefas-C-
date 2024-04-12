namespace ApiTarefas.Model.Erros;

    public class TarefaError : Exception
    { 
        public TarefaError(string message) : base(message){}

    }