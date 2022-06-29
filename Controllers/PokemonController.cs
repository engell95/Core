using System;
using Microsoft.AspNetCore.Mvc;
using Core.Models;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Text.Json;
using System.Net;

namespace Core.Controllers
{
    public class PokemonController : Controller
    {

        public IConfiguration _configuration;
        private readonly IHttpClientFactory _httpClientFactory;

        public PokemonController(IConfiguration config,IHttpClientFactory httpClientFactory)
        {
            _configuration = config;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "Pokemon Api";

            string json = new WebClient().DownloadString($"https://pokeapi.co/api/v2/pokemon?limit=500");
            Result Pokemon = JsonSerializer.Deserialize<Result>(json);

            return View(Pokemon);
        }
    }
}