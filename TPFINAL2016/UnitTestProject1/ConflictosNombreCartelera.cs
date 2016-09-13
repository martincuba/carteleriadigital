using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inicio;

namespace UnitTestProject1
{
    [TestClass]
    public class ConflictosNombreCartelera
    {
        [TestMethod]
        public void TestConflictoNombreCartelera()
        {
            FachadaCartelera FachadaCartelera = new FachadaCartelera();
            
            //Test entre el string prueba y deferentes cadenas con conflictos, salvo un caso
            Assert.AreEqual(FachadaCartelera.ConflictoNombres("prueba", "prueba"),true);
            Assert.AreEqual(FachadaCartelera.ConflictoNombres("prueba", "probando"), false);
            Assert.AreEqual(FachadaCartelera.ConflictoNombres("prueba", "prueba   "), true);
            Assert.AreEqual(FachadaCartelera.ConflictoNombres("prueba", "  prueba   "), true);
        }
    }
}
