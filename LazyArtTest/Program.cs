// See https://aka.ms/new-console-template for more information
using LazyArtCore.Data;
using LazyArtTest;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;


Console.WriteLine("Hello, World!");



var context = new GenericDbDbContextFactory<ShopTest>().CreateDbContext(null);
var repository = new GenericRepository<ShopTest>(context);
//var service = new GenericService<MyEntity>(repository);

// 添加实体
repository.Create(new ShopTest { Id = Guid.NewGuid(), Name = "Entity 1" });
repository.Create(new ShopTest { Id = Guid.NewGuid(), Name = "Entity 2" });

// 查询实体
var entities = repository.Finds();
foreach (var entity in entities)
{
    System.Console.WriteLine($"Id: {entity.Id}, Name: {entity.Name}");
}

