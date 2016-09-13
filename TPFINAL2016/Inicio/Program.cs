using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            FachadaCartelera FachadaCartelera = new FachadaCartelera();
            FachadaEvento FachadaEvento = new FachadaEvento();
            //FachadaUsuario FachadaUsr = new FachadaUsuario();
            FachadaMedia FachadaMedia = new FachadaMedia();

            Cartelera iCartelera = new Cartelera("wach");

            DateTime Fecha1 = new DateTime(2016, 12, 15);
            DateTime Fecha2 = new DateTime(2016, 12, 15);
            DateTime Fecha3 = new DateTime(2016, 12, 15);
            DateTime Fecha4 = new DateTime(2016, 12, 15);

            TimeSpan Hora1 = new TimeSpan(17, 00, 00);
            TimeSpan Hora2 = new TimeSpan(18, 00, 00);
            TimeSpan Hora3 = new TimeSpan(19, 00, 00);
            TimeSpan Hora4 = new TimeSpan(20, 00, 00);

            CampaniaPublicitaria iCampania1 = new CampaniaPublicitaria("Dia", true, Hora1, Hora2, new List<RangoFecha>());
            CampaniaPublicitaria iCampania2 = new CampaniaPublicitaria("Noche", true, Hora1, Hora2, new List<RangoFecha>());
            CampaniaPublicitaria iCampania3 = new CampaniaPublicitaria("Noche", true, Hora2, Hora3, new List<RangoFecha>());
            CampaniaPublicitaria iCampania4 = new CampaniaPublicitaria("Noche", true, Hora3, Hora4, new List<RangoFecha>());

            RangoFecha RangoFecha1 = new RangoFecha(Fecha1, Fecha2);
            RangoFecha RangoFecha2 = new RangoFecha(Fecha3, Fecha4);
            RangoFecha RangoFecha3 = new RangoFecha(Fecha1, Fecha3);
            RangoFecha RangoFecha4 = new RangoFecha(Fecha1.AddDays(2), Fecha2.AddDays(3));

            iCampania1.ListaRangoFecha.Add(RangoFecha1);
            iCampania2.ListaRangoFecha.Add(RangoFecha2);
            iCampania3.ListaRangoFecha.Add(RangoFecha3);
            iCampania4.ListaRangoFecha.Add(RangoFecha4);


            iCartelera.ListaEventos.Add(iCampania1);
            iCartelera.ListaEventos.Add(iCampania2);
            iCartelera.ListaEventos.Add(iCampania3);
            iCartelera.ListaEventos.Add(iCampania4);


            try
            {
                FachadaCartelera.Create(iCartelera);
                //FachadaEvento.Create(iCampania1);
                //FachadaEvento.Create(iCampania2);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.InnerException.Message);
            }



            //Usuario iUsuario = new Usuario("wachin", "123", TipoUsuario.Invitado);
            //FachadaUsr.Create(iUsuario);

            //iCartelera.ListaEventos.Add(iCampania);


            /*Media iMedia = new Media(@"C:\Users\USUARIO\Pictures\WatchIN.png", 1, 2, 1);
            FachadaMedia.Create(iMedia);*/




            /*  try {
                  Console.WriteLine(Fachada.GetById(1).ListaRangoFecha.First<RangoFecha>().FechaInicio.ToString()); }

              catch (Exception e)
              {
                  Console.WriteLine(e.Message);
              }

              try
              {
                  Console.WriteLine(FachadaEvento.GetByType(TipoEvento.Campania).Count.ToString());
              }
              catch (Exception e)
              {
                  Console.WriteLine(e.InnerException.Message.ToString());
              }*/
            /*
             TimeSpan Hora1 = new TimeSpan(9, 00, 00);
             TimeSpan Hora2 = new TimeSpan(11, 00, 00);
             DateTime Fecha1 = new DateTime(2016, 12, 15);
             RangoFecha RangoFecha = new RangoFecha(Fecha1, Fecha1);
             try
             {
                 List<Evento> iLista = FachadaEvento.EventosEntreFechas(Hora1, Hora2, RangoFecha, TipoEvento.Campania,1);
                 Console.WriteLine(FachadaEvento.EventosEntreFechas(Hora1, Hora2, RangoFecha, TipoEvento.Campania,1).Count);
             }
             catch (Exception e)
             {
                 Console.WriteLine(e.Message);
             }
             
            /*Console.WriteLine(FachadaCartelera.ConflictoNombresCartelera("wach").ToString());
            Console.WriteLine(FachadaCartelera.ConflictoNombresCartelera("wachin").ToString());
            Console.WriteLine(FachadaCartelera.ConflictoNombresCartelera("wach   ").ToString());
            Console.WriteLine(FachadaCartelera.ConflictoNombresCartelera("  wach   ").ToString());
            Console.ReadLine();*/

            //Console.WriteLine(FachadaEvento.ConflictoNombresEvento("Night",1).ToString());
            VentanaCampaña Ventana = new VentanaCampaña(FachadaEvento,1);
            Ventana.ShowDialog();

            Console.ReadLine();
        }
    }
}
