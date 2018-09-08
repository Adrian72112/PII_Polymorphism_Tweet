//--------------------------------------------------------------------------------
// <copyright file="TweetPrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------
using System;
using System.IO;

namespace Polymorphism
{
    public class TweetPrinter : IPrinter
    {
        public void PrintTicket(Sale sale)
        {
            TwitterApi api = new TwitterApi("dtOgpyjBBXglAzMEjMMZtFf73","Qzm0FxotJ9YyoXiGLJ4JI9IZFWmYvB4LWpteWPGVYofxSG4FnN",
            "13uONd7FgFVXhW1xhUCQshKgGv4UOnKeDipg4cz", "HXtlP1SRnJCL5a37R98hFrIRlEIouZX3Ra4s6JuFOpXZF");
            api.Tweet(sale.GetTextToPrint());
        }
    }
}