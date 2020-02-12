using System;

namespace ByteDev.Configuration.ConfigSection
{
    /// <summary>
    /// Represents a interface for retrieving values from a config section.
    /// </summary>
    public interface IConfigSettingsProvider
    {
        /// <summary>
        /// Retrieves a string value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        string GetString(string key, string sectionName);

        /// <summary>
        /// Retrieves a char value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        char GetChar(string key, string sectionName);

        /// <summary>
        /// Retrieves a bool value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        bool GetBool(string key, string sectionName);

        /// <summary>
        /// Retrieves a byte value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        byte GetByte(string key, string sectionName);

        /// <summary>
        /// Retrieves a short value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        short GetShort(string key, string sectionName);

        /// <summary>
        /// Retrieves a int value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        int GetInt(string key, string sectionName);

        /// <summary>
        /// Retrieves a long value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        long GetLong(string key, string sectionName);

        /// <summary>
        /// Retrieves a float value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        float GetFloat(string key, string sectionName);

        /// <summary>
        /// Retrieves a double value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        double GetDouble(string key, string sectionName);

        /// <summary>
        /// Retrieves a decimal value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        decimal GetDecimal(string key, string sectionName);

        /// <summary>
        /// Retrieves a Uri value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        Uri GetUri(string key, string sectionName);

        /// <summary>
        /// Retrieves a Guid value.
        /// </summary>
        /// <param name="key">Key to retrieve the value.</param>
        /// <param name="sectionName">Section name to retrieve the value from.</param>
        /// <returns>Config value for the <paramref name="key" />.</returns>
        Guid GetGuid(string key, string sectionName);
    }
}