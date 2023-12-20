
using dailyquiz.Application.Common.Interfaces;
using dailyquiz.Application.Common.Models;

namespace dailyquiz.Application.Authentication.Commands.Login;

public record LoginCommand(String Email) : IRequest<string>;

public class LoginCommandHanler : IRequestHandler<LoginCommand, string>
{
     private readonly IApplicationDbContext _context;


    public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        // Get Member
        var member = "";
         
        // Gen JWT
        if(member is null)
        {
          
        }
        // Return JWT
    }
}
