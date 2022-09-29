using DotNetNote.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.     
builder.Services.AddRazorPages();
builder.Services.AddTransient<PortfolioServiceJsonFile>(); // 의존성 주입을 (종속성주입) 서비스 등록 하여 사용하겠다.(디팬던시 인덱션)
//asp.netcore 의 DI 컨테이너에 서비스 등록 하면 클래스 셍성자에 매개변수롤 직접입력안해도 자동으로 인스턴스 생성이 가능함

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); //정적인 HTML, CSS JS 를 브라우저 상에서 실행하게해주고싶을때   WWWROOT  (미들웨어) 기준은 PAGES 입

//app.UseFileServer(); //index.html 등록시켜줌  기본문서 등록  wwwroot의 index.html을 기준으로 만들어줌 

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
