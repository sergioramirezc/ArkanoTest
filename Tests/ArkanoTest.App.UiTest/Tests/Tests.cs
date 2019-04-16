using System;
using System.IO;
using System.Linq;
using ArkanoTest.App.UiTest.Pages;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace ArkanoTest.App.UiTest.UITests
{
    public class Tests : BaseTestFixture
    {
        public Tests(Platform platform)
            : base(platform)
        {
        }

        [Test]
        public void CheckRamDetail()
        {
            new RamListPage()
                    .LoadItems()
                    .SelectItem();
            new RamDetailPage()
                    .LoadDetail();
        }
    }
}