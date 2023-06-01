using SSLAPI.Models;

namespace SSLAPI.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();

        Country GetCountry(int id);

        Country GetCountryByOwner (int ownerId);
        
        ICollection<Owner> GetOwnersFromACountry(int countryId);

        bool CountryExists(int id);

        // Post method

        bool CreateCountry(Country country);

        bool Save();

        // Put
        bool UpdateCountry(Country country);

        // Delete

        bool DeleteCountry(Country country);

    }
}
