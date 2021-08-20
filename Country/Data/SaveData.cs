using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Country.Models;
using Country.Models.CountryModel;
using Country.Models.SerializerModel;
namespace Country.Data
{
    public class SaveData
    {
        

        public SaveData()
        {
           
        }

        public static void Save(CountryDBContext _context, SerializerCountry _data)
        {
            var region = _context.Regions.FirstOrDefault(region => region.Name == _data.region)  ?? new Regions { Name = _data.region};
            var cites = _context.Cities.FirstOrDefault(cite => cite.Name == _data.capital) ?? new Cities { Name = _data.capital };

            var country = _context.Country.FirstOrDefault(country => country.CodeCountry == _data.numericCode) ?? new Country.Models.CountryModel.Country { 
                Name = _data.name,
             
                Region = region,
                CodeCountry = _data.numericCode,
                Population = _data.population ?? 0,
                Capital = cites,
                Square = _data.area ?? 0,
            };
            
            _context.Country.Add(country);
            _context.SaveChanges();
            
        }

    }
}
