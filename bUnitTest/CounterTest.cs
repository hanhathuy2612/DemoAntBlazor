using Bunit;
using DemoAntBlazor.Pages;
using DemoAntBlazor.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace bUnitTest
{
    public class CounterTest
    {
        [Fact]
        public void Test()
        {
            using var ctx = new TestContext();

            Action<int> onSomethingHandler = (e) => { e++; };
            var cut = ctx.RenderComponent<Counter>(parameters =>
                parameters.Add(p => p.CurrentCount, 5)
                          .Add(p => p.CurrentCountChanged, onSomethingHandler)
            );
            Assert.NotNull(cut.Instance._strings);
            //cut.Find("button").Click();

            //cut.Find("h1").MarkupMatches("<h1>Counter</h1>");
        }
    }
}
