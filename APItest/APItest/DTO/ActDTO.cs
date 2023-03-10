using APItest.Models;

namespace APItest.DTO
{
    public class ActDTO
    {
        public int 活動id { get; set; }
        public string? 地區 { get; set; }
        public string? 縣市 { get; set; }
        public IFormFile photo { get; set; }


        //public virtual Camp 營區 { get; set; }
        public IEnumerable<Camp>? 營區表單 { get; set; }
        
    }
}
