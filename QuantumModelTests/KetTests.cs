using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuantumModel;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace QuantumModel.Tests
{
    [TestClass()]
    public class KetTests
    {
        [TestMethod()]
        public void DistrubiveWithScalars()
        {
            Ket k1 = new Ket(new Complex[]{ new Complex(2,2), 2 }, "k1");
            Ket k2 = new Ket(new Complex[]{ new Complex(2,2), 2 }, "k2");
            Ket expected = (3+2) * k1;




            Assert.AreEqual(expected, 3 * k1 + 2 * k1);
        }


    }
}