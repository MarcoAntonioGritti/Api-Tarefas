using Api_Tarefas.Context;
using Api_Tarefas.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api_Tarefas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly TarefaContext _context;

        public TarefaController(TarefaContext context) 
        {
            _context = context;
        }

        [HttpGet("ObterPorId")]
        public IActionResult ObterPorId(int id)
        {
            var idTarefa = _context.Tarefas.Find(id);

            if(idTarefa == null)
                return NotFound();

            return Ok(idTarefa);

        }

        [HttpGet("ListarTarefas")]
        public ActionResult<IEnumerable<string>> ObterTodos() 
        {
            var tarefas = _context.Tarefas.ToList();
            return Ok(tarefas);
        }

        [HttpGet("ObterPorNome/{nome}")]
        public IActionResult ObterPorTitulo(string nome) 
        {
            var tarefa = _context.Tarefas.Where(t => t.Nome.Equals(nome)).ToList();

            if(tarefa == null)
                return NotFound();

            return Ok(tarefa);
        }

        [HttpGet("ObterPorData/{data}")]
        public IActionResult ObterPorData(DateTime data) 
        {
            var tarefa = _context.Tarefas.Where(t => t.Data.Equals(data)).ToList();

            if(tarefa == null || !tarefa.Any())
                return NotFound();

            return Ok(tarefa);
        }

        [HttpGet("ObterPorStatus/{status}")]
        public IActionResult ObterPorStatus(Status status)
        {
            var tarefa = _context.Tarefas.Where(t => t.Status.Equals(status)).ToList();

            if(tarefa == null || !tarefa.Any())
                return NotFound();

            return Ok(tarefa);
        }

        [HttpPost("AdicionarTarefa")]
        public IActionResult AdicionarTarefa(Tarefa tarefa)
        {
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();

            return Ok(tarefa);

        }

        [HttpPut("AtualizarTarefa/{id}")]
        public IActionResult AtualizarTarefa(int id, Tarefa tarefa)
        {
            var idTarefa = _context.Tarefas.Find(id);

            if (idTarefa == null)
                return NotFound();

            idTarefa.Nome = tarefa.Nome;
            idTarefa.Descricao = tarefa.Descricao;
            idTarefa.Status = tarefa.Status;

            _context.Tarefas.Update(idTarefa);
            _context.SaveChanges();

            return Ok(idTarefa);

        }

        [HttpDelete("DeletarTarefa/{id}")]
        public IActionResult DeletarTarefa(int id) 
        {
            var idTarefa = _context.Tarefas.Find(id);

            if(idTarefa == null)
                return NotFound();
             
            _context.Tarefas.Remove(idTarefa);
            _context.SaveChanges();

            return NoContent();

        }

        
    }
}
