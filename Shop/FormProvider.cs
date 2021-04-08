using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class FormProvider
    {
        public static MainPage MainPageForm
        {
            get
            {
                if (mainPage == null)
                {
                    mainPage = new MainPage();
                }
                return mainPage;
            }
        }
        private static MainPage mainPage;
    }
}
