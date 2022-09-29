using System.Text.Json;

namespace DotNetNote.Models
{
    public class Portfolio
    {
        /// <summary>
        ///  모델 클래스
        /// </summary>
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description{get;set ;}
        public string Image { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Portfolio>(this); //json으로 변환시켜줌 
        }

    }
}
