namespace News.Models
{
    public class NewsModel
    {
        public int Id { get; set; }
        public string Description { get; set; } //Описание, показывается на странице определенной новости
        public string ShortDescription { get; set; } //Небольшое описание, используется в качестве заголовка на странице с разными новостями
        public string? Category { get; set; } //Категория новости
        public byte[]? Image { get; set; } //Изображение новости
    }
}
