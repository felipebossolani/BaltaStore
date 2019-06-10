using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaltaStore.Domain.StoreContext.ValueObjects;

namespace BaltaStore.Tests.ValueObjects
{
    [TestClass]
    public class NameTests
    {
        [TestMethod]
        public void ShouldReturnNotificationWhenNameIsNotValid()
        {
            var name = new Name("", "Bossolani");
            Assert.AreEqual(false, name.IsValid);
        }

        [TestMethod]
        public void ShouldNotReturnNotificationWhenNameIsValid()
        {
            var name = new Name("Felipe", "Bossolani");
            Assert.AreEqual(true, name.IsValid);
        }
    }
}
