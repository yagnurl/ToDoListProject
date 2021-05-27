using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TodoListProject.Shared.Auth;
using TodoListProject.Shared.Dto;

namespace ToDoListProject.Client.Services
{
    public interface IAuthenticationService
    {
        AuthenticateResponse User { get; }
        Task Initialize();
        Task Login(string username, string password);
        Task Logout();
        Task<HttpResponseMessage> Register(UserForCreationDto user);
    }
}
