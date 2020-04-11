using System.Security.Claims;
using Commerce.Framework.Application.Services;
using Microsoft.AspNetCore.Http;

namespace Commerce.Framework.Infrastructure.Services
{
    public class CurrentUserService : ICurrentUserService
    {

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            UserId = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public string UserId { get; private set; }
    }
}