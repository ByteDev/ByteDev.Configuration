using System;

namespace ByteDev.Configuration.AppSettings
{
    /// <summary>
    /// Represents an interface of a provider for the appSettings section in config.
    /// </summary>
    public interface IAppSettingsProvider
    {
        /// <summary>
        /// Retrieve an app setting string value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        string GetString(string key);

        /// <summary>
        /// Retrieve an app setting bool value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        bool GetBool(string key);

        /// <summary>
        /// Retrieve an app setting byte value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        byte GetByte(string key);

        /// <summary>
        /// Retrieve an app setting int value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        int GetInt(string key);

        /// <summary>
        /// Retrieve an app setting long value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        long GetLong(string key);

        /// <summary>
        /// Retrieve an app setting short value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        short GetShort(string key);

        /// <summary>
        /// Retrieve an app setting float value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        float GetFloat(string key);

        /// <summary>
        /// Retrieve an app setting double value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        double GetDouble(string key);

        /// <summary>
        /// Retrieve an app setting decimal value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        decimal GetDecimal(string key);

        /// <summary>
        /// Retrieve an app setting Uri value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        Uri GetUri(string key);

        /// <summary>
        /// Retrieve an app setting Guid value from config.
        /// </summary>
        /// <param name="key">Key to use when retrieving the value.</param>
        /// <returns>App setting value.</returns>
        Guid GetGuid(string key);
    }
}