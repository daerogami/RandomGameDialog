using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomGameDialog.Web.Models;
using RandomGameDialog.Web.Services;
using System;
using System.Linq;

namespace RandomGameDialog.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OblivionController : ControllerBase
    {
        private readonly ILogger<OblivionController> _logger;
        private readonly IOblivionDialogueDataStore _dataStore;


        public OblivionController(ILogger<OblivionController> logger, IOblivionDialogueDataStore dataStore)
        {
            _logger = logger;
            _dataStore = dataStore;
        }

        [HttpPost]
        //[Consumes("application/x-www-form-urlencoded")]
        public IActionResult Post([FromForm]SlashCommandPayload request)
        {
            var tokens = request?.Text?.Trim().Split(" ") ?? Array.Empty<string>();
            var command = tokens.FirstOrDefault()?.ToLower() ?? "";
            var commandParams = tokens.Skip(1).Select(s => s.ToLower());
            if (!tokens.Any())
            {
                var line = _dataStore.GetRandomLine();
                return Ok(new { response_type = "in_channel", text = line });
            }
            else if (command == "help")
            {
                var helpMessage = $"What's the matter citizen? Too much skooma in your mudcrab stew? Fine, here is what you can request:{Environment.NewLine}" +
                    $"`/oblivion help`\tShows this dialogue{Environment.NewLine}" +
                    $"`/oblivion`\tDisplays a random dialogue{Environment.NewLine}" +
                    $"`/oblivion search <tokens>`\tDisplays a random piece of dialogue containing all of the space-separated tokens{Environment.NewLine}" +
                    $"`/oblivion filter <string>`\tDisplays a random piece of dialogue within the provided context{Environment.NewLine}" +
                    $"\tFilters I have permitted you to know: `generic`, `hello`, `leave`, `bye`, `attack` and `murder`";
                return Ok(new { response_type = "ephemeral", text = helpMessage });
            }
            else if (command == "search" && commandParams.Any())
            {
                var line = _dataStore.GetRandomLine(tokens: commandParams);
                return string.IsNullOrWhiteSpace(line) ? Ok(new { response_type = "ephemeral", text = "No dialogue matching specified criteria" }) : Ok(new { response_type = "in_channel", text = line });
            }
            else if (command == "filter" && commandParams.Any())
            {
                var line = _dataStore.GetRandomLine(filter: commandParams.First());
                return string.IsNullOrWhiteSpace(line) ? Ok(new { response_type = "ephemeral", text = "No dialogue matching specified criteria" }) : Ok(new { response_type = "in_channel", text = line });
            }

            return Ok(new
            {
                response_type = "ephemeral",
                text = "You have failed to provide a valid request. For that you shall pay with your blood!"
            });
        }
    }
}
