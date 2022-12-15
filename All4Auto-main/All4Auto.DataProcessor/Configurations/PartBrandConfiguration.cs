namespace All4Auto.DataProcessor.Configurations
{
    using All4Auto.DataProcessor.Models.Vehicles;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;

    /// <summary>
    /// Import Parts Brands
    /// </summary>
    public class PartBrandConfiguration : IEntityTypeConfiguration<PartBrand>
    {
        public void Configure(EntityTypeBuilder<PartBrand> builder)
            => builder.HasData(ImportPartBrands());

        private List<PartBrand> ImportPartBrands()
        {
            var brands = new List<PartBrand>();

            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "1A FIRST AUTOMOTIVE", SupId = 11653, BrandId = 11653 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "3F QUALITY", SupId = 10008, BrandId = 10008 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "3K", SupId = 10439, BrandId = 10439 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "555", SupId = 0, BrandId = 10024 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "A.B.S.", SupId = 442, BrandId = 442 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "ABE", SupId = 11005, BrandId = 11005 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "AC", SupId = 0, BrandId = 666 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "ACDelco", SupId = 0, BrandId = 10001 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "BERU / NITION", SupId = 0, BrandId = 11163 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "BF GOODRICH TIRES", SupId = 0, BrandId = 455 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "BGA", SupId = 10911, BrandId = 10911 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "BILSTEIN", SupId = 0, BrandId = 10561 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "COOPERSFIAAM FILTERS", SupId = 10767, BrandId = 10767 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "CORSA", SupId = 0, BrandId = 10126 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "CORTECO", SupId = 148, BrandId = 148 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "CRAFT BEARINGS", SupId = 0, BrandId = 11220 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "CRE", SupId = 0, BrandId = 10520 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "CTR", SupId = 0, BrandId = 1352 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "CUMMINS", SupId = 0, BrandId = 758 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "D&D", SupId = 0, BrandId = 11129 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "DA SILVA", SupId = 10447, BrandId = 10447 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "DAF", SupId = 0, BrandId = 516 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "DAIKIN", SupId = 0, BrandId = 10595 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "FEBEST", SupId = 0, BrandId = 11360 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "FEBI BILSTEIN", SupId = 101, BrandId = 101 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "FEDERAL", SupId = 0, BrandId = 610 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "FERODO", SupId = 62, BrandId = 62 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "FERODO", SupId = 0, BrandId = 11287 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "HERTH+BUSS ELPARTS", SupId = 72, BrandId = 72 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "HERTH+BUSS HEAVYPART", SupId = 0, BrandId = 10088 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "HERTH+BUSS JAKOPARTS", SupId = 55, BrandId = 55 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "HITEC", SupId = 0, BrandId = 10934 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "HK", SupId = 0, BrandId = 17 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "HKT", SupId = 0, BrandId = 11487 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "HOBBYCAR", SupId = 0, BrandId = 1208 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "HOES", SupId = 0, BrandId = 988 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "HOFFER", SupId = 10544, BrandId = 10544 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "HOFMANN", SupId = 0, BrandId = 11620 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "HOLA", SupId = 11527, BrandId = 11527 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "HOLDEN", SupId = 0, BrandId = 836 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "HOLMAN", SupId = 0, BrandId = 989 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "KRIEGER FAHRZEUGBAU", SupId = 0, BrandId = 242 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "KUMHO TIRES", SupId = 0, BrandId = 464 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "KV INTERNATIONAL", SupId = 0, BrandId = 11033 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "KVERNELAND", SupId = 0, BrandId = 10117 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "KW", SupId = 0, BrandId = 440 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "KW", SupId = 0, BrandId = 11183 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "KWP", SupId = 830, BrandId = 830 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "KYB", SupId = 85, BrandId = 85 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "KYB-CN", SupId = 11528, BrandId = 11528 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "KYMCO", SupId = 0, BrandId = 10122 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "LANGENDORF", SupId = 0, BrandId = 275 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "LANSING BAGNALL", SupId = 0, BrandId = 1105 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "MITAS", SupId = 0, BrandId = 471 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "MITSUBA", SupId = 0, BrandId = 803 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "MK Kashiyama", SupId = 0, BrandId = 10022 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "MOBIL", SupId = 11018, BrandId = 11018 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "MOBILETRON", SupId = 11391, BrandId = 11391 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "MOL", SupId = 0, BrandId = 930 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "MONOFLEX", SupId = 10755, BrandId = 10755 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "MONROE", SupId = 37, BrandId = 37 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "MOOG", SupId = 134, BrandId = 134 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "MOPAR PARTS", SupId = 0, BrandId = 206 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "MOTIP", SupId = 1346, BrandId = 1346 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "MOTORAD", SupId = 10706, BrandId = 10706 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "MOTORAD", SupId = 0, BrandId = 10736 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "MOTORCRAFT", SupId = 0, BrandId = 673 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "SKF China", SupId = 0, BrandId = 11398 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "SKT", SupId = 0, BrandId = 10493 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "SKT", SupId = 0, BrandId = 10984 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "SMART", SupId = 0, BrandId = 1149 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "SMB", SupId = 0, BrandId = 173 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "SNR", SupId = 110, BrandId = 110 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "SOLARIS", SupId = 0, BrandId = 10433 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "SOLID AUTO (UK)", SupId = 0, BrandId = 10700 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "SOLIS", SupId = 0, BrandId = 11323 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "SOLO", SupId = 0, BrandId = 723 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "SPAHN GLUHLAMPEN", SupId = 305, BrandId = 305 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "SPECTRE", SupId = 0, BrandId = 1257 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "SPERRY NEW HOLLAND", SupId = 0, BrandId = 1112 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "SPIERINGS KRANEN", SupId = 0, BrandId = 890 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "SPYKER", SupId = 0, BrandId = 10258 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "SRT", SupId = 0, BrandId = 11507 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "VIBERTI", SupId = 0, BrandId = 289 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "VIC", SupId = 0, BrandId = 408 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "VICTOR", SupId = 0, BrandId = 11276 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "VIGNAL SYSTEMS", SupId = 0, BrandId = 10553 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "VIKING", SupId = 0, BrandId = 452 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "VILLAR", SupId = 10382, BrandId = 10382 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "WABCO", SupId = 22, BrandId = 22 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "WAECO", SupId = 97, BrandId = 97 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "WAGNER", SupId = 11095, BrandId = 11095 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "WAGNER LOCKHEED", SupId = 0, BrandId = 1338 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "WAHL", SupId = 0, BrandId = 234 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "WAHLER", SupId = 79, BrandId = 79 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "WAHLER Brazil", SupId = 0, BrandId = 11400 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "WAIglobal", SupId = 11264, BrandId = 11264 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "WALBRO", SupId = 0, BrandId = 10255 });
            brands.Add(new PartBrand() { Id = Guid.NewGuid(), Brand = "WALKER", SupId = 13, BrandId = 13 });

            return brands;
        }
    }
}
