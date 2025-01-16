using EvaluationSampleCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratiqueWithCode_Groupe2.UnitTests
{
    [TestClass]
    internal class MathOperationsTests
    {
        private MathOperations? mathOperations;

        [TestInitialize]
    
        public void Initialize()
        {
            mathOperations = new MathOperations();
        }

        [TestMethod]

        [DataRow(3, 3, 10)]
        [DataRow(7, 7, 19)]
        [DataRow(12, 12, 22)]

        public void Subtract_ShouldReturnCorrectResult(int numberOne, int numerTwo)
        {
            //j'ai l'impression d'avoir compris pendant l'évaluation. une petite journée de plus et je pense ça aurait été mieux
        }

    }
}
