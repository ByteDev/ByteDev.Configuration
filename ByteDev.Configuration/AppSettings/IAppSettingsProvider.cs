using System;

namespace ByteDev.Configuration.AppSettings
{
    public interface IAppSettingsProvider
    {
        string GetString(string key);
        bool GetBool(string key);
        byte GetByte(string key);
        int GetInt(string key);
        long GetLong(string key);
        short GetShort(string key);
        float GetFloat(string key);
        double GetDouble(string key);
        decimal GetDecimal(string key);
        Uri GetAbsoluteUri(string key);
    }
}