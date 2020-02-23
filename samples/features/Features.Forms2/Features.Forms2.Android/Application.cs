﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Android.App;
using Android.Runtime;
using Caliburn.Micro;
using Features.Forms2.ViewModels;

namespace Features.Forms2.Droid
{
    [Application]
    public class Application : CaliburnApplication
    {
        private SimpleContainer _container;

        public Application(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {

        }

        public override void OnCreate()
        {
            base.OnCreate();

            Initialize();
        }

        protected override void Configure()
        {
            _container = new SimpleContainer();
            _container.Instance(_container);
            _container.Singleton<App>();
        }

        protected override IEnumerable<Assembly> SelectAssemblies()
        {
            return new[]
            {
                GetType().Assembly,
                typeof(HomeViewModel).Assembly
            };
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }
    }
}
