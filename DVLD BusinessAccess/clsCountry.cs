using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessAccess
{
    public class clsCountry
    {
        public int CountryID {  get; set; }
        public string CountryName {  get; set; }

        public clsCountry() 
        {
            CountryID = -1;
            CountryName = "";

        }
        public clsCountry(int CountryID,string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;

        }

        public static clsCountry Find(int ID)
        {
            string CountryName = "";
            bool Found=clsCountryData.GetCountryInfoByID(ID,ref CountryName);

            if (Found) 
                return new clsCountry(ID,CountryName);
            else
                return null;
        }

        public static clsCountry Find(string CountryName)
        {
            int ID = 0;
            bool Found = clsCountryData.GetCountryInfoByName(CountryName,ref ID);

            if (Found)
                return new clsCountry(ID, CountryName);
            else
                return null;
        }

        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }
    }
}
