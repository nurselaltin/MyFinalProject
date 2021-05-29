using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstarct;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependecyResolves.Autofac
{


    //Startup kısmında yaptığımız çözümleme ortamını ayarlıyoruz burada
    public class AutofacBusinessModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
           
            builder.RegisterType<ProductManager>().As<IProductService>(); //Karşılığı :   services.AddSingleton<IProductService,ProductManager>();
            //Birisi senden IProductDal istediğinde EfProductDal new();
            builder.RegisterType<EfProductDal>().As<IProductDal>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }



    }
    
}
