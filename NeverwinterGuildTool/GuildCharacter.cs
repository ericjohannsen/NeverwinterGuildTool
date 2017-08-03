using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeverwinterGuildTool
{
    public class GuildCharacter
    {
        public string Name { get; set; }

        public string Account { get; set; }

        public int Level { get; set; }

        public string Class { get; set; }

        public string Rank { get; set; }

        /// <summary>
        /// Not currently set in the export
        /// </summary>
        public int ContributionTotal { get; set; }

        public DateTime JoinDate { get; set; }

        public DateTime? RankChangeDate { get; set; }

        public DateTime LastActiveDate { get; set; }

        public int AccountAge
        {
            get
            {
                DateTime now = DateTime.Now; // Avoid edge case of midnight rolling over while the next line runs
                DateTime today = new DateTime(now.Year, now.Month, now.Day);
                int deltaDays = (int)new TimeSpan(today.Ticks - LastActiveDate.Ticks).TotalDays;
                return deltaDays;
            }
        }
    }
}
