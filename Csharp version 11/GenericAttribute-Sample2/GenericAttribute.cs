using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAttribute_Sample2
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ConfigAttribute<T> : Attribute
    {
        public string Key { get; }

        public ConfigAttribute(string key)
        {
            Key = key;
        }
    }

    class ApplicationSettings
    {
        [Config<string>("App:Name")]
        public string Name { get; set; }

        [Config<int>("App:MaxUsers")]
        public int MaxUsers { get; set; }

        [Config<bool>("App:FeatureEnabled")]
        public bool FeatureEnabled { get; set; }
    }

}
