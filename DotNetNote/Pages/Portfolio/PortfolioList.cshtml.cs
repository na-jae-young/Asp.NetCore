using DotNetNote.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetNote.Pages.Portfolio
{
    public class PortfolioListModel : PageModel
    {
        private readonly PortfolioServiceJsonFile service;
        public IEnumerable<DotNetNote.Models.Portfolio> Portfolios { get; private set; }

        //json ���Ͽ��� ������ ������� ���� PortfolioServiceJsonFile
        //��ϵ� ���������� ���񽺸� view�������� �ƴ� viewback ��������  �����ڿ� �Ű������� �����Ͽ� �����Ű�� ���   model.Portfolios �� ǥ�� 
        public PortfolioListModel( PortfolioServiceJsonFile _service)
        {
            this.service = _service;
        }

        public void OnGet() // Ŭ���� ������ �ߵ��Ǵ� �� 
        {
            Portfolios = service.GetPortfolios();
        }
    }
}
