# ByteDev.Configuration

Provides a collection of classes to help retrieve:

- Config Sections & Settings
- Connection Settings 
- App Settings

## Config Sections & Settings Usage

Example config file:

```
<configSections>
    <section name="Health" requirePermission="false" type="System.Configuration.NameValueSectionHandler,System,Version=1.0.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
</configSections>

<Health>
    <add key="EnableAssessmentOnStart" value="false" />
</Health>
```

Simple usage:

```
var configSectionProvider = new ConfigSectionProvider();

var configSettingsProvider = new ConfigSettingsProvider(configSectionProvider);

var value = configSettingsProvider.GetString("EnableAssessmentOnStart", "Health");
```

It's generally a good/nice idea to wrap the use of ConfigSettingsProvider in your own config provider classes:

```
public class MyConfig
{
	private readonly IConfigSettingsProvider _provider;

	public MyConfig(IConfigSettingsProvider provider)
	{
		_provider = provider;
	}

	public string CustomerServiceUrl
	{
		get { return _provider.GetString("Url", "CustomerService") }
	}
}
```

This will lead to the following stack:

```
(Your Own Config Provider Class)
-> ConfigSettingsProvider 
-> ConfigProvider 
-> System.Configuration.ConfigurationManager
```