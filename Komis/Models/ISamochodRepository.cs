using System.Collections.Generic;

namespace Komis.Models
{
    public interface ISamochodRepository
    {
        IEnumerable<Samochod> PobierzWszystkieSamochody();
        Samochod PobierzSamochodById(int samochodId);

        void DodajSmochod(Samochod samochod);
        void EdytyjSmochod(Samochod samochod);
        void UsunSamochod(Samochod samochod);
    }
}
