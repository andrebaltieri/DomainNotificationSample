using Balta.SharedKernel.Commands;

namespace Balta.Domain.Commands.UserCommands
{
    public class RegisterUserCommand : Command
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
