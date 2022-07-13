namespace AlkemyPrimerDesafio.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; } // --> Content = Comment

        public User User { get; set; }
    }
}
