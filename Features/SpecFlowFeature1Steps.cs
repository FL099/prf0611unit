using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace XUnitTestProject1.Features
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private string inp = "";
        private int outp;

        [Given(@"the input is (.*)")]
        public void GivenTheInputIs(string p0)
        {
            inp = p0;
        }

        [When(@"the input is converted from (.*)")]
        public void WhenTheInputIsConvertedFrom(int p0)
        {
            outp = System.Convert.ToInt32(inp, p0);
        }


        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.Equals(p0, outp);
        }
    }
}
