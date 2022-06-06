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
            ContentSerializer = Serializer { get; set; }
        public string TablePrefix { get; set; }
        public int CommandsPageSize { get; set; }
        public bool QueryGatingEnabled { get; set; }
        public IIdGenerator IdGenerator { get; set; }
        public ILogger Logger { get; set; }
        public HashSet<Type> ConcurrentTypes { get; }
        public ITableNameConvention TableNameConvention { get; set; }
        public ICommandInterpreter CommandInterpreter { get; set; }
        public ISqlDialect SqlDialect { get; set; }
    }
}
