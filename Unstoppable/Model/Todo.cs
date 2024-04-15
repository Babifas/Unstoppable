namespace Unstoppable.Model
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int UserId {  get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CompletedAt { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted {  get; set; }
    }
}
