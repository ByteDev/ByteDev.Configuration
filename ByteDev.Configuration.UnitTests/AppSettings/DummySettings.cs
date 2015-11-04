using ByteDev.Configuration.AppSettings;

namespace ByteDev.Configuration.UnitTests.AppSettings
{
	public class DummySettings : AppSettingsProvider
	{
	    public string NotExistString 
	    {
	        get { return GetString("NotExists.String"); }			
	    }


	    public string ExistsString
		{
			get { return GetString("Exists.String"); }
		}

        public char ExistsChar
        {
            get { return GetChar("Exists.Char"); }
        }

	    public byte ExistsByte
	    {
            get { return GetByte("Exists.Byte"); }
	    }

	    public short ExistsShort
	    {
            get { return GetShort("Exists.Short"); }
	    }

	    public int ExistsInt
		{
			get { return GetInt("Exists.Int"); }
		}

	    public long ExistsLong
		{
			get { return GetLong("Exists.Long"); }
		}

	    public bool ExistsBool
		{
			get { return GetBool("Exists.Bool"); }
		}

	    public float ExistsFloat
		{
			get { return GetFloat("Exists.Float"); }
		}

	    public double ExistsDouble
		{
			get { return GetDouble("Exists.Double"); }
		}

        public decimal ExistsDecimal
		{
			get { return GetDecimal("Exists.Decimal"); }
		}


        public byte ExistsButIsNotChar
        {
            get { return GetByte("Exists.ButIsNotChar"); }
        }

	    public bool ExistsButIsNotBool
	    {
	        get { return GetBool("Exists.ButIsNotBool");  }
	    }

	    public byte ExistsButIsNotByte
	    {
            get { return GetByte("Exists.ButIsNotByte"); }
	    }

	    public short ExistsButisNotShort
	    {
            get { return GetShort("Exists.ButIsNotShort"); }
	    }

	    public int ExistsButIsNotInt
		{
			get { return GetInt("Exists.ButIsNotInt"); }
		}

	    public long ExistsButIsNotLong
	    {
	        get { return GetLong("Exists.ButIsNotLong"); }
	    }

	    public long ExistsButIsNotFloat
	    {
	        get { return GetLong("Exists.ButIsNotFloat"); }
	    }

	    public long ExistsButIsNotDouble
	    {
	        get { return GetLong("Exists.ButIsNotDouble"); }
	    }

	    public long ExistsButIsNotDecimal
	    {
	        get { return GetLong("Exists.ButIsNotDecimal"); }
	    }
	}
}