using boot;
using Unity;

namespace classlib
{
    public class ClassLibStartup : IMyStartup 
    {
        public void InitializeContainer(IUnityContainer container)
        {
            container.RegisterType<IMyInterface, MyClass>();
        }
    }
}