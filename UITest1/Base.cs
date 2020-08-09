using System;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Tests
{
    class Base
    {
        public IApp app;

        public Base(IApp app)
        {
            this.app = app;
        }

        public void Tap(Query element)
        {
            app.Tap(element);
        }

        public void Equals(Query element)
        {
            app.Equals(element);
        }
        public void WaitForElement(Query element)
        {
            app.WaitForElement(element);
        }
        public void EnterText(Query element, String text)
        {
            app.EnterText(element, text);
        }

        public void ClearText(Query element)
        {
            app.ClearText(element);
        }

        public void ScrollDownTo(String element, String textElement)
        {
            app.ScrollDownTo(x => x.Text(textElement), x => x.Marked(element));
        }

        public Xamarin.UITest.Queries.AppResult[] Query(Query element)
        {
            return app.Query(element);
        }

    }

}
