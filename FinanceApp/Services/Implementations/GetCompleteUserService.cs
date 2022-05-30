using AutoMapper;
using FinanceApp.Data.Repositories.Interfaces;
using FinanceApp.Domain.DTOs.User.Responses;
using FinanceApp.Domain.Models;
using FinanceApp.Services.Interfaces;

namespace FinanceApp.Services.Implementations
{
    public class GetCompleteUserService : IGetCompleteUserService
    {
        private IUserRepository _userRepository { get; set; }
        private IMapper _mapper { get; set; }
        public GetCompleteUserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<List<CompleteUserDTO>> GetCompleteUser()
        {
            return _mapper.Map<List<UserModel>, List<CompleteUserDTO>>(await _userRepository.GetCompleteUser());
        }
    }
}
