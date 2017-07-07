using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Razor.TagHelpers;

namespace Chapter4.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {       
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string emailTo = context.AllAttributes["mailTo"].Value.ToString();                        
            output.TagName = "a";
            output.Attributes["href"] = "mailto:" + emailTo;
            output.Content.SetContent("Drop us a mail");            
        }
    }
}
