using Application.Interfaces;
using Application.Utils;
using Application.ViewModels.UserViewModels;
using AutoMapper;
using Domain.Entities;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ICurrentTime _currentTime;
        private readonly ServiceResponse _response;
        private readonly AppConfiguration _configuration;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper, ICurrentTime currentTime, AppConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _currentTime = currentTime;
            _configuration = configuration;
            _response = new ServiceResponse();
        }
        public async Task<ServiceResponse> CreateUserAsync(UserCreateDTO userCreate)
        {
            var isExited = await _unitOfWork.Users.CheckUserNameExited(userCreate.UserName);

            if (isExited)
            {
                return _response.Fail("Username exited please try again");
            }

            var newUser = new User
            {
                UserName = userCreate.UserName,
                Password = userCreate.Password.Hash(),
                FullName = userCreate.FullName,
                Email = userCreate.Email,
                PhoneNumber = userCreate.PhoneNumber,
                DateOfBirth = userCreate.DoB,
                Level = userCreate.Level,
                Gender = userCreate.Gender
            };

            await _unitOfWork.Users.AddAsync(newUser);
            await _unitOfWork.SaveChangesAsync();

            return _response.Success(new { newUser.Id });
        }

        public async Task<ServiceResponse> LoginAsync(UserLoginDTO userDTO)
        {
            var user = await _unitOfWork.Users.GetUserByUserNameAndPasswordHash(userDTO.UserName, userDTO.Password.Hash());
            if (user == null)
            {
                return _response.Fail("Wrong UserName or Password");
            }
            string token = user.GenerateJsonWebToken(_configuration.SecretKey, _currentTime.GetCurrentTime());
            return _response.Success(token);
        }

        public async Task<ServiceResponse> GetAllUsersAsync()
        {
            List<User> users = await _unitOfWork.Users.GetAllAsync();
            return _response.Success(_mapper.Map<List<UserListViewDTO>>(users));
        }

        public async Task<ServiceResponse> GetUserByIdAsync(int id)
        {
            User users = await _unitOfWork.Users.GetAsync(x => x.Id == id);
            return _response.Success(_mapper.Map<UserViewDTO>(users));
        }

        public async Task<ServiceResponse> UpdateMeAsync(int id, UserUpdateMeDTO userUpdate)
        {
            User user = await _unitOfWork.Users.GetAsync(x => x.Id == id);

            user.FullName = userUpdate.FullName ?? user.FullName;
            user.Email = userUpdate.Email ?? user.Email;
            user.PhoneNumber = userUpdate.PhoneNumber ?? user.PhoneNumber;
            user.DateOfBirth = userUpdate.DateOfBirth ?? user.DateOfBirth;
            user.Gender = userUpdate.Gender ?? user.Gender;

            await _unitOfWork.SaveChangesAsync();
            return _response.Success(_mapper.Map<UserViewDTO>(user));
        }

        public async Task<ServiceResponse> UpdateUserAsync(int id, UserUpdateDTO userUpdate)
        {
            User user = await _unitOfWork.Users.GetAsync(x => x.Id == id);

            user.Level = userUpdate.Level ?? user.Level;
            user.Status = userUpdate.Status ?? user.Status;
            user.Role = userUpdate.Role ?? user.Role;

            await _unitOfWork.SaveChangesAsync();
            return _response.Success(_mapper.Map<UserViewDTO>(user));
        }
    }
}