using _04_Builder.Builder;

ProductDirector pD = new();

var newProductBuilder = new NewCustomerProductBuilder();
var oldProductBuilder = new OldCustomerProductBuilder();

pD.GenerateProduct(newProductBuilder);
pD.GenerateProduct(oldProductBuilder);

var newCustomerProduct = newProductBuilder.GetProduct();
var oldProductProduct = oldProductBuilder.GetProduct();

Console.WriteLine($"{newCustomerProduct.ProductId}-{newCustomerProduct.CategoryName}-{newCustomerProduct.ProductName}-{newCustomerProduct.UnitPrice}-{newCustomerProduct.DiscountedPrice}-{newCustomerProduct.DiscountApplied}");
Console.WriteLine($"{oldProductProduct.ProductId}-{oldProductProduct.CategoryName}-{oldProductProduct.ProductName}-{oldProductProduct.UnitPrice}-{oldProductProduct.DiscountedPrice}-{oldProductProduct.DiscountApplied}");