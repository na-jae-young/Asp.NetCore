using DotNetNote.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetNote.Pages.Portfolio
{
    public class PortfolioListModel : PageModel
    {
        private readonly PortfolioServiceJsonFile service;
        public IEnumerable<DotNetNote.Models.Portfolio> Portfolios { get; private set; }

        //json 파일에서 데이터 갖어오는 서비스 PortfolioServiceJsonFile
        //등록된 의존식주입 서비스를 view페이지가 아닌 viewback 페이지에  생성자에 매개변수에 주입하여 적용시키는 방법   model.Portfolios 로 표현 
        public PortfolioListModel( PortfolioServiceJsonFile _service)
        {
            this.service = _service;
        }

        public void OnGet() // 클래스 생성시 발동되는 것 
        {
            Portfolios = service.GetPortfolios();
        }
    }
}
