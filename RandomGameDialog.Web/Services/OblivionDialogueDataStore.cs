using LINQtoCSV;
using RandomGameDialog.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RandomGameDialog.Web.Services
{
    public class OblivionDialogueDataStore : IOblivionDialogueDataStore
    {
        private static string DialogueDataPath = @"Data";
        private static string DialogueDataFile = @"oblivion_dialogue_export.csv";
        private readonly Lazy<IEnumerable<OblivionDialogue>> _dialogue;
        private IEnumerable<OblivionDialogue> _directDialogue => _dialogue.Value;

        private string DialogueFilePath => Path.Combine(Environment.CurrentDirectory, DialogueDataPath, DialogueDataFile);


        public OblivionDialogueDataStore()
        {
            _dialogue = new Lazy<IEnumerable<OblivionDialogue>>(() => InitializeDataStore());
        }

        private IEnumerable<OblivionDialogue> InitializeDataStore()
        {
            using var file = File.Open(DialogueFilePath, FileMode.Open, FileAccess.Read);
            using var reader = new StreamReader(file);
            var cc = new CsvContext();
            var inputFileDescription = new CsvFileDescription
            {
                SeparatorChar = '\t',
                FirstLineHasColumnNames = true,
                EnforceCsvColumnAttribute = true,
                IgnoreUnknownColumns = true
            };
            return cc.Read<OblivionDialogue>(reader, inputFileDescription).Where(d=> !string.IsNullOrWhiteSpace(d.Dialogue)).ToList();
        }

        public string GetRandomLine(string filter = null, IEnumerable<string> tokens = null)
        {
            var availableDialogue = _directDialogue;
            if (!string.IsNullOrWhiteSpace(filter))
            {
                availableDialogue = availableDialogue.Where(d =>
                (!string.IsNullOrWhiteSpace(d.BehaviorContext) && d.BehaviorContext.Contains(filter, StringComparison.InvariantCultureIgnoreCase)) ||
                (!string.IsNullOrWhiteSpace(d.LocationContext) && d.LocationContext.Contains(filter, StringComparison.InvariantCultureIgnoreCase)));
            }
            else if (tokens != null && tokens.Any())
            {
                availableDialogue = availableDialogue.Where(d => tokens.All(t => !string.IsNullOrWhiteSpace(d.Dialogue) && d.Dialogue.Contains(t)));
            }

            if (!availableDialogue.Any())
            {
                return null;
            }
            var index = new Random().Next(0, availableDialogue.Count() - 1);
            return availableDialogue.ElementAt(index).Dialogue;
        }
    }

    public interface IOblivionDialogueDataStore
    {
        string GetRandomLine(string filter = null, IEnumerable<string> tokens = null);
    }
}
