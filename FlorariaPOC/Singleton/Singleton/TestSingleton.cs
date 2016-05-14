using System.Linq;
using NUnit.Framework;

namespace Singleton
{
    [TestFixture]
    public class TestSingleton
    {
        [Test]
        public void CreateSingleton()
        {
            var s1= Singleton.Instance();
            var s2= Singleton.Instance();

            Assert.AreSame(s1,s2);
        }

        [Test]
        public void NoPublicCtor()
        {
            var singleton = typeof(Singleton);
            var ctrs = singleton.GetConstructors();

            var hasPublicCtor = ctrs.Any(ctr => ctr.IsPublic);

            Assert.IsFalse(hasPublicCtor);
        }
    }
}
