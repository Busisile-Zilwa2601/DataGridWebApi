using System.Collections.Generic;
using DataGridWebApi.Model;


namespace DataGridWebApi.ContextData
{
    public class InMemoryAddressContext : InMemoryDataContext<AddressEntry>
    {
        static readonly IEnumerable<AddressEntry> Addresses = new[]
        {
            new AddressEntry {
                Id = 252,
                Address = "Ap #252-6124 Sed Ave",
                PostalZip = "899193",
                Region = "Cartago",
                Country = "Mexico",
                City = "Weiz"
            },
            new AddressEntry {
                Id = 9937,
                Address = "Ap #657-9937 Quisque Ave",
                PostalZip = "37-43",
                Region = "Møre og Romsdal",
                Country = "Chile",
                City = "Daejeon"
            },
            new AddressEntry {
                Id = 8986,
                Address = "632-8986 Eget St.",
                PostalZip = "HY4 3CS",
                Region = "Limón",
                Country = "Philippines",
                City = "Dublin"
            },
            new AddressEntry {
                Id= 1271,
                Address = "Ap #496-1271 Semper. Street",
                PostalZip = "345485",
                Region = "Montgomeryshire",
                Country = "India",
                City = "Sabadell"
            },
            new AddressEntry {
                Id= 3818,
                Address = "3818 Ut Street",
                PostalZip = "369245",
                Region = "North Jeolla",
                Country = "United Kingdom",
                City = "Illapel"
            },
            new AddressEntry {
                Id= 446,
                Address = "P.O. Box 446, 4029 Donec St.",
                PostalZip = "4601",
                Region = "Cusco",
                Country = "Chile",
                City = "Belgorod"
            },
            new AddressEntry {
                Id= 497,
                Address = "Ap #497-4437 Vel St.",
                PostalZip = "718590",
                Region = "Pskov Oblast",
                Country = "Germany",
                City = "Monguelfo-Tesido/Welsberg-Taisten"
            },
            new AddressEntry {
                Id= 582,
                Address = "582-4069 Cum Road",
                PostalZip = "279904",
                Region = "Sląskie",
                Country = "Germany",
                City = "Toledo"
            },
            new AddressEntry {
                Id= 163,
                Address = "163-5277 Euismod Road",
                PostalZip = "5228",
                Region = "Munster",
                Country = "Belgium",
                City = "Jamnagar"
            },
            new AddressEntry {
                Id= 941,
                Address = "P.O. Box 431, 941 Mauris Rd.",
                PostalZip = "797545",
                Region = "Lower Austria",
                Country = "Ireland",
                City = "Hattian Bala"
            },
            new AddressEntry {
                Id= 6770,
                Address = "P.O. Box 557, 6770 Eu Avenue",
                PostalZip = "59538",
                Region = "South Sumatra",
                Country = "Norway",
                City = "Lambayeque"
            },
            new AddressEntry {
                Id= 7883,
                Address = "7883 Fringilla Ave",
                PostalZip = "764064",
                Region = "Uttar Pradesh",
                Country = "Ukraine",
                City = "Kassel"
            },
            new AddressEntry {
                Id= 1944,
                Address = "1944 Tellus Street",
                PostalZip = "6626",
                Region = "Gilgit Baltistan",
                Country = "Peru",
                City = "Albacete"
            },
            new AddressEntry {
                Id= 233,
                Address = "Ap #233-1191 Velit Street",
                PostalZip = "44221",
                Region = "Vestland",
                Country = "Spain",
                City = "Titagarh"
            },
            new AddressEntry {
                Id= 8180,
                Address = "Ap #484-8180 Sed Rd.",
                PostalZip = "437787",
                Region = "Gangwon",
                Country = "Chile",
                City = "Palopo"
            },
            new AddressEntry {
                Id= 785,
                Address = "Ap #785-8755 Magna. Avenue",
                PostalZip = "737746",
                Region = "Hatay",
                Country = "Pakistan",
                City = "Kansas City"
            },
            new AddressEntry {
                Id= 289,
                Address = "P.O. Box 289, 6148 A, Street",
                PostalZip = "21284",
                Region = "La Libertad",
                Country = "Costa Rica",
                City = "Moulins"
            },
            new AddressEntry {
                Id= 793,
                Address = "793-6071 A, Street",
                PostalZip = "212498",
                Region = "Tamaulipas",
                Country = "Sweden",
                City = "Minna"
            },
            new AddressEntry {
                Id= 4988,
                Address = "4988 Ultricies St.",
                PostalZip = "6194",
                Region = "Sverdlovsk Oblast",
                Country = "France",
                City = "Yeosu"
            },
            new AddressEntry {
                Id= 629,
                Address = "Ap #629-1186 Mauris. Ave",
                PostalZip = "25376",
                Region = "West-Vlaanderen",
                Country = "Ukraine",
                City = "West Valley City"
            },
            new AddressEntry {
                Id= 152,
                Address = "Ap #152-1036 Semper Avenue",
                PostalZip = "4335",
                Region = "Aisén",
                Country = "Ireland",
                City = "Cañas"
            },
            new AddressEntry {
                Id= 873,
                Address = "873-9040 Nunc Ave",
                PostalZip = "1328",
                Region = "Zuid Holland",
                Country = "Pakistan",
                City = "Jeonju"
            },
            new AddressEntry {
                Id= 6152,
                Address = "6152 Massa Avenue",
                PostalZip = "81228",
                Region = "Gangwon",
                Country = "Italy",
                City = "Điện Biên Phủ"
            },
            new AddressEntry {
                Id= 1398,
                Address = "1389 Cursus Rd.",
                PostalZip = "7213 RZ",
                Region = "Henegouwen",
                Country = "Sweden",
                City = "Zierikzee"
            },
            new AddressEntry {
                Id= 488,
                Address = "488-1631 Ac Rd.",
                PostalZip = "2314",
                Region = "Norfolk",
                Country = "United Kingdom",
                City = "Basingstoke"
            },
            new AddressEntry {
                Id= 422,
                Address = "422-7909 Mus. Ave",
                PostalZip = "411859",
                Region = "Loreto",
                Country = "South Korea",
                City = "Oslo"
            },
            new AddressEntry {
                Id= 351,
                Address = "P.O. Box 351, 2899 Cursus, Rd.",
                PostalZip = "51215",
                Region = "Lubelskie",
                Country = "Germany",
                City = "Vinh"
            },
            new AddressEntry {
                Id = 909,
                Address = "909-1919 Sem. Ave",
                PostalZip = "72284",
                Region = "Cagayan Valley",
                Country = "Italy",
                City = "Pettoranello del Molise"
            },
            new AddressEntry {
                Id = 898,
                Address = "P.O. Box 898, 2342 Turpis. Ave",
                PostalZip = "4667",
                Region = "Magadan Oblast",
                Country = "Poland",
                City = "Kristiansund"
            },
            new AddressEntry {
                Address = "577-3306 Vestibulum Av.",
                PostalZip = "57451",
                Region = "Östergötlands län",
                Country = "South Korea",
                City = "Corral"
            },
            new AddressEntry {
                Id = 6590,
                Address = "6590 Lacus. Ave",
                PostalZip = "65-211",
                Region = "Amazonas",
                Country = "Nigeria",
                City = "Cork"
            },
            new AddressEntry {
                Id = 904,
                Address = "P.O. Box 904, 5067 A, Street",
                PostalZip = "04429",
                Region = "Risaralda",
                Country = "Colombia",
                City = "Ribnitz-Damgarten"
            },
            new AddressEntry {
                Address = "Ap #281-979 Vulputate Street",
                PostalZip = "75783-673",
                Region = "Hồ Chí Minh City",
                Country = "Chile",
                City = "Guarapuava"
            },
            new AddressEntry {
                Id = 328,
                Address = "328-793 Vulputate St.",
                PostalZip = "170163",
                Region = "Bắc Kạn",
                Country = "New Zealand",
                City = "Los Álamos"
            },
            new AddressEntry {
                Address = "715-1763 Diam. St.",
                PostalZip = "07203",
                Region = "Canarias",
                Country = "Singapore",
                City = "Okene"
            },
            new AddressEntry {
                Id = 201,
                Address = "Ap #201-4118 Lorem, Road",
                PostalZip = "21912",
                Region = "Navarra",
                Country = "Netherlands",
                City = "Kadiyivka"
            },
            new AddressEntry {
                Id = 219,
                Address = "219-603 Nec Av.",
                PostalZip = "42425",
                Region = "Free State",
                Country = "Canada",
                City = "Serang"
            },
            new AddressEntry {
                Id = 974,
                Address = "Ap #974-8771 Lobortis St.",
                PostalZip = "54986-12305",
                Region = "Agder",
                Country = "Netherlands",
                City = "Ozamiz"
            },
            new AddressEntry {
                Id = 9263,
                Address = "9263 Vestibulum, Ave",
                PostalZip = "6224",
                Region = "Balıkesir",
                Country = "Peru",
                City = "Wuppertal"
            },
            new AddressEntry {
                Id = 666,
                Address = "Ap #666-4920 Dictum Rd.",
                PostalZip = "L88 9FN",
                Region = "Bà Rịa–Vũng Tàu",
                Country = "United States",
                City = "Khyber Agency"
            },
            new AddressEntry {
                Id = 4998,
                Address = "4998 Tempor Street",
                PostalZip = "52395",
                Region = "North Island",
                Country = "Italy",
                City = "Kimberley"
            },
            new AddressEntry {
                Id = 522,
                Address = "522-5594 Parturient Road",
                PostalZip = "5082",
                Region = "Sardegna",
                Country = "Belgium",
                City = "Motueka"
            },
            new AddressEntry {
                Id = 770,
                Address = "P.O. Box 770, 8443 Nostra, Rd.",
                PostalZip = "1011",
                Region = "Franche-Comté",
                Country = "China",
                City = "Hợp Hòa"
            },
            new AddressEntry {
                Id = 803,
                Address = "803-8990 Interdum Av.",
                PostalZip = "1358-8137",
                Region = "Huáběi",
                Country = "Peru",
                City = "Futrono"
            },
            new AddressEntry {
                Id = 2652,
                Address = "2652 Nec Rd.",
                PostalZip = "43860",
                Region = "Vestland",
                Country = "Chile",
                City = "Rio Grande"
            },
            new AddressEntry {
                Id = 620,
                Address = "620-9909 Lobortis. Street",
                PostalZip = "26576",
                Region = "Dōngběi",
                Country = "Norway",
                City = "Etawah"
            },
            new AddressEntry {
                Id = 654,
                Address = "654-580 Amet, St.",
                PostalZip = "5656",
                Region = "Nord-Pas-de-Calais",
                Country = "Australia",
                City = "Candon"
            },
            new AddressEntry {
                Id = 986,
                Address = "Ap #986-492 Accumsan Rd.",
                PostalZip = "389333",
                Region = "Australian Capital Territory",
                Country = "Australia",
                City = "Słupsk"
            },
            new AddressEntry {
                Id = 484,
                Address = "484-2273 Convallis Avenue",
                PostalZip = "55186",
                Region = "Michoacán",
                Country = "Colombia",
                City = "Fujian"
            },
            new AddressEntry {
                Id = 198,
                Address = "Ap #198-5247 Dignissim. Rd.",
                PostalZip = "670463",
                Region = "Free State",
                Country = "Sweden",
                City = "Molenbeersel"
            }
        };

        protected override IEnumerable<AddressEntry> Source => Addresses;
        protected override int GetKey(AddressEntry item) => item.Id;
        protected override void SetKey(AddressEntry item, int key) => item.Id = key;
    }
}
    
