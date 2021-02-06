using GetcuReone.ComboPatterns.Adapter;
using GetcuReone.ComboPatterns.Interfaces;
using System;

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
    }
}
