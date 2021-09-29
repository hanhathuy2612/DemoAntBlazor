using Bunit;
using DemoAntBlazor.Pages;
using DemoAntBlazor.Services;
using Microsoft.AspNetCore.Components;
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
        //[Fact]
        //public void Test()
        //{
        //    using var ctx = new TestContext();

        //    ctx.Services.AddSingleton<IAverageCountService, AverageCountService>();
        //    ctx.RenderTree.Add<CascadingValue<int>>(para => para.Add(p => p.Value, 20));

        //    Action<int> onSomethingHandler = (e) => { e++; };
        //    var cut = ctx.RenderComponent<Counter>(parameters =>
        //        parameters.Add(p => p.CurrentCount, 5)
        //                  .Add(p => p.CurrentCountChanged, onSomethingHandler)
        //    );
        //    var buttonElement = cut.FindAll("button");
        //    buttonElement.FirstOrDefault(x => x.TextContent == "Click me").Click();

        //    //cut.Find("h2").MarkupMatches("<h2>Counter 20</h2>");
        //    //Assert.Equal(20, cut.Instance.CascadingValue);
        //    //Assert.Equal(4, cut.FindComponents<Foo>().Count());

        //    //Assert.NotNull(ctx.Services.GetService<AverageCountService>());

        //    //Assert.NotEmpty(cut.Instance._strings);
        //    //cut.Find("button").Click();

        //    //cut.Find("h2").MarkupMatches("<h2>Counter</h2>");
        //}
    }
}
