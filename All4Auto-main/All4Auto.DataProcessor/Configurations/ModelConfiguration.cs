namespace All4Auto.DataProcessor.Configurations
{
    using All4Auto.DataProcessor.Models.Vehicles;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ModelConfiguration : IEntityTypeConfiguration<CarModel>
    {
        public void Configure(EntityTypeBuilder<CarModel> builder)
        {
            builder.HasData(CreateModel());
        }

        private List<CarModel> CreateModel()
        {
            var models = new List<CarModel>();


            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 2,
                Name = "1.5",
                TypeCar = "Saloon",
                BodyType = "198501",
                InitialYear = "199012",
                FinalYear = "63",
                KV = "85",
                PM = "1488",
                CC = "13527",
                TTC_TYP_ID = "4401",
                TTC_MOD_ID = "1213",
                TTC_MFA_ID = "D15A1",
                ENGINES = "D15A1"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 2,
                Name = "1.6",
                TypeCar = "Saloon",
                BodyType = "198501",
                InitialYear = "199012",
                FinalYear = "74",
                KV = "100",
                PM = "1590",
                CC = "13529",
                TTC_TYP_ID = "4401",
                TTC_MOD_ID = "1213",
                TTC_MFA_ID = "D16A3",
                ENGINES = "D16A3",
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 2,
                Name = "1.6 i",
                TypeCar = "Saloon",
                BodyType = "198501",
                InitialYear = "199012",
                FinalYear = "88",
                KV = "120",
                PM = "1590",
                CC = "13531",
                TTC_TYP_ID = "4401",
                TTC_MOD_ID = "1213",
                TTC_MFA_ID = "D16A8",
                ENGINES = "D16A8",
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 2,
                Name = "1.5",
                TypeCar = "Hatchback",
                BodyType = "198501",
                InitialYear = "199012",
                FinalYear = "63",
                KV = "85",
                PM = "1488",
                CC = "13532",
                TTC_TYP_ID = "4402",
                TTC_MOD_ID = "1213",
                TTC_MFA_ID = "D15A1",
                ENGINES = "D15A1",
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 2,
                Name = "1.6",
                TypeCar = "Hatchback",
                BodyType = "198501",
                InitialYear = "199012",
                FinalYear = "74",
                KV = "100",
                PM = "1590",
                CC = "13533",
                TTC_TYP_ID = "4402",
                TTC_MOD_ID = "1213",
                TTC_MFA_ID = "D16A1",
                ENGINES = "D16A1",
            });

           models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 2,
                Name = "1.6 i",
                TypeCar = "Hatchback",
                BodyType = "198501",
                InitialYear = "199012",
                FinalYear = "88",
                KV = "120",
                PM = "1590",
                CC = "13534",
                TTC_TYP_ID = "4402",
                TTC_MOD_ID = "1213",
                TTC_MFA_ID = "D16A8",
                ENGINES = "D16A8",
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 2,
                Name = "1.5",
                TypeCar = "Coupe",
                BodyType = "198501",
                InitialYear = "199012",
                FinalYear = "63",
                KV = "85",
                PM = "1488",
                CC = "13535",
                TTC_TYP_ID = "4403",
                TTC_MOD_ID = "1213",
                TTC_MFA_ID = "D15A1",
                ENGINES = "D15A1",
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 2,
                Name = "1.6",
                TypeCar = "Coupe",
                BodyType = "198501",
                InitialYear = "199012",
                FinalYear = "74",
                KV = "100",
                PM = "1590",
                CC = "13536",
                TTC_TYP_ID = "4403",
                TTC_MOD_ID = "1213",
                TTC_MFA_ID = "D16A3",
                ENGINES = "D16A3",
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 2,
                Name = "1.6 i",
                TypeCar = "Coupe",
                BodyType = "198501",
                InitialYear = "199012",
                FinalYear = "88",
                KV = "120",
                PM = "1590",
                CC = "13537",
                TTC_TYP_ID = "4403",
                TTC_MOD_ID = "1213",
                TTC_MFA_ID = "D16A8",
                ENGINES = "D16A8",
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 2,
                Name = "2.0",
                TypeCar = "Saloon",
                BodyType = "198801",
                InitialYear = "199108",
                FinalYear = "107",
                KV = "145",
                PM = "1996",
                CC = "13542",
                TTC_TYP_ID = "4404",
                TTC_MOD_ID = "1213",
                TTC_MFA_ID = "C20A",
                ENGINES = "C20A",
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 2,
                Name = "2.0 Turbo",
                TypeCar = "Saloon",
                BodyType = "198801",
                InitialYear = "199108",
                FinalYear = "140",
                KV = "190",
                PM = "1996",
                CC = "13543",
                TTC_TYP_ID = "4404",
                TTC_MOD_ID = "1213",
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 2,
                Name = "2.5",
                TypeCar = "Saloon",
                BodyType = "198601",
                InitialYear = "198712",
                FinalYear = "122",
                KV = "165",
                PM = "2494",
                CC = "13544",
                TTC_TYP_ID = "4404",
                TTC_MOD_ID = "1213",
                TTC_MFA_ID = "C25A1",
                ENGINES = "C25A1",
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 2,
                Name = "2.7",
                TypeCar = "Saloon",
                BodyType = "198701",
                InitialYear = "199108",
                FinalYear = "130",
                KV = "177",
                PM = "2675",
                CC = "13545",
                TTC_TYP_ID = "4404",
                TTC_MOD_ID = "1213",
                TTC_MFA_ID = "C27A1",
                ENGINES = "C27A1",
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 2,
                Name = "2.7",
                TypeCar = "Coupe",
                BodyType = "198701",
                InitialYear = "199108",
                FinalYear = "130",
                KV = "177",
                PM = "2675",
                CC = "13546",
                TTC_TYP_ID = "4405",
                TTC_MOD_ID = "1213",
                TTC_MFA_ID = "C27A1",
                ENGINES = "C27A1",
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 2,
                Name = "3.2",
                TypeCar = "Saloon",
                BodyType = "199108",
                InitialYear = "199608",
                FinalYear = "151",
                KV = "205",
                PM = "3206",
                CC = "13547",
                TTC_TYP_ID = "4406",
                TTC_MOD_ID = "1213",
                TTC_MFA_ID = "C32A",
                ENGINES = "C32A",
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 2,
                Name = "3.2",
                TypeCar = "Coupe",
                BodyType = "199108",
                InitialYear = "199608",
                FinalYear = "151",
                KV = "205",
                PM = "3206",
                CC = "13548",
                TTC_TYP_ID = "4407",
                TTC_MOD_ID = "1213",
                TTC_MFA_ID = "C32A2",
                ENGINES = "C32A2",
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A8 (4H_)",
                TypeCar = "2.5 TFSI",
                BodyType = "Saloon",
                InitialYear = "201207",
                FinalYear = "",
                KV = "150",
                PM = "204",
                CC = "2498",
                TTC_TYP_ID = "59075",
                TTC_MOD_ID = "8627",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A1 Sportback (8XA 8XK)",
                TypeCar = "1.6 TDI",
                BodyType = "Hatchback",
                InitialYear = "201411",
                FinalYear = "",
                KV = "85",
                PM = "115",
                CC = "1598",
                TTC_TYP_ID = "",
                TTC_MOD_ID = "",
                TTC_MFA_ID = "",
                ENGINES = ""
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A8 (4H_)",
                TypeCar = "3.0 TDI quattro",
                BodyType = "Saloon",
                InitialYear = "201211",
                FinalYear = "",
                KV = "176",
                PM = "239",
                CC = "2967",
                TTC_TYP_ID = "59053",
                TTC_MOD_ID = "8627",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A5 Convertible (8F7)",
                TypeCar = "2.0 TFSI",
                BodyType = "Convertible",
                InitialYear = "201305",
                FinalYear = "",
                KV = "162",
                PM = "220",
                CC = "1984",
                TTC_TYP_ID = "106460",
                TTC_MOD_ID = "8030",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A5 Convertible (8F7)",
                TypeCar = "2.0 TFSI quattro",
                BodyType = "Convertible",
                InitialYear = "201203",
                FinalYear = "",
                KV = "162",
                PM = "220",
                CC = "1984",
                TTC_TYP_ID = "106461",
                TTC_MOD_ID = "8030",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A5 (8T3)",
                TypeCar = "2.0 TFSI quattro",
                BodyType = "Coupe",
                InitialYear = "201203",
                FinalYear = "",
                KV = "162",
                PM = "220",
                CC = "1984",
                TTC_TYP_ID = "106462",
                TTC_MOD_ID = "6243",
                TTC_MFA_ID = "504",
                ENGINES = "504",
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "TT Coupe (FV3)",
                TypeCar = "2.0 TFSI",
                BodyType = "Coupe",
                InitialYear = "201409",
                FinalYear = "",
                KV = "169",
                PM = "230",
                CC = "1984",
                TTC_TYP_ID = "106596",
                TTC_MOD_ID = "12912",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "TT Coupe (FV3)",
                TypeCar = "2.0 TFSI quattro",
                BodyType = "Coupe",
                InitialYear = "201409",
                FinalYear = "",
                KV = "169",
                PM = "230",
                CC = "1984",
                TTC_TYP_ID = "106597",
                TTC_MOD_ID = "12912",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "TT Coupe (FV3)",
                TypeCar = "2.0 TDI",
                BodyType = "Coupe",
                InitialYear = "201409",
                FinalYear = "",
                KV = "135",
                PM = "184",
                CC = "1968",
                TTC_TYP_ID = "106601",
                TTC_MOD_ID = "12912",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A3 Limousine (8VS)",
                TypeCar = "1.8 TFSI",
                BodyType = "Saloon",
                InitialYear = "201311",
                FinalYear = "",
                KV = "125",
                PM = "170",
                CC = "1798",
                TTC_TYP_ID = "101038",
                TTC_MOD_ID = "11282",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "Q3 (8U)",
                TypeCar = "RS 2.5 quattro",
                BodyType = "Closed Off-Road Vehicle",
                InitialYear = "201310",
                FinalYear = "",
                KV = "228",
                PM = "310",
                CC = "2480",
                TTC_TYP_ID = "59663",
                TTC_MOD_ID = "9731",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A3 (8V1)",
                TypeCar = "1.4 TFSI",
                BodyType = "Hatchback",
                InitialYear = "201204",
                FinalYear = "",
                KV = "90",
                PM = "122",
                CC = "1395",
                TTC_TYP_ID = "55092",
                TTC_MOD_ID = "10253",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A3 (8V1)",
                TypeCar = "1.8 TFSI",
                BodyType = "Hatchback",
                InitialYear = "201204",
                FinalYear = "",
                KV = "132",
                PM = "180",
                CC = "1798",
                TTC_TYP_ID = "55093",
                TTC_MOD_ID = "10253",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A3 (8V1)",
                TypeCar = "2.0 TDI",
                BodyType = "Hatchback",
                InitialYear = "201209",
                FinalYear = "",
                KV = "105",
                PM = "143",
                CC = "1968",
                TTC_TYP_ID = "55094",
                TTC_MOD_ID = "10253",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A3 (8V1)",
                TypeCar = "2.0 TDI",
                BodyType = "Hatchback",
                InitialYear = "201204",
                FinalYear = "",
                KV = "110",
                PM = "150",
                CC = "1968",
                TTC_TYP_ID = "55095",
                TTC_MOD_ID = "10253",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "R8",
                TypeCar = "4.2 FSI quattro",
                BodyType = "Coupe",
                InitialYear = "201007",
                FinalYear = "",
                KV = "316",
                PM = "430",
                CC = "4163",
                TTC_TYP_ID = "33658",
                TTC_MOD_ID = "6244",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "R8 Spyder",
                TypeCar = "4.2 FSI quattro",
                BodyType = "Convertible",
                InitialYear = "201009",
                FinalYear = "",
                KV = "316",
                PM = "430",
                CC = "4163",
                TTC_TYP_ID = "33659",
                TTC_MOD_ID = "8262",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A3 (8P1)",
                TypeCar = "1.6 TDI",
                BodyType = "Hatchback",
                InitialYear = "200905",
                FinalYear = "201208",
                KV = "66",
                PM = "90",
                CC = "1598",
                TTC_TYP_ID = "31316",
                TTC_MOD_ID = "4955",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A3 (8P1)",
                TypeCar = "1.6 TDI",
                BodyType = "Hatchback",
                InitialYear = "200905",
                FinalYear = "201208",
                KV = "77",
                PM = "105",
                CC = "1598",
                TTC_TYP_ID = "31317",
                TTC_MOD_ID = "4955",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A3 Sportback (8PA)",
                TypeCar = "1.6 TDI",
                BodyType = "Hatchback",
                InitialYear = "200905",
                FinalYear = "201303",
                KV = "66",
                PM = "90",
                CC = "1598",
                TTC_TYP_ID = "31318",
                TTC_MOD_ID = "5143",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A3 Sportback (8PA)",
                TypeCar = "1.6 TDI",
                BodyType = "Hatchback",
                InitialYear = "200905",
                FinalYear = "201303",
                KV = "77",
                PM = "105",
                CC = "1598",
                TTC_TYP_ID = "31319",
                TTC_MOD_ID = "5143",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A3 Convertible (8P7)",
                TypeCar = "1.6 TDI",
                BodyType = "Convertible",
                InitialYear = "200905",
                FinalYear = "201305",
                KV = "77",
                PM = "105",
                CC = "1598",
                TTC_TYP_ID = "31320",
                TTC_MOD_ID = "6724",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A5 (8T3)",
                TypeCar = "1.8 TFSI",
                BodyType = "Coupe",
                InitialYear = "200905",
                FinalYear = "",
                KV = "118",
                PM = "160",
                CC = "1798",
                TTC_TYP_ID = "31321",
                TTC_MOD_ID = "6243",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "Q7 (4L)",
                TypeCar = "4.2 TDI",
                BodyType = "Closed Off-Road Vehicle",
                InitialYear = "200905",
                FinalYear = "",
                KV = "250",
                PM = "340",
                CC = "4134",
                TTC_TYP_ID = "31430",
                TTC_MOD_ID = "5461",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "TT (8J3)",
                TypeCar = "2.5 TFSI RS quattro",
                BodyType = "Coupe",
                InitialYear = "200907",
                FinalYear = "",
                KV = "250",
                PM = "340",
                CC = "2480",
                TTC_TYP_ID = "31438",
                TTC_MOD_ID = "5544",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "TT Roadster (8J9)",
                TypeCar = "2.5 TFSI RS quattro",
                BodyType = "Convertible",
                InitialYear = "200907",
                FinalYear = "",
                KV = "250",
                PM = "340",
                CC = "2480",
                TTC_TYP_ID = "31439",
                TTC_MOD_ID = "5608",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "TT Roadster (8J9)",
                TypeCar = "2.0 quattro",
                BodyType = "Convertible",
                InitialYear = "200805",
                FinalYear = "",
                KV = "195",
                PM = "265",
                CC = "1984",
                TTC_TYP_ID = "28844",
                TTC_MOD_ID = "5608",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "QUATTRO (85)",
                TypeCar = "2.2 quattro",
                BodyType = "Coupe",
                InitialYear = "198412",
                FinalYear = "198707",
                KV = "89",
                PM = "121",
                CC = "2226",
                TTC_TYP_ID = "27888",
                TTC_MOD_ID = "3910",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "QUATTRO (85)",
                TypeCar = "2.2 quattro",
                BodyType = "Coupe",
                InitialYear = "198412",
                FinalYear = "198707",
                KV = "100",
                PM = "136",
                CC = "2226",
                TTC_TYP_ID = "27889",
                TTC_MOD_ID = "3910",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "Q7 (4L)",
                TypeCar = "3.0 TDI",
                BodyType = "Closed Off-Road Vehicle",
                InitialYear = "200711",
                FinalYear = "",
                KV = "176",
                PM = "240",
                CC = "2967",
                TTC_TYP_ID = "26563",
                TTC_MOD_ID = "5461",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A3 (8P1)",
                TypeCar = "1.4 TFSI",
                BodyType = "Hatchback",
                InitialYear = "200709",
                FinalYear = "201208",
                KV = "92",
                PM = "125",
                CC = "1390",
                TTC_TYP_ID = "26581",
                TTC_MOD_ID = "4955",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A3 Sportback (8PA)",
                TypeCar = "1.4 TFSI",
                BodyType = "Hatchback",
                InitialYear = "200709",
                FinalYear = "201303",
                KV = "92",
                PM = "125",
                CC = "1390",
                TTC_TYP_ID = "26582",
                TTC_MOD_ID = "5143",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A5 Convertible (8F7)",
                TypeCar = "2.0 TDI",
                BodyType = "Convertible",
                InitialYear = "201110",
                FinalYear = "",
                KV = "105",
                PM = "143",
                CC = "1968",
                TTC_TYP_ID = "22766",
                TTC_MOD_ID = "8030",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A5 Convertible (8F7)",
                TypeCar = "2.0 TDI quattro",
                BodyType = "Convertible",
                InitialYear = "201201",
                FinalYear = "",
                KV = "130",
                PM = "177",
                CC = "1968",
                TTC_TYP_ID = "22769",
                TTC_MOD_ID = "8030",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A5 Convertible (8F7)",
                TypeCar = "3.0 TFSI quattro",
                BodyType = "Convertible",
                InitialYear = "201111",
                FinalYear = "",
                KV = "200",
                PM = "272",
                CC = "2995",
                TTC_TYP_ID = "22808",
                TTC_MOD_ID = "8030",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A5 (8T3)",
                TypeCar = "2.0 TDI quattro",
                BodyType = "Coupe",
                InitialYear = "201112",
                FinalYear = "",
                KV = "130",
                PM = "177",
                CC = "1968",
                TTC_TYP_ID = "22826",
                TTC_MOD_ID = "6243",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A5 (8T3)",
                TypeCar = "3.0 TFSI quattro",
                BodyType = "Coupe",
                InitialYear = "201112",
                FinalYear = "",
                KV = "200",
                PM = "272",
                CC = "2995",
                TTC_TYP_ID = "22836",
                TTC_MOD_ID = "6243",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A3 (8P1)",
                TypeCar = "S3 quattro",
                BodyType = "Hatchback",
                InitialYear = "200611",
                FinalYear = "201208",
                KV = "195",
                PM = "265",
                CC = "1984",
                TTC_TYP_ID = "19914",
                TTC_MOD_ID = "4955",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "TT (8N3)",
                TypeCar = "1.8 T",
                BodyType = "Coupe",
                InitialYear = "199810",
                FinalYear = "200606",
                KV = "132",
                PM = "180",
                CC = "1781",
                TTC_TYP_ID = "9901",
                TTC_MOD_ID = "3851",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "TT (8N3)",
                TypeCar = "1.8 T quattro",
                BodyType = "Coupe",
                InitialYear = "199810",
                FinalYear = "200606",
                KV = "132",
                PM = "180",
                CC = "1781",
                TTC_TYP_ID = "9902",
                TTC_MOD_ID = "3851",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "TT (8N3)",
                TypeCar = "1.8 T quattro",
                BodyType = "Coupe",
                InitialYear = "199810",
                FinalYear = "200606",
                KV = "165",
                PM = "224",
                CC = "1781",
                TTC_TYP_ID = "9903",
                TTC_MOD_ID = "3851",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "Q5 (8R)",
                TypeCar = "2.0 TFSI hybrid quattro",
                BodyType = "Closed Off-Road Vehicle",
                InitialYear = "201106",
                FinalYear = "",
                KV = "155",
                PM = "211",
                CC = "1984",
                TTC_TYP_ID = "11054",
                TTC_MOD_ID = "7534",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "Q5 (8R)",
                TypeCar = "2.0 TDI",
                BodyType = "Closed Off-Road Vehicle",
                InitialYear = "201011",
                FinalYear = "",
                KV = "105",
                PM = "143",
                CC = "1968",
                TTC_TYP_ID = "11060",
                TTC_MOD_ID = "7534",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "Q5 (8R)",
                TypeCar = "2.0 TDI",
                BodyType = "Closed Off-Road Vehicle",
                InitialYear = "201011",
                FinalYear = "",
                KV = "100",
                PM = "136",
                CC = "1968",
                TTC_TYP_ID = "11058",
                TTC_MOD_ID = "7534",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A8 (4H_)",
                TypeCar = "3.0 TDI",
                BodyType = "Saloon",
                InitialYear = "201109",
                FinalYear = "",
                KV = "150",
                PM = "204",
                CC = "2967",
                TTC_TYP_ID = "10441",
                TTC_MOD_ID = "8627",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "Q7 (4L)",
                TypeCar = "3.0 TDI",
                BodyType = "Closed Off-Road Vehicle",
                InitialYear = "201105",
                FinalYear = "",
                KV = "180",
                PM = "245",
                CC = "2967",
                TTC_TYP_ID = "10442",
                TTC_MOD_ID = "5461",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A3 (8L1)",
                TypeCar = "1.8 T quattro",
                BodyType = "Hatchback",
                InitialYear = "199810",
                FinalYear = "200305",
                KV = "132",
                PM = "180",
                CC = "1781",
                TTC_TYP_ID = "10465",
                TTC_MOD_ID = "1557",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });

            models.Add(new CarModel()
            {
                Id = Guid.NewGuid(),
                BrandId = 1,
                Name = "A2 (8Z0)",
                TypeCar = "1.6 FSI",
                BodyType = "Hatchback",
                InitialYear = "200205",
                FinalYear = "200508",
                KV = "81",
                PM = "110",
                CC = "1598",
                TTC_TYP_ID = "16679",
                TTC_MOD_ID = "4382",
                TTC_MFA_ID = "504",
                ENGINES = "504"
            });
            return models;
        }
    }
}
