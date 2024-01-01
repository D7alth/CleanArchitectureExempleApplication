using AutoMapper;
using CleanArch.App.Interfaces;
using CleanArch.App.Interfaces.Users;
using CleanArch.Domain.Entities;
using MediatR;

namespace CleanArch.App.UseCases.CreateUser
{
  public sealed class CreateUserHandler(IUnitOfWork unitOfWork, IUsersRepository usersRepository, IMapper mapper) : 
    IRequestHandler<CreateUserRequest, CreateUserResponse>
  {
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IUsersRepository _usersRepository = usersRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
    {
      var user = _mapper.Map<User>(request);
      _usersRepository.Create(user);
      await _unitOfWork.Commit(cancellationToken);
      return _mapper.Map<CreateUserResponse>(user);
    }
  }
}