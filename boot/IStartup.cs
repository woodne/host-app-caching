using System;
using Unity;

namespace boot
{
    public interface IMyStartup
    {
        void InitializeContainer(IUnityContainer container);
    }
}