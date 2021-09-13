using System;
using Personen;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    public class Manager : Medewerker
    {
        public Manager(string voornaam, string achternaam, string rol, string afdeling) : base(voornaam, achternaam, rol)
        {
            Afdeling = afdeling;
        }
        public string Afdeling { get; set; }
        public override string WieBenIk()
        {
            var wieBenIk = base.WieBenIk();
            return $"{wieBenIk} en mijn afdeling is {Afdeling}";
        }
    }
}
