using Microsoft.AspNetCore.Mvc;
using System.Net;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.General.Classes;

public class ProductResult : ObjectResult
{
    public ProductResult(HttpStatusCode statusCode, object? value = null) : base(value) => StatusCode = (int)statusCode;
}

