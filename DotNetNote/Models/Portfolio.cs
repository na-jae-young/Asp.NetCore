using System.Text.Json;
using System.Text.Json.Serialization;

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

        [JsonPropertyName("img")] // json파일에서의 img이름 데이터를 갖어온다.  json파일로 변환할때는 img로 바꾼다. 
        public string Image { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Portfolio>(this); //json으로 변환시켜줌 
        }

    }
}
