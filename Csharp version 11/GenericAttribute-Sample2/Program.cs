using GenericAttribute_Sample2;

var settings = new ApplicationSettings();
LoadConfiguration(settings);

Console.WriteLine($"Name: {settings.Name}");
Console.WriteLine($"MaxUsers: {settings.MaxUsers}");
Console.WriteLine($"FeatureEnabled: {settings.FeatureEnabled}");

static void LoadConfiguration(object configObject)
{
    // Simulated configuration source
    var configuration = new Dictionary<string, object>
    {
        { "App:Name", "My Application" },
        { "App:MaxUsers", 100 },
        { "App:FeatureEnabled", true }
    };

    // Iterate over all properties of the object
    foreach (var prop in configObject.GetType().GetProperties())
    {
        // Check if the property has a ConfigAttribute, regardless of its generic type
        var attr = prop.GetCustomAttributes(typeof(ConfigAttribute<>), false);
        if (attr.Length > 0)
        {
            var configAttr = attr[0]; // Assuming only one ConfigAttribute per property
            var keyProperty = configAttr.GetType().GetProperty("Key");
            var key = keyProperty.GetValue(configAttr) as string;

            // If the key exists in the configuration, set the property value
            if (key != null && configuration.ContainsKey(key))
            {
                var value = Convert.ChangeType(configuration[key], prop.PropertyType);
                prop.SetValue(configObject, value);
            }
        }
    }
}
