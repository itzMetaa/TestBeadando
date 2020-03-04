using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestBeadando
{
    [TestFixture]
    class Test
    {
        [TestCase]
        public void Eloadas()
        {
            Eloadas eloadas = new Eloadas(5, 5);
            Assert.AreEqual(new bool[5, 5], eloadas.Foglalasok);
        }
        [TestCase]
        public void EloadasRossz()
        {
            Assert.Throws<ArgumentException>(() => {
                Eloadas eloadas = new Eloadas(-1, -1);
            });
        }

        [TestCase]
        public void Foglal()
        {
            Eloadas eloadas = new Eloadas(1, 1);
            eloadas.Foglal();
            bool[,] expected = new bool[1, 1];
            expected[0, 0] = true;
            Assert.AreEqual(expected, eloadas.Foglalasok);
        }
        [TestCase]
        public void FoglalRossz()
        {
            Eloadas eloadas = new Eloadas(1, 1);
            eloadas.Foglal();
            bool[,] expected = new bool[1, 1];
            expected[0, 0] = true;
            Assert.AreEqual(expected, eloadas.Foglalasok);
        }
        [TestCase]
        public void Szabad()
        {
            Eloadas eloadas = new Eloadas(2, 2);
            Assert.AreEqual(4, eloadas.SzabadHelyek);
        }
        [TestCase]
        public void SzabadFoglal()
        {
            Eloadas eloadas = new Eloadas(2, 2);
            eloadas.Foglal();
            Assert.AreEqual(3, eloadas.SzabadHelyek);
        }
        [TestCase]
        public void SzabadRossz()
        {
            Eloadas eloadas = new Eloadas(2, 2);
            eloadas.Foglal();
            eloadas.Foglal();
            eloadas.Foglal();
            eloadas.Foglal();
            eloadas.Foglal();
            eloadas.Foglal();
            eloadas.Foglal();
            eloadas.Foglal();
            Assert.AreEqual(0, eloadas.SzabadHelyek);
        }
        [TestCase]
        public void Tele()
        {
            Eloadas eloadas = new Eloadas(2, 2);
            eloadas.Foglal();
            eloadas.Foglal();
            eloadas.Foglal();
            eloadas.Foglal();
            eloadas.Foglal();
            eloadas.Foglal();
            eloadas.Foglal();
            Assert.AreEqual(true, eloadas.Teli());
        }
        [TestCase]
        public void NemTele()
        {
            Eloadas eloadas = new Eloadas(2, 2);
            eloadas.Foglal();
            Assert.AreEqual(false, eloadas.Teli());
        }
        [TestCase]
        public void NemFoglalt()
        {
            Eloadas eloadas = new Eloadas(2, 2);
            eloadas.Foglal();
            Assert.AreEqual(false, eloadas.Foglalt(2, 2));
        }
        [TestCase]
        public void Foglalt()
        {
            Eloadas eloadas = new Eloadas(2, 2);
            eloadas.Foglal();
            Assert.AreEqual(true, eloadas.Foglalt(1, 1));
        }
        [TestCase]
        public void FoglaltRossz()
        {
            Eloadas eloadas = new Eloadas(2, 2);
            eloadas.Foglal();
            Assert.Throws<ArgumentException>(() => {
                eloadas.Foglalt(-1, -1);
            });
        }
    }
}
