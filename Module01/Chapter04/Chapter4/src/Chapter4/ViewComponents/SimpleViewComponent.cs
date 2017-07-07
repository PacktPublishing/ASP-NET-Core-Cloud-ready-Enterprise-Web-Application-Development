using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace Chapter4.ViewComponents
{
    public class SimpleViewComponent :ViewComponent
    {        
        public IViewComponentResult Invoke()
        {
            var data = GetSampleData();
            return View(data);
        }

        /// <summary>
        /// This is a simple private method to return some dummy data
        /// </summary>
        /// <returns></returns>
        private List<string> GetSampleData()
        {
            List<string> data = new List<string>();
            data.Add("One");
            data.Add("Two");
            data.Add("Three");
            return data;
        }
    }
}
