namespace FinanceApp.Domain.DTOs.Group.Responses
{
    public class ListTagResponse
    {
        public ListTagResponse()
        {
            Groups = new List<GroupDTO>();
        }
        public List<GroupDTO> Groups { get; set; }
    }
}
