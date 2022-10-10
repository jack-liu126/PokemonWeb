using Dapper;
using Microsoft.AspNetCore.Mvc;
using PokemonWeb.Models;
using System.Data;

namespace PokemonWeb.Controllers;

public class PokeController : Controller
{
    private readonly IDbConnection _conn;

    public PokeController(IDbConnection conn)
    {
        _conn = conn;
    }

    public async Task<IActionResult> Index()
    {
        string sql = "select * from Pokemons";
        List<Pokemon> ipkl = (await _conn.QueryAsync<Pokemon>(sql)).ToList();
        return View();
    }
}
