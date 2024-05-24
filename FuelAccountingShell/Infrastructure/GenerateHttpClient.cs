using System;
using System.Net.Http;

namespace FuelAccountingShell.Infrastructure
{
    public class GenerateHttpClient
    {
        public HttpClient GetHttpClient => new HttpClient() { BaseAddress = new Uri("https://localhost:7196") };
    }
}
