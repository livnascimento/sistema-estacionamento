using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using sistema_estacionamento.Context;
using sistema_estacionamento.Models;
using sistema_estacionamento.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace sistema_estacionamento.Controllers;

[method: ActivatorUtilitiesConstructor]
public class HomeController(EstacionamentoContext context) : Controller
{
    private readonly EstacionamentoContext _context = context;

    Estacionamento estacionamento = new Estacionamento(10, 6);

    public IActionResult Index()
    {
        var vagas = _context.Vagas;

        return View(vagas);
    }

    public IActionResult Veiculos()
    {
        var veiculos = _context.Veiculos.ToList();

        return View(veiculos);
    }

    public IActionResult Adicionar()
    {
        var vagasDisponiveis = _context.Vagas
                                .Where(vaga => vaga.Ocupada == false)
                                .Select(vaga => new SelectListItem { Value = vaga.Id.ToString(), Text = vaga.Id.ToString() })  // Ajuste isso conforme sua classe Vaga
                                .ToList();
        ViewBag.VagasDisponiveis = vagasDisponiveis;
        return View();
    }

    [HttpPost]
    public IActionResult Adicionar(InfoVeiculo infoVeiculo)
    {
        if (ModelState.IsValid)
        {
            var vaga = _context.Vagas.Find(infoVeiculo.Vaga);
            DateTime horarioEntrada = DateTime.Now;

            if (vaga != null)
            {
                Veiculo veiculo = new(infoVeiculo.Placa, infoVeiculo.Tipo, vaga.Id, horarioEntrada);
                _context.Veiculos.Add(veiculo);

                vaga.Ocupada = true;
                _context.Update(vaga);

                _context.SaveChanges();
            }
        }
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Remover(int id)
    {
        var veiculo = _context.Veiculos.Find(id);

        double total = estacionamento.CalcularTotal(veiculo.HorarioEntrada);

        ViewBag.TotalEstacionamento = (total / 100).ToString();;

        return View(veiculo);
    }

    [HttpPost]
    public IActionResult Remover(Veiculo veiculo)
    {
        var veiculoBanco = _context.Veiculos.Find(veiculo.Id);

        var vaga = _context.Vagas.Find(veiculoBanco.VagaId);

        vaga.Ocupada = false;
        _context.Update(vaga);

        _context.Remove(veiculoBanco);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Encerrar()
    {
        return View(estacionamento);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
