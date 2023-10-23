// See https://aka.ms/new-console-template for more information
using LazyArtCore.Data;
using LazyArtTest;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;


Console.WriteLine("Hello, World!");



var context = new GenericDbDbContextFactory<A_SHOP_TEST>().CreateDbContext(null);
var repository = new GenericRepository<A_SHOP_TEST>(context);
//var service = new GenericService<MyEntity>(repository);

// 添加实体
repository.Create(new A_SHOP_TEST { ID = Guid.NewGuid(), NAME = "Entity 1" });
repository.Create(new A_SHOP_TEST { ID = Guid.NewGuid(), NAME = "Entity 2" });

// 查询实体
var entities = repository.GetAll();
foreach (var entity in entities)
{
    System.Console.WriteLine($"Id: {entity.ID}, Name: {entity.NAME}");
}