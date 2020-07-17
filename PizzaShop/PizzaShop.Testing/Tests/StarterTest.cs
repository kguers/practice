using System;
using PizzaShop.Client;
using PizzaShop.Domain.Models;
using Xunit;

namespace PizzaShop.Testing.Tests
{
     public class StarterTest
     {
          [Fact]
          public void Test_CreateOrder()
          {
               var user = new User();
               var store = new Store();
               var sut = new Starter();

               var actual = sut.CreateOrder(user,store);

               Assert.NotNull(actual);
          }
     }
}