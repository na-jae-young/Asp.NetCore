using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DotNetNote.Services;
using DotNetNote.Models;

namespace DotNetNote.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PortfolioServiceJsonFile service;
        public IEnumerable<Portfolio> Portfolios { get; private set; }

        //json 파일에서 데이터 갖어오는 서비스 PortfolioServiceJsonFile
        //등록된 의존식주입 서비스를 view페이지가 아닌 viewback 페이지에  생성자에 매개변수에 주입하여 적용시키는 방법   model.Portfolios 로 표현 
        public IndexModel(ILogger<IndexModel> logger, PortfolioServiceJsonFile _service) 
        {
            _logger = logger;
            this.service = _service;
        }

        public void OnGet() // 클래스 생성시 발동되는 것 
        {
            Portfolios = service.GetPortfolios();
        }
    }
}