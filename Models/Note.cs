namespace NotesApi.Models
{
    public class Note
    {
        public Guid Id { get; set; }
        public required String Title { get; set; }
        public String? Body { get; set; }
    }
}
