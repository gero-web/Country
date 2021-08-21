using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Country.Models;
using Country.Models.CountryModel;
using Country.Models.SerializerModel;
using Microsoft.EntityFrameworkCore;

namespace Country.Data
{
    public class SaveData
    {

        private readonly CountryDBContext _context;
        public SaveData(CountryDBContext context)
        {
            _context = context;
        }

        public  void Save( SerializerCountry _data)
        {
            var region = _context.Regions.FirstOrDefault(region => region.Name == _data.region)  ?? new Regions { Name = _data.region};
            var cites = _context.Cities.FirstOrDefault(cite => cite.Name == _data.capital) ?? new Cities { Name = _data.capital };

            var country = _context.Countrys.FirstOrDefault(country => country.CodeCountry == _data.numericCode) ?? new Countrys();

            country.Name = _data.name;
            country.Population = _data.population ?? 0;

            country.Square = _data.area ?? 0;
            country.CodeCountry = _data.numericCode;

            country.Region = region;
            country.Capital = cites;

            if(country.Id == 0)
                 _context.Countrys.Add(country);
            _context.SaveChanges();
            
        }

    }
}
