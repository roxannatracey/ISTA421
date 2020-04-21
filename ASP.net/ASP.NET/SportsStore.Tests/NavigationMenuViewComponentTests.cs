using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.Tests
{
    class NavigationMenuViewComponent
    {
        [Fact]
        public void Indicates_Selected_Category()
        {
            // Arrange
            string categoryToSelect = "Apples";
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[] {
            new Product {ProductID = 1, Name = "P1", Category = "Apples"},
            new Product {ProductID = 4, Name = "P2", Category = "Oranges"},
            }).AsQueryable<Product>());
            NavigationMenuViewComponent target =
            new NavigationMenuViewComponent(mock.Object);
          
            target.ViewComponentContext = new ViewComponentContext
            {
                ViewContext = new ViewContext
                {
                    RouteData = new RouteData()
                }
            };
                        target.RouteData.Values["category"] = categoryToSelect;
            // Action
            string result = (string)(target.Invoke() as
            ViewViewComponentResult).ViewData["SelectedCategory"];
            // Assert
            Assert.Equal(categoryToSelect, result);
        }
    }
}
