using RazorCountry.Models;
using System.Linq;
using System;

namespace RazorCountry.Data
{
    public static class DbInitializerFull
    {
        public static void Initialize(CountryContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Continents.
            if (context.Continents.Any())
            {
                return;   // DB has been seeded
            }

            var Continents = new Continent[]
            {
                new Continent{ID="NA",Name="North America"},
                new Continent{ID="SA",Name="South America"},
                new Continent{ID="EU",Name="Europe"},
                new Continent{ID="AS",Name="Asia"},
                new Continent{ID="AF",Name="Africa"},
                new Continent{ID="AN",Name="Antartica"},
                new Continent{ID="OC",Name="Oceania"},
            };
            foreach (Continent s in Continents)
            {
                context.Continents.Add(s);
            }
            context.SaveChanges();

            var Countries = new Country[]
            {
                new Country{ID="AF",Name="Afghanistan",ContinentID="AS",Population=38041754,Area=251830,UnitedNationsDate=new DateTime(1946,11,19)},
                new Country{ID="AL",Name="Albania",ContinentID="EU",Population=2880917,Area=11100,UnitedNationsDate=new DateTime(1955,12,14)},
                new Country{ID="DZ",Name="Algeria",ContinentID="AF",Population=43053054,Area=919595,UnitedNationsDate=new DateTime(1962,10,8)},
                new Country{ID="AS",Name="American Samoa",ContinentID="OC",Population=55312,Area=77,UnitedNationsDate=null},
                new Country{ID="AD",Name="Andorra",ContinentID="EU",Population=77142,Area=180,UnitedNationsDate=new DateTime(1993,7,28)},
                new Country{ID="AO",Name="Angola",ContinentID="AF",Population=31825295,Area=481400,UnitedNationsDate=new DateTime(1976,12,1)},
                new Country{ID="AI",Name="Anguilla",ContinentID="SA",Population=14869,Area=35,UnitedNationsDate=null},
                new Country{ID="AG",Name="Antigua and Barbuda",ContinentID="NA",Population=97118,Area=170,UnitedNationsDate=new DateTime(1981,11,11)},
                new Country{ID="AR",Name="Argentina",ContinentID="SA",Population=44780677,Area=1073500,UnitedNationsDate=new DateTime(1945,10,24)},
                new Country{ID="AM",Name="Armenia",ContinentID="AS",Population=2957731,Area=11484,UnitedNationsDate=new DateTime(1992,3,2)},
                new Country{ID="AW",Name="Aruba",ContinentID="SA",Population=106314,Area=69,UnitedNationsDate=null},
                new Country{ID="AU",Name="Australia",ContinentID="OC",Population=25203198,Area=2969907,UnitedNationsDate=new DateTime(1945,11,1)},
                new Country{ID="AT",Name="Austria",ContinentID="EU",Population=8955102,Area=32386,UnitedNationsDate=new DateTime(1955,12,14)},
                new Country{ID="AZ",Name="Azerbaijan",ContinentID="AS",Population=10047718,Area=33400,UnitedNationsDate=new DateTime(1992,3,2)},
                new Country{ID="BS",Name="Bahamas",ContinentID="NA",Population=389482,Area=5358,UnitedNationsDate=new DateTime(1973,9,18)},
                new Country{ID="BH",Name="Bahrain",ContinentID="AS",Population=1641172,Area=300,UnitedNationsDate=new DateTime(1971,9,21)},
                new Country{ID="BD",Name="Bangladesh",ContinentID="AS",Population=163046161,Area=56980,UnitedNationsDate=new DateTime(1974,9,17)},
                new Country{ID="BB",Name="Barbados",ContinentID="NA",Population=287025,Area=169,UnitedNationsDate=new DateTime(1966,12,9)},
                new Country{ID="BY",Name="Belarus",ContinentID="EU",Population=9452411,Area=207595,UnitedNationsDate=new DateTime(1945,10,24)},
                new Country{ID="BE",Name="Belgium",ContinentID="EU",Population=11539328,Area=11849,UnitedNationsDate=new DateTime(1945,12,27)},
                new Country{ID="BZ",Name="Belize",ContinentID="SA",Population=390353,Area=8867,UnitedNationsDate=new DateTime(1981,9,25)},
                new Country{ID="BJ",Name="Benin",ContinentID="AF",Population=11801151,Area=44310,UnitedNationsDate=new DateTime(1960,9,20)},
                new Country{ID="BM",Name="Bermuda",ContinentID="NA",Population=62506,Area=21,UnitedNationsDate=null},
                new Country{ID="BT",Name="Bhutan",ContinentID="AS",Population=763092,Area=14824,UnitedNationsDate=new DateTime(1971,9,21)},
                new Country{ID="BO",Name="Bolivia",ContinentID="SA",Population=11513100,Area=424164,UnitedNationsDate=new DateTime(1945,11,14)},
                new Country{ID="BA",Name="Bosnia and Herzegovina",ContinentID="EU",Population=3301000,Area=19741,UnitedNationsDate=new DateTime(1992,5,22)},
                new Country{ID="BW",Name="Botswana",ContinentID="AF",Population=2303697,Area=224610,UnitedNationsDate=new DateTime(1966,10,17)},
                new Country{ID="BR",Name="Brazil",ContinentID="SA",Population=211049527,Area=3287956,UnitedNationsDate=new DateTime(1945,10,24)},
                new Country{ID="VG",Name="British Virgin Islands",ContinentID="NA",Population=30030,Area=59,UnitedNationsDate=null},
                new Country{ID="BN",Name="Brunei",ContinentID="AS",Population=433285,Area=2226,UnitedNationsDate=new DateTime(1984,9,21)},
                new Country{ID="BG",Name="Bulgaria",ContinentID="EU",Population=7000119,Area=42855,UnitedNationsDate=new DateTime(1955,12,14)},
                new Country{ID="BF",Name="Burkina Faso",ContinentID="AF",Population=20321378,Area=105900,UnitedNationsDate=new DateTime(1960,9,20)},
                new Country{ID="BI",Name="Burundi",ContinentID="AF",Population=10864245,Area=10747,UnitedNationsDate=new DateTime(1962,9,18)},
                new Country{ID="KH",Name="Cambodia",ContinentID="AS",Population=16486542,Area=69898,UnitedNationsDate=new DateTime(1955,12,14)},
                new Country{ID="CM",Name="Cameroon",ContinentID="AF",Population=25876380,Area=183569,UnitedNationsDate=new DateTime(1960,9,20)},
                new Country{ID="CA",Name="Canada",ContinentID="SA",Population=37411047,Area=3855100,UnitedNationsDate=new DateTime(1945,11,9)},
                new Country{ID="CV",Name="Cape Verde",ContinentID="AF",Population=549935,Area=1557,UnitedNationsDate=new DateTime(1975,9,16)},
                new Country{ID="KY",Name="Cayman Islands",ContinentID="SA",Population=64948,Area=102,UnitedNationsDate=null},
                new Country{ID="CF",Name="Central African Republic",ContinentID="AF",Population=4745185,Area=240535,UnitedNationsDate=new DateTime(1960,9,20)},
                new Country{ID="TD",Name="Chad",ContinentID="AF",Population=15946876,Area=496000,UnitedNationsDate=new DateTime(1960,9,20)},
                new Country{ID="CL",Name="Chile",ContinentID="SA",Population=18952038,Area=291930,UnitedNationsDate=new DateTime(1945,10,24)},
                new Country{ID="CN",Name="China",ContinentID="AS",Population=1433783686,Area=3705407,UnitedNationsDate=new DateTime(1945,10,24)},
                new Country{ID="CO",Name="Colombia",ContinentID="SA",Population=50339443,Area=440831,UnitedNationsDate=new DateTime(1945,11,5)},
                new Country{ID="KM",Name="Comoros",ContinentID="AF",Population=850886,Area=641,UnitedNationsDate=new DateTime(1975,11,12)},
                new Country{ID="CG",Name="Congo",ContinentID="AF",Population=5380508,Area=132000,UnitedNationsDate=new DateTime(1960,9,20)},
                new Country{ID="CK",Name="Cook Islands",ContinentID="OC",Population=17548,Area=91,UnitedNationsDate=null},
                new Country{ID="CR",Name="Costa Rica",ContinentID="SA",Population=5047561,Area=19700,UnitedNationsDate=new DateTime(1945,11,2)},
                new Country{ID="HR",Name="Croatia",ContinentID="EU",Population=4130304,Area=21851,UnitedNationsDate=new DateTime(1992,5,22)},
                new Country{ID="CU",Name="Cuba",ContinentID="SA",Population=11333483,Area=42426,UnitedNationsDate=new DateTime(1945,10,24)},
                new Country{ID="CW",Name="Curaçao",ContinentID="SA",Population=163424,Area=171,UnitedNationsDate=null},
                new Country{ID="CY",Name="Cyprus",ContinentID="AS",Population=1179551,Area=3572,UnitedNationsDate=new DateTime(1960,9,20)},
                new Country{ID="CZ",Name="Czech Republic",ContinentID="EU",Population=10689209,Area=30450,UnitedNationsDate=new DateTime(1993,1,19)},
             };
            foreach (Country c in Countries)
            {
                context.Countries.Add(c);
            }
            context.SaveChanges();
        }
    }
}