using Balta.Domain.Commands.UserCommands;
using Balta.Domain.Entities;
using Balta.Domain.Repositories;
using Balta.Domain.Resources;
using Balta.SharedKernel.Assertions;
using Balta.SharedKernel.Commands;

namespace Balta.Services.UserServices
{
    public class RegisterUserService : ServerCommand
    {
        private RegisterUserCommand _command;
        private IUserRepository _repository;

        public RegisterUserService(RegisterUserCommand command, IUserRepository repository) : base(command)
        {
            _command = command;
            _repository = repository;
        }

        public void Run()
        {
            Validate();
            if (HasNotifications())
                return;

            var user = new User(_command.Username, _command.Password);
            _repository.Save(user);
        }

        public void Validate()
        {
            AddNotification(Assert.Lenght(_command.Username, 5, 20, "Username", ValidationErrors.UsernameIsInvalid));
        }
    }
}
