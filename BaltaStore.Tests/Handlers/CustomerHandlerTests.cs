using BaltaStore.Domain.StoreContext.Commands.CustomerCommands.Inputs;
using BaltaStore.Domain.StoreContext.Handlers;
using BaltaStore.Tests.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaltaStore.Tests.Handlers
{
    [TestClass]
    public class CustomerHandlerTests
    {
        [TestMethod]
        public void ShouldRegisterCustomerWhenCommandIsValid()
        {
            var command = new CreateCustomerCommand();
            command.FirstName = "Felipe";
            command.LastName = "Bossolani";
            command.Document = "26124258617";
            command.Email = "felipe@gmail.com";
            command.Phone = "11999999999";

            Assert.AreEqual(true, command.Valid());

            var handler = new CustomerHandler(new FakeCustomerRepository(), new FakeEmailService());
            var commandResult = handler.Handle(command);
            Assert.IsNotNull(commandResult);            
        }

        [TestMethod]
        public void ShouldReturnNullWhenCommandIsInvalid()
        {
            var command = new CreateCustomerCommand();
            command.FirstName = "Felipe";
            command.LastName = "Bossolani";
            command.Document = "26124258618";
            command.Email = "felipegmail.com";
            command.Phone = "11999999999";

            var handler = new CustomerHandler(new FakeCustomerRepository(), new FakeEmailService());
            var commandResult = handler.Handle(command);
            Assert.IsNull(commandResult);
        }

    }
}
