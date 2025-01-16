using EvaluationSampleCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratiqueWithCode_Groupe2.UnitTests
{
    [TestClass]
    internal class BaptizmTests
    {
        [TestMethod]
        public void CanBaptizedBy_ShouldReturnTrue_WhenClergyMemberIsPriest()
        {
            var priest = new ClergyMember { IsPriest = true, IsPope = false };
            var baptizm = new Baptizm(new ClergyMember());

            var result = baptizm.CanBeBaptizedBy(priest);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBaptizedBy_ShouldReturnTrue_WhenClergyMemberIsPope()
        {
            var pope = new ClergyMember { IsPriest = false, IsPope = true };
            var baptizm = new Baptizm(new ClergyMember());

            var result = baptizm.CanBeBaptizedBy(pope);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CanBaptizedBy_ShouldReturnFalse_WhenClergyMemberIsNeitherPriestNorPope()
        {
            var newClergyMember = new ClergyMember { IsPriest = false, IsPope = false };
            var baptizm = new Baptizm(new ClergyMember());

            var result = baptizm.CanBeBaptizedBy(newClergyMember);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanTeachedBy_ShouldReturnTrue_WhenClergyMemberIsSameAsCreatedMember()
        {
            var clergyMember = new ClergyMember();
            var baptizm = new Baptizm(clergyMember);

            var result = baptizm.CanBeTeachedBy(clergyMember);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanTeachedBy_ShouldReturnFalse_WhenClergyMemberIsNotSameAsCreatedMember()
        {
            var alphaClergyMember = new ClergyMember();
            var betaClergyMember = new ClergyMember();
            var baptizm = new Baptizm(alphaClergyMember);

            var result = baptizm.CanBeTeachedBy(betaClergyMember);

            Assert.IsFalse(result);
        }
    }
}
