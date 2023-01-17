using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace API.General.Classes;

public class ProductResult : ObjectResult
{
    public ProductResult(HttpStatusCode statusCode, object? value = null) : base(value) => StatusCode = (int)statusCode;
}

