﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationVente.TagHelpers
{
    public class EmailTagHelper :TagHelper
    {
        public string Adresse { get; set; }
        public  string  Content{ get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailTo" + Adresse);
            output.Content.SetContent(Content);

        
        }

    }
}
