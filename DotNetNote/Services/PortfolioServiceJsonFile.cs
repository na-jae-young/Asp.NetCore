using DotNetNote.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.JSInterop.Implementation;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;



namespace DotNetNote.Services
{
    public class PortfolioServiceJsonFile 
    {
        private readonly IWebHostEnvironment _webHostEnvironment;// 필드 생성   파일경로 wwwroot까지의 

        public PortfolioServiceJsonFile(IWebHostEnvironment webHostEnvironment) // 생성자   ctor taptap   인스턴스 자동 주입됨  의존성 주입 , 종속성주입
        {
            this._webHostEnvironment = webHostEnvironment;  //자동으로 asp.netcore가 주입해서 사용한다.   
        }

        public string JsonFileName 
        {
            get
            {
                return _webHostEnvironment.WebRootPath + "\\Portfolios" + "\\portfolio.json";
            }
             
        }

        public IEnumerable<Portfolio> GetPortfolios() // 파일경로의 json 파일에서 데이터를 읽어와 Model화 시켜서 반환해준다
        {
            var jsonFileName = @"C:\\Users\\hr\\Desktop\\code\\c#\\DotNetNote\\DotNetNote\\wwwroot\\Portfolios\\portfolio.json";

            using(var jsonFileReader = File.OpenText(JsonFileName))
            {
                var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
                var portfolios = JsonSerializer.Deserialize<Portfolio[]>(jsonFileReader.ReadToEnd(),options);
                return portfolios;
            }


        }
    }
}
