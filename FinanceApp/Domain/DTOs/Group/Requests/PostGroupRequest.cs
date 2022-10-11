namespace FinanceApp.Domain.DTOs.Group.Requests
{
    public class PostGroupRequest
    {
        public PostGroupRequest()
        {
            Group = new PostGroupDTO();
        }
        public PostGroupDTO Group { get; set; }
    }
}
