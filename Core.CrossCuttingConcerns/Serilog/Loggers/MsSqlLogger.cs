using Core.CrossCuttingConcerns.Serilog.ConfigurationModels;
using Core.CrossCuttingConcerns.Serilog.Messages;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Sinks.MSSqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Serilog.Loggers;

public class MsSqlLogger : LoggerServiceBase
{
    public MsSqlLogger(IConfiguration configuration)
    {
        MsSqlConfiguration logConfig =
             configuration.GetSection("SeriLogConfigurations:MsSqlConfiguration").Get<MsSqlConfiguration>()
             ?? throw new Exception(SerilogMessages.NullOptionsMessage);

        MSSqlServerSinkOptions sinkOptions = new()
        {
            TableName = logConfig.TableName,
            AutoCreateSqlTable = logConfig.AutoCreateSqlTable,
        };

        ColumnOptions columnOptions = new();

        Logger = new LoggerConfiguration().WriteTo
             .MSSqlServer(logConfig.ConnectionString, sinkOptions, columnOptions: columnOptions)
             .CreateLogger();
    }
}
