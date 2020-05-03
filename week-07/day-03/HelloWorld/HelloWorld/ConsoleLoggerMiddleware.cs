using HelloWorld.Interfaces;
using HelloWorld.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class ConsoleLoggerMiddleware : IMiddleware
    {
        public Printer printer;
        //public IColor color;
        /*public ConsoleLoggerMiddleware(Printer printer)
        {
            this.printer = printer;
        }*/

        public ConsoleLoggerMiddleware(Printer printer)
        {
            this.printer = printer;
           // this.color = color;
        }
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            printer.Log("Hi from the middleware");
            //color.PrintColor();
            return next(context);
        }
    }
}