using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace ArkanoTest.App.UiTest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            return ConfigureApp.Android.StartApp();
        }
    }
}