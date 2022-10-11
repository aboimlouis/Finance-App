namespace FinanceApp.Domain.DTOs.Tag.Requests
{
    public class PostTagRequest
    {
        public PostTagRequest()
        {
            Tag = new PostTagDTO();
        }
        public PostTagDTO Tag { get; set; }
    }
}
