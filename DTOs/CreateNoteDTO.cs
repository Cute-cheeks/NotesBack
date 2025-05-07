namespace NotesApi.DTOs
{
    public class CreateNoteDTO
    {
        public required String Title { get; set; }
        public String? Body { get; set; }
    }
}
