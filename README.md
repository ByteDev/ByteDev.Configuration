# ByteDev.Configuration

A collection of classes to help retrieve settings from App.config files in .NET.

## Installation

ByteDev.Configuration has been written as a .NET Standard 2.0 library, so you can consume it from a .NET Core or .NET Framework 4.6.1 (or greater) application.

ByteDev.Configuration is hosted as a package on nuget.org.  To install from the Package Manager Console in Visual Studio run:

`Install-Package ByteDev.Configuration`

Further details can be found on the [nuget page](https://www.nuget.org/packages/ByteDev.Configuration/).

## Code

The repo can be cloned from git bash:

`git clone https://github.com/ByteDev/ByteDev.Configuration`

## Usage

Functionality is in three main areas:

- Config Sections & Settings
- App Settings
- Connection Settings

### Config Sections & Settings

Example config:

```xml
<configSections>
    <section name="Health" requirePermission="false" type="System.Configuration.NameValueSectionHandler,System,Version=1.0.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
</configSections>

<Health>
    <add key="EnableAssessmentOnStart" value="false" />
</Health>
```

Simple usage:

```c#
var sectionProvider = new ConfigSectionProvider();

var settingsProvider = new ConfigSettingsProvider(sectionProvider);

bool value = settingsProvider.GetBool("EnableAssessment", "Health");
```

For tidiness you can then wrap the use of ConfigSettingsProvider in your own config class:

```c#
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

```c#
MyConfig
-> ConfigSettingsProvider 
--> ConfigProvider 
---> System.Configuration.ConfigurationManager
```

### App Settings

Example config:

```xml
<appSettings>
	<add key="ClientRetries" value="5"/>
</appSettings>
```

Simple usage:

```c#
var provider = new AppSettingsProvider();

int value = provider.GetInt("ClientRetries");
```

### Connection Settings

Example config:

```xml
<connectionStrings>
	<add name="MyDb" connectionString="Data Source=.;Initial Catalog=MyDb;Integrated Security=True" />
</connectionStrings>
```

Simple usage:

```c#
var provider = new ConnectionSettingsProvider();

var connSettings = provider.GetConnectionSettings("MyDb");
```
