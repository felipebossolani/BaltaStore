using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaltaStore.Domain.StoreContext.ValueObjects;

namespace BaltaStore.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {
        private Document validDocument;
        private Document invalidDocument;

        public DocumentTests()
        {
            invalidDocument = new Document("12345678900");
            validDocument = new Document("50933459033");
        }

        [TestMethod]
        public void ShouldReturnNotificationWhenDocumentIsNotValid()
        {
            Assert.AreEqual(false, invalidDocument.IsValid);
        }

        [TestMethod]
        public void ShouldReturnNotNotificationWhenDocumentIsValid()
        {
            Assert.AreEqual(true, validDocument.IsValid);
        }
    }
}
