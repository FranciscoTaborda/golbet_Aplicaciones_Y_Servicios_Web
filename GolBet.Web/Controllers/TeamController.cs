using GolBet.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GolBet.Web.Controllers;

public class TeamsController : Controller
{
    private readonly ITeamService _teamService;

    public TeamsController(ITeamService teamService)
        => _teamService = teamService;

    // GET /Teams
    public async Task<IActionResult> Index()
    {
        var teams = await _teamService.GetAllTeamsAsync();
        return View(teams);
    }
}