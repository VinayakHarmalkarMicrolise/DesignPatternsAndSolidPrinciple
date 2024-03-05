using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SolidPrinciples.OpenClosedPrinciple
{

    public interface IReportGenerator
    {
        public void GenerateReport(string data);
    }

    public class ReportGeneratorPDF : IReportGenerator
    {
        public void GenerateReport(string data)
        {
            Console.WriteLine("Pdf Report Generated ");
        }
    }

    public class ReportGeneratorXML : IReportGenerator
    {
        public void GenerateReport(string data)
        {
            Console.WriteLine("Generate XML report");
        }
    }

    public class ReportGenveratorCSV : IReportGenerator
    {
        public void GenerateReport(string data)
        {
            Console.WriteLine("Generate CSV report");
        }
    }

    public class ReportGenerator
    {
        private readonly IReportGenerator _reportGenerator;

        public ReportGenerator(IReportGenerator reportGenerator)
        {
            this._reportGenerator = reportGenerator;
        }
        public void GenerateReport(string Data)
        {
            _reportGenerator.GenerateReport(Data);
        }
    }
}
