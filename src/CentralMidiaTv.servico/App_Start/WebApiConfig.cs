﻿using CentralMidiaTv.Aplicacao._2_Data.Ioc;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;

namespace CentralMidiaTv.servico
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(SimpleInjectContainer.RegistrarIoc());
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            // Web API routes
            config.MapHttpAttributeRoutes();
        }
    }
}
