using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;
using TodoListProject.Client.Services;
using TodoListProject.Shared.Auth;
using ToDoListProject.Client.Services;

namespace TodoListProject.Client.Components
{
    public class LoginBase : ComponentBase
    {
        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        [Inject]
        protected IAuthenticationService AuthenticationService { get; set; }

        protected AuthenticateRequest AuthenticateRequest = new();
        protected bool Loading;
        protected string Error;
        protected async Task HandleValidSubmit()
        {
            Loading = true;
            try
            {
                await AuthenticationService.Login(AuthenticateRequest.Username, AuthenticateRequest.Password);
                //var returnUrl = NavigationManager.QueryString("returnUrl") ?? "/";
                NavigationManager.NavigateTo("");
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                Loading = false;
                StateHasChanged();
            }
        }
    }
}
