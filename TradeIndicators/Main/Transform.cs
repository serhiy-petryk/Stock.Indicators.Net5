using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public static class Transform
    {
        public static void Start()
        {
            var folder = @"E:\Apps\project-2023\Stock.Indicators.Net5\TradeIndicators\TradeIndicators";
            var files = Directory.GetFiles(folder, "*.cs", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Debug.Print(file);
                var changed = false;
                var lines = File.ReadAllLines(file).ToList();
                for (var k = 0; k < lines.Count; k++)
                {
                    var line = lines[k];
                    if (line.StartsWith("namespace ", StringComparison.InvariantCultureIgnoreCase) &&
                        line.EndsWith(";"))
                    {
                        lines[k] = line.Substring(0, line.Length - 1).TrimEnd() + " {";
                        lines.Add("}");
                        changed = true;
                    }
                }

                if (changed)
                {
                    File.WriteAllLines(file, lines);
                }
            }
        }
    }
}
