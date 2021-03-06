﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace RazonPagesTutorial.Pages
{
    public class Index2Model : PageModel
    {
        public string Message { get; private set; } = "PageModel in C#";

        public void OnGet()
        {
            Message += $" Server time is {DateTime.Now}";
        }
    }
}