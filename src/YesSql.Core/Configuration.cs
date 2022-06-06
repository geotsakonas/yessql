using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Data;
using YesSql.Data;
using YesSql.Serialization;
using YesSql.Services;

namespace YesSql
{
    public class Configuration : IConfiguration
    {
        public Configuration()
        {
            IdentifierAccessorFactory = new PropertyAccessorFactory("Id");
            VersionAccessorFactory = new PropertyAccessorFactory("Version");
            ContentSeriali{ get; set; }
        public HashSet<Type> ConcurrentTypes { get; }
        public ITableNameConvention TableNameConvention { get; set; }
        public ICommandInterpreter CommandInterpreter { get; set; }
        public ISqlDialect SqlDialect { get; set; }
    }
}
