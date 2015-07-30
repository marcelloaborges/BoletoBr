﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoletoBr.UnitTests
{
    [TestClass]
    public class FatorVencimentoTests
    {
        [TestMethod]
        public void FatorVencimento_21_02_2025()
        {
            DateTime data = new DateTime(2025, 2, 21);
            var fator = Common.FatorVencimento(data);
            Assert.AreEqual(fator, 9999);
        }
        [TestMethod]
        public void FatorVencimento_22_02_2025()
        {
            DateTime dataTeste2 = new DateTime(2025, 2, 22);
            var fator2 = Common.FatorVencimento(dataTeste2);
            Assert.AreEqual(fator2, 1000);
        }
        [TestMethod]
        public void FatorVencimento_4_7_2008()
        {
            DateTime dataTeste3 = new DateTime(2008, 7, 4);
            var fatorTeste3 = Common.FatorVencimento(dataTeste3);
            Assert.AreEqual(fatorTeste3, 3923);
        }
    }
}
