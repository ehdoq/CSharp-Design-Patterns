﻿using _17_Command.Classes;

StockManager stockManager = new();
BuyStock buyStock = new(stockManager);
SellStock sellStock = new(stockManager);

StockController stockController = new();

stockController.TakeOrder(buyStock);
stockController.TakeOrder(sellStock);
stockController.TakeOrder(buyStock);
stockController.TakeOrder(sellStock);

stockController.PlaceOrders();