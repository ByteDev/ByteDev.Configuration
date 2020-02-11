using System;
using ByteDev.Configuration.AppSettings;

namespace ByteDev.Configuration.UnitTests.AppSettings
{
	public class DummySettings : AppSettingsProvider
	{
	    public string NotExistString => GetString("NotExists.String");


        public string ExistsString => GetString("Exists.String");

        public char ExistsChar => GetChar("Exists.Char");

        public byte ExistsByte => GetByte("Exists.Byte");

        public short ExistsShort => GetShort("Exists.Short");

        public int ExistsInt => GetInt("Exists.Int");

        public long ExistsLong => GetLong("Exists.Long");

        public bool ExistsBool => GetBool("Exists.Bool");

        public float ExistsFloat => GetFloat("Exists.Float");

        public double ExistsDouble => GetDouble("Exists.Double");

        public decimal ExistsDecimal => GetDecimal("Exists.Decimal");

        public Uri ExistsAbsoluteUri => GetAbsoluteUri("Exists.AbsoluteUri");

        public Guid ExistsGuid => GetGuid("Exists.Guid");


        public byte ExistsButIsNotChar => GetByte("Exists.ButIsNotChar");

        public bool ExistsButIsNotBool => GetBool("Exists.ButIsNotBool");

        public byte ExistsButIsNotByte => GetByte("Exists.ButIsNotByte");

        public short ExistsButisNotShort => GetShort("Exists.ButIsNotShort");

        public int ExistsButIsNotInt => GetInt("Exists.ButIsNotInt");

        public long ExistsButIsNotLong => GetLong("Exists.ButIsNotLong");

        public long ExistsButIsNotFloat => GetLong("Exists.ButIsNotFloat");

        public long ExistsButIsNotDouble => GetLong("Exists.ButIsNotDouble");

        public decimal ExistsButIsNotDecimal => GetDecimal("Exists.ButIsNotDecimal");

        public Uri ExistsButIsNotAbsoluteUri => GetAbsoluteUri("Exists.ButIsNotAbsoluteUri");

        public Guid ExistsButIsNotGuid => GetGuid("Exists.ButIsNotGuid");
    }
}