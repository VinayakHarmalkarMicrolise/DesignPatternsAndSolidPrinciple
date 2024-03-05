using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SolidPrinciples.OpenClosedPrinciple
{
    public enum ReportType
    {
        PDF,
        CSV,
        XML
    }
    public class ReportGenertorWithoutOCP
    {
        public void GenerateReport(string data, ReportType type)
        {
            switch (type)
            {
                case ReportType.PDF:
                    Console.WriteLine($"Generating PDF report with data: {data}");
                    break;
                case ReportType.CSV:
                    Console.WriteLine($"Generating CSV report with data: {data}");
                    break;
                case ReportType.XML:
                    Console.WriteLine($"Generating XML report with data: {data}");
                    break;
                default:
                    throw new ArgumentException("Invalid report type");
            }
        }
    }
}
