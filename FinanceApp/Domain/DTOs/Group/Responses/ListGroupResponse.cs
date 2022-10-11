namespace FinanceApp.Domain.DTOs.Group.Responses
{
    public class ListGroupResponse
    {
        public ListGroupResponse()
        {
            Groups = new List<GroupDTO>();
        }
        public List<GroupDTO> Groups { get; set; }
    }
}
