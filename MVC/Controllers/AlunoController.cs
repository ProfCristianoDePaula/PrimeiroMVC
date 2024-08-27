using Microsoft.AspNetCore.Mvc;
using MVC.Models;


namespace MVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Cristiano de Paula", "cris@sp.senai.br", 123456);
            Aluno a2 = new Aluno(2, "Maria Aparecida", "mariaap@teste.com.br", 223344);
            Aluno a3 = new Aluno(3, "José da Sila", "jose@teste.com.br", 333666);
            Aluno a4 = new Aluno(4, "João Paulo Santos", "joao@teste.com.br", 444444);
            Aluno a5 = new Aluno(5, "Pedro Silva", "ps@teste.com.br", 557788);

            // Criar uma lista de Alunos
            List<Aluno> listaAlunos = new List<Aluno>();
            // Adicionar os Objetos Alunos na Lista Alunos
            listaAlunos.Add(a1);
            listaAlunos.Add(a2);
            listaAlunos.Add(a3);
            listaAlunos.Add(a4);
            listaAlunos.Add(a5);
            // Enviando a lista de Alunos por parametro na View Index
            return View(listaAlunos);
        }


        public IActionResult Cadastrar()
        {
            return View();
        }

    }
}
