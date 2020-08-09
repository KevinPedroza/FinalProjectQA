using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Tests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            return ConfigureApp.Android.EnableLocalScreenshots().ApkFile("C:/Users/kevin/source/repos/UITest3/UITest3/obj/trello.apk").StartApp(); 
            
        }
    }
}