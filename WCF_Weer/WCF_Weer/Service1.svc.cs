using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_Weer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        
        public Weerbericht Today()
        {
            return new Weerbericht() { Beschrijving = "regen", Temperatuur = 25 };
        }

        public List<Weerbericht> voorspelling(string days)
        {
            List<Weerbericht> eenList = new List<Weerbericht>();
            eenList.Add(new Weerbericht() { Beschrijving = "regen", Temperatuur = 25 });
            eenList.Add(new Weerbericht() { Beschrijving = "regen", Temperatuur = 25 });

            eenList.Add(new Weerbericht() { Beschrijving = "regen", Temperatuur = 25 });

            eenList.Add(new Weerbericht() { Beschrijving = "regen", Temperatuur = 25 });

            eenList.Add(new Weerbericht() { Beschrijving = "regen", Temperatuur = 25 });

            eenList.Add(new Weerbericht() { Beschrijving = "regen", Temperatuur = 25 });

            List<Weerbericht> lijst2 = new List<Weerbericht>();
            for (int i = 0; i < int.Parse(days); i++)
            {
                lijst2.Add(eenList[i]);
            }
            return lijst2;
        }

    }
}
