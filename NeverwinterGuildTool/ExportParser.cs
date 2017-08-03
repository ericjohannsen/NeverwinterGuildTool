using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeverwinterGuildTool
{
    public class ExportParser
    {
        public IEnumerable<GuildCharacter> ParseGuildExport(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) throw new Exception("The guild export file path must be specified.");
            if (!File.Exists(path)) throw new Exception($"The guild export file was not found {path}");
            if (!path.EndsWith(".csv", StringComparison.InvariantCultureIgnoreCase)) throw new Exception("The guild export file must be a .csv.");

            string[] cells;
            bool isHeader = true;

            // We can't use an off-the-shelf CSV parser because Neverwinter doesn't conform to the CSV standard.
            // Quotes and commas in the member comment are not properly escaped and quoted.
            using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (BufferedStream bs = new BufferedStream(fs))
            using (StreamReader sr = new StreamReader(bs))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }
                    cells = line.Split(',');

                    if (cells.Where(c => !string.IsNullOrWhiteSpace(c)).Any()) // Line is not entirely blank
                    {
                        GuildCharacter gc = new GuildCharacter();

                        gc.Name = cells[0];
                        gc.Account = cells[1];
                        gc.Level = int.Parse(cells[2]);
                        gc.Class = cells[3];
                        gc.Rank = cells[4];
                        gc.ContributionTotal = int.Parse(cells[5]);
                        gc.JoinDate = DateTime.Parse(cells[6]);
                        gc.RankChangeDate = string.IsNullOrEmpty(cells[7]) ? null : (DateTime?)DateTime.Parse(cells[7]);
                        gc.LastActiveDate = DateTime.Parse(cells[8]);
                        // The member comment can be totally broken as in 
                        // "Pronounced "Fair, Eh" cause I'm Canadian."
                        // but we're not using cells that far into the line at present
                        yield return gc;
                    }
                }
            }            
        }
    }
}
