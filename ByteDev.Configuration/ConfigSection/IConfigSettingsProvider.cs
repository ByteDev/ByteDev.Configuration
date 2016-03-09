using System;

namespace ByteDev.Configuration.ConfigSection
{
    public interface IConfigSettingsProvider
    {
        string GetString(string key, string sectionName);
        string GetString(Enum key, Enum sectionName);

        char GetChar(string key, string sectionName);
        char GetChar(Enum key, Enum sectionName);

        bool GetBool(string key, string sectionName);
        bool GetBool(Enum key, Enum sectionName);

        byte GetByte(string key, string sectionName);
        byte GetByte(Enum key, Enum sectionName);

        short GetShort(string key, string sectionName);
        short GetShort(Enum key, Enum sectionName);

        int GetInt(string key, string sectionName);
        int GetInt(Enum key, Enum sectionName);

        long GetLong(string key, string sectionName);
        long GetLong(Enum key, Enum sectionName);

        float GetFloat(string key, string sectionName);
        float GetFloat(Enum key, Enum sectionName);

        double GetDouble(string key, string sectionName);
        double GetDouble(Enum key, Enum sectionName);

        decimal GetDecimal(string key, string sectionName);
        decimal GetDecimal(Enum key, Enum sectionName);

        Uri GetAbsoluteUri(string key, string sectionName);
        Uri GetAbsoluteUri(Enum key, Enum sectionName);
    }
}