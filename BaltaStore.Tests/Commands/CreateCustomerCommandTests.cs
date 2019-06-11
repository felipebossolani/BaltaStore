using BaltaStore.Domain.StoreContext.Commands.CustomerCommands.Inputs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaltaStore.Tests.Commands
{
    [TestClass]
    public class CreateCustomerCommandTests
    {
        [TestMethod]
        public void ShouldValidateWhenCommandIsValid()
        {
            var command = new CreateCustomerCommand();
            command.FirstName = "Felipe";
            command.LastName = "Bossolani";
            command.Document = "26124258617";
            command.Email = "felipe@gmail.com";
            command.Phone = "11999999999";

            Assert.AreEqual(true, command.Valid());
        }
    }
}
