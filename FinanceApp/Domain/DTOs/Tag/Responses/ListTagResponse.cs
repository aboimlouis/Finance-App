namespace FinanceApp.Domain.DTOs.Tag.Responses
{
    public class ListTagResponse
    {
        public ListTagResponse()
        {
            Tags = new List<TagDTO>();
        }
        public List<TagDTO> Tags { get; set; }
    }
}
