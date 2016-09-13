using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inicio;

namespace UnitTestProject1
{
    [TestClass]
    public class ConflictosHorarios
    {
        [TestMethod]
        public void TestConflictosHorarios()
        {
            FachadaEvento FachadaEvento = new FachadaEvento();

            // Fecha1 y Fecha2 son el intervalo de comparación para todos los cálculos.
            TimeSpan Fecha1 = new TimeSpan(15, 00, 00);
            TimeSpan Fecha2 = new TimeSpan(18, 00, 00);

            // Prueba que el intervalo se encuentre antes.
            TimeSpan Fecha3 = new TimeSpan(12, 00, 00);
            TimeSpan Fecha4 = new TimeSpan(14, 50, 00);

            Assert.AreEqual(FachadaEvento.ConflictoHorario(Fecha1, Fecha2, Fecha3, Fecha4), false);

            // Prueba que el intervalo arranque igual.
            TimeSpan Fecha5 = new TimeSpan(15, 00, 00);
            TimeSpan Fecha6 = new TimeSpan(16, 00, 00);

            Assert.AreEqual(FachadaEvento.ConflictoHorario(Fecha1, Fecha2, Fecha5, Fecha6), true);

            // Prueba el mismo intervalo.
            TimeSpan Fecha7 = new TimeSpan(15, 00, 00);
            TimeSpan Fecha8 = new TimeSpan(18, 00, 00);

            Assert.AreEqual(FachadaEvento.ConflictoHorario(Fecha1, Fecha2, Fecha7, Fecha8), true);

            // Prueba que el intervalo comience dentro y termine fuera.
            TimeSpan Fecha9 = new TimeSpan(17, 59, 00);
            TimeSpan Fecha10 = new TimeSpan(21, 00, 00);

            Assert.AreEqual(FachadaEvento.ConflictoHorario(Fecha1, Fecha2, Fecha9, Fecha10), true);

            // Prueba que el intervalo que empiece afuera y termine adentro.
            TimeSpan Fecha11 = new TimeSpan(13, 00, 00);
            TimeSpan Fecha12 = new TimeSpan(16, 00, 00);

            Assert.AreEqual(FachadaEvento.ConflictoHorario(Fecha1, Fecha2, Fecha11, Fecha12),true);

            // Prueba que empiece antes y termine despúes.
            TimeSpan Fecha15 = new TimeSpan(13, 00, 00);
            TimeSpan Fecha16 = new TimeSpan(20, 00, 00);

            Assert.AreEqual(FachadaEvento.ConflictoHorario(Fecha1, Fecha2, Fecha15, Fecha16),true);
        }
    }
}
