using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Exceptions.Extensions;

public static class ExceptionMiddelwareExtensions
{
    public static void ConfigureCustomExceptionMiddelware(this IApplicationBuilder app)
        => app.UseMiddleware<ExceptionMiddelware>();
}
