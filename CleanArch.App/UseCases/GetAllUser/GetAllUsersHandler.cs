using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CleanArch.App.Interfaces;
using CleanArch.App.Interfaces.Users;
using CleanArch.App.UseCases.CreateUser;
using CleanArch.Domain.Entities;
using MediatR;

namespace CleanArch.App.UseCases.GetAllUser
{
    public sealed class GetAllUsersHandler(IUnitOfWork unitOfWork, IUsersRepository usersRepository, IMapper mapper) :
      IRequestHandler<GetAllUsersRequest, List<GetAllUsersResponse>>
    {
      private readonly IUnitOfWork _unitOfWork = unitOfWork;
      private readonly IUsersRepository _usersRepository = usersRepository;
      private readonly IMapper _mapper = mapper;

      public async Task<List<GetAllUsersResponse>> Handle(GetAllUsersRequest request, CancellationToken cancellationToken)
      {
        
        var users = await _usersRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllUsersResponse>>(users);
        
      }
    }
}