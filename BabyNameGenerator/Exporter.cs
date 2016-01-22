using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BabyNameGenerator
{
    static class Exporter
    {
        private class ExportRow
        {
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public bool IsGood { get; set; }
            public bool IsActive { get; set; }
            public int Wins { get; set; }
            public int Losses { get; set; }
            public int Score { get; set; }

            public ExportRow(string firstName, string middleName, bool isGood, bool isActive, int wins, int losses)
            {
                this.FirstName = firstName;
                this.MiddleName = middleName;
                this.LastName = "Points";
                this.IsGood = isGood;
                this.IsActive = isActive;
                this.Wins = wins;
                this.Losses = losses;
                this.Score = 2 * this.Wins - this.Losses;

                if (!this.IsActive)
                {
                    this.Score -= 50;
                }
            }
        }

        private static List<ExportRow> CreateList()
        {
            List<ExportRow> tempList = new List<ExportRow>();

            using (var context = new NameGeneratorContext())
            {
                var query = context.full_name
                    .Where(n => n.Good == true)
                    .ToList();

                foreach (full_name name in query)
                {
                    bool active = name.middle_name.Active && name.first_name.Active;

                    var goodNames = context.full_name
                        .Where(n => n.Good == true);

                    var badNames = context.full_name
                        .Where(n => n.Good == false);

                    int winsFirst = goodNames
                        .Where(n => n.FirstID == name.FirstID)
                        .Count();

                    int winsMiddle = goodNames
                        .Where(n => n.MiddleID == name.MiddleID)
                        .Count();

                    int lossesFirst = badNames
                        .Where(n => n.FirstID == name.FirstID)
                        .Count();

                    int lossesMiddle = badNames
                        .Where(n => n.MiddleID == name.MiddleID)
                        .Count();

                    tempList.Add(new ExportRow(name.first_name.Name,name.middle_name.Name,name.Good, active, winsFirst + winsMiddle, lossesFirst + lossesMiddle));
                }
            }

            return tempList;
        }

        private static string CreateCSVTextFile<T>(List<T> data, string seperator = ",")
        {
            var properties = typeof(T).GetProperties();
            var result = new StringBuilder();

            foreach (var row in data)
            {
                var values = properties.Select(p => p.GetValue(row, null));
                var line = string.Join(seperator, values);
                result.AppendLine(line);
            }

            return result.ToString();
        }

        public static void ExportToFile()
        {
            string output = CreateCSVTextFile(CreateList());

            System.Windows.Forms.SaveFileDialog destination = new System.Windows.Forms.SaveFileDialog();
            destination.DefaultExt = "csv";

            if (destination.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (StreamWriter writer = File.CreateText(destination.FileName))
                {
                    writer.Write(output);
                }
            }
        }
    }
}
