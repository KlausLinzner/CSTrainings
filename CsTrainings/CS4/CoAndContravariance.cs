using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CsTrainings.CS4
{
    [TestClass]
    public class CoAndContravariance
    {
        [TestMethod]
        public void Covariance()
        {
            // Covariance. 
            // An object that is instantiated with a more derived type argument   
            // is assigned to an object instantiated with a less derived type argument.   
            object[] objects = new string[5];
            objects[0] = 1;

        }

        [TestMethod]
        public void ContraVariance()
        {
            Action<object> actObject = SetObject;
        }

        static void SetObject(object o)
        {

        }
    }
}
