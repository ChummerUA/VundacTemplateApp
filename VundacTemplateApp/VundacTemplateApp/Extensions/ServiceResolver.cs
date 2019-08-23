using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Text;

namespace VundacTemplateApp.Extensions
{
    public static class ServiceResolver
    {
        public static TService Get<TService>()
        {
            return (PrismApplicationBase.Current as PrismApplication).Container.Resolve<TService>();
        }
    }
}
