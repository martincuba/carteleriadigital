using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inicio;

namespace UnitTestProject1
{
    [TestClass]
    public class ConflictosFecha
    {
        [TestMethod]
        public void TestConflictoFecha()
        {
            FachadaEvento fachadaEvent = new FachadaEvento();
            // Fecha1 y Fecha2 son el intervalo de comparación para todos los cálculos.
            DateTime Fecha1 = new DateTime(2016, 12, 15, 00, 00, 00);
            DateTime Fecha2 = new DateTime(2016, 12, 18, 00, 00, 00);

            //Prueba que el intervalo se encuentre antes.
            DateTime Fecha3 = new DateTime(2016, 12, 10, 00, 00, 00);
            DateTime Fecha4 = new DateTime(2016, 12, 12, 00, 00, 00);

            Assert.AreEqual(fachadaEvent.ConflictoFecha(Fecha1, Fecha2, Fecha3, Fecha4),false);

            //Prueba que el inicio sea antes pero que el final este contenido.
            DateTime Fecha5 = new DateTime(2016, 12, 12, 00, 00, 00);
            DateTime Fecha6 = new DateTime(2016, 12, 16, 00, 00, 00);

            Assert.AreEqual(fachadaEvent.ConflictoFecha(Fecha1, Fecha2, Fecha5, Fecha6), true);

            //Prueba que este contenido completamente
            DateTime Fecha7 = new DateTime(2016, 12, 16, 00, 00, 00);
            DateTime Fecha8 = new DateTime(2016, 12, 17, 00, 00, 00);

            Assert.AreEqual(fachadaEvent.ConflictoFecha(Fecha1, Fecha2, Fecha7, Fecha8), true);

            //Prueba que inicie antes y termine después
            DateTime Fecha9 = new DateTime(2016, 12, 12, 00, 00, 00);
            DateTime Fecha10 = new DateTime(2016, 12, 21, 00, 00, 00);

            Assert.AreEqual(fachadaEvent.ConflictoFecha(Fecha1, Fecha2, Fecha9, Fecha10), true);

            //Prueba que inicie dentro y termine fuera
            DateTime Fecha11 = new DateTime(2016, 12, 17, 00, 00, 00);
            DateTime Fecha12 = new DateTime(2016, 12, 20, 00, 00, 00);

            Assert.AreEqual(fachadaEvent.ConflictoFecha(Fecha1, Fecha2, Fecha11, Fecha12), true);

            //Prueba el mismo intervalo
            DateTime Fecha13 = new DateTime(2016, 12, 15, 00, 00, 00);
            DateTime Fecha14 = new DateTime(2016, 12, 18, 00, 00, 00);

            Assert.AreEqual(fachadaEvent.ConflictoFecha(Fecha1, Fecha2, Fecha13, Fecha14), true); 
        }
    }
}
