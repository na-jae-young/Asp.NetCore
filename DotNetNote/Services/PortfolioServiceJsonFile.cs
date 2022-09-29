using DotNetNote.Models;
using Microsoft.JSInterop.Implementation;
using System.Text.Json;

namespace DotNetNote.Services
{
    public class PortfolioServiceJsonFile 
    {
        public IEnumerable<Portfolio> GetPortfolios() // 파일경로의 json 파일에서 데이터를 읽어와 Model화 시켜서 반환해준다
        {
            var JsonFileName = @"C:\\Users\\hr\\Desktop\\code\\c#\\DotNetNote\\DotNetNote\\wwwroot\\Portfolios\\portfolio.json";

            using(var jsonFileReader = File.OpenText(JsonFileName))
            {
                var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
                var portfolios = JsonSerializer.Deserialize<Portfolio[]>(jsonFileReader.ReadToEnd(),options);
                return portfolios;
            }

            
        }
    }
}
