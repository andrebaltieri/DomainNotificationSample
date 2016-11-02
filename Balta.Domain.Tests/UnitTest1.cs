using Balta.Domain.Commands.UserCommands;
using Balta.Domain.Entities;
using Balta.Domain.Repositories;
using Balta.Services.UserServices;
using Balta.SharedKernel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Balta.Domain.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var runtime = new Runtime();

            RegisterUserCommand command = new RegisterUserCommand();
            command.Username = "";
            command.Password = "balt";

            RegisterUserService service = new RegisterUserService(command, new FakeUserRepository());
            service.Run();

            runtime.AddNotifications(service.GetNotifications());

            Assert.IsTrue(runtime.HasNotifications());
        }
    }

    public class FakeUserRepository : IUserRepository
    {
        public void Save(User user)
        {
            return;
        }
    }
}
