# ByteDev.Configuration

A collection of classes to help retrieve settings from App.config files in .NET.

## Usage

Functionality is in three main areas:

- Config Sections & Settings
- App Settings
- Connection Settings

### Config Sections & Settings

Example config:

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
var sectionProvider = new ConfigSectionProvider();

var settingsProvider = new ConfigSettingsProvider(sectionProvider);

bool value = settingsProvider.GetBool("EnableAssessment", "Health");
```

For tidiness you can then wrap the use of ConfigSettingsProvider in your own config class:

```
public class MyConfig
{
	private readonly IConfigSettingsProvider _provider;

	public MyConfig(IConfigSettingsProvider provider)
	{
		_provider = provider;
	}

	public bool EnableAssessment
	{
		get { return _provider.GetBool("EnableAssessment", "Health") }
	}
}
```

This will lead to the following stack:

```
MyConfig
-> ConfigSettingsProvider 
--> ConfigProvider 
---> System.Configuration.ConfigurationManager
```

### App Settings

Example config:

```
<appSettings>
	<add key="ClientRetries" value="5"/>
</appSettings>
```

Simple usage:

```
var provider = new AppSettingsProvider();

int value = provider.GetInt("ClientRetries");
```

### Connection Settings

Example config:

```
<connectionStrings>
	<add name="MyDb" connectionString="Data Source=.;Initial Catalog=MyDb;Integrated Security=True" />
</connectionStrings>
```

Simple usage:

```
var provider = new ConnectionSettingsProvider();

var connSettings = provider.GetConnectionSettings("MyDb");
```
