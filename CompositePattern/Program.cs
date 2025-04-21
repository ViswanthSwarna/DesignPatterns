

using CompositePattern.Classes;
using CompositePattern.Interfaces;


List<IItem> productItems = new List<IItem>();
productItems.Add(new Product(5));
productItems.Add(new Box(5,null));

IItem item = new Box(10, 
    new List<IItem>(
        [ new Box(10,productItems),  new Box(10,productItems)])
    );

Console.WriteLine(item.calculate());