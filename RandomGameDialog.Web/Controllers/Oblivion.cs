using LINQtoCSV;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Linq;

namespace RandomGameDialog.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Oblivion : ControllerBase
    {

        private readonly ILogger<Oblivion> _logger;

        public Oblivion(ILogger<Oblivion> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Post()
        {
            var filename = @"oblivionlines.min.csv";
            using var file = System.IO.File.Open(Path.Combine(Environment.CurrentDirectory, "data", filename), FileMode.Open, FileAccess.Read);
            using var reader = new StreamReader(file);
            var cc = new CsvContext();
            var inputFileDescription = new CsvFileDescription
            {
                SeparatorChar = '\t',
                FirstLineHasColumnNames = false,
                EnforceCsvColumnAttribute = true,
                IgnoreUnknownColumns = true
            };
            var lines = cc.Read<OblivionLine>(reader, inputFileDescription);
            var index = new Random().Next(0, lines.Count() - 1);
            return Ok(new { response_type = "in_channel", text = lines.ElementAt(index).Line });
        }
    }

    public class OblivionLine
    {
        [CsvColumn(FieldIndex = 0)]
        public string Line { get; set; }
    }
}
