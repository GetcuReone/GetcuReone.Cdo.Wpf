using GetcuReone.Cdi;
using GetcuReone.Cdo.File;
using GetcuReone.Cdo.Helpers;
using GetcuReone.ComboPatterns.Adapter;
using GetcuReone.ComboPatterns.Interfaces;
using GetcuReone.GetcuTestAdapter.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace GetcuReone.Cdo.WpfTests.Env
{
    public abstract class UiTestBase : MvvmFrame.Wpf.TestAdapter.UiTestBase, IAdapterCreation, IAbstractFactory
    {
        public TObj CreateObject<TParameter, TObj>(Func<TParameter, TObj> factoryFunc, TParameter parameters)
        {
            return factoryFunc(parameters);
        }

        public TAdapter GetAdapter<TAdapter>() where TAdapter : IAdapter, new()
        {
            return AdapterBase.Create<TAdapter>(this);
        }

        [TestInitialize]
        public virtual void Initialize()
        {
            using (var fileStream = GetAdapter<FileAdapter>().OpenRead(@"Env\config.xml"))
            {
                var configValue = fileStream.DeserializeFromXml<List<ConfigValue>>();
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = config.AppSettings.Settings;

                foreach (var value in configValue)
                {
                    if (!settings.AllKeys.IsNullOrEmpty() && settings.AllKeys.Any(key => key.EqualsOrdinal(value.Key)))
                        settings.Remove(value.Key);

                    settings.Add(value.Key, value.Value);
                }

                config.Save(ConfigurationSaveMode.Modified);
            }
        }
    }
}
