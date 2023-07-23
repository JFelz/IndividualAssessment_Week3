

//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.

List<Product> products = new List<Product>()
    {
    new Product()
    {
        Name = "The Road Not Taken",
        Price = 9.99M,
        ProductTypeId = 1,
    },
    new Product()
    {
        Name = "And Still I Rise",
        Price = 5.99M,
        ProductTypeId = 1,
    },
    new Product()
    {
        Name = "Trombone",
        Price = 199.99M,
        ProductTypeId = 2,
    },
    new Product()
    {
        Name = "Trumpet",
        Price = 99.99M,
        ProductTypeId = 2,
    },
    new Product()
    {
        Name = "The Raven",
        Price = 4.99M,
        ProductTypeId = 1,
    }
};


    //create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 

    List<ProductType> prodType = new List<ProductType>()
    {
        new ProductType()
        {
            Title = "Poem",
            Id = 1
        },
        new ProductType()
        {
            Title = "Brass",
            Id = 2
        }
    };

    string greeting = @"Welcome to Brass&Poems!
We provide the musical notes and tools for you, just bring the talent!
";

    Console.WriteLine(greeting);

    DisplayMenu();
    int response = int.Parse(Console.ReadLine().Trim());


void DisplayMenu()
{
    Console.WriteLine(@"
1. Display all products
2. Delete a product
3. Add a new product
4. Update product properties
5. Exit ");
}


while (response < 5)
{
    if (response == 1)
    {
        DisplayAllProducts(products, prodType);
        response = 0;
    }
    else if (response == 2)
    {
        DeleteProduct(products, prodType);
        response = 0;
    }
    else if (response == 3)
    {
        AddProduct(products, prodType);
        response = 0;
    }
    else if (response == 4)
    {
        UpdateProduct(products, prodType);
        response = 0;
    }
}

    void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
    {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(@$"{i + 1}. {products[i].Name} for {products[i].Price}, ProductTypeID: {products[i].ProductTypeId}");
                //To implement productType, must use Linq method. Research before proceeding.
            }
        
    }

    void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
 
        for (int i = 0; i < products.Count; i++)
        {
           Console.WriteLine(@$"{i + 1}. {products[i].Name} for {products[i].Price}");
        }
        Console.WriteLine("Please Delete a Product: ");
         int deleteProduct = int.Parse(Console.ReadLine().Trim());
        var Finished = products.Remove(products[deleteProduct - 1]);
        DisplayAllProducts(products, prodType);
}

    void AddProduct(List<Product> products, List<ProductType> productTypes)
    {

            Console.WriteLine("Enter a product name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            decimal Price = decimal.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Enter ProductID Type (1 or 2): ");
            int pID = int.Parse(Console.ReadLine().Trim());
            int newPID = 0;
            if (pID == 1 || pID == 2) 
            {
                newPID = pID;
            } else Console.WriteLine("Wrong Input!");
            
            products.Add(new Product { Name = Name, Price = Price, ProductTypeId = newPID });

    DisplayAllProducts(products, prodType);
    }

    void UpdateProduct(List<Product> products, List<ProductType> productTypes)
    {
        //Displays menu and lets user choose which Product to update
        Console.WriteLine("Choose the number of which product to Update!");
        DisplayAllProducts(products, prodType);
        int indexUpdate = int.Parse(Console.ReadLine().Trim());
    if (indexUpdate > 0)
    {
        // Loop through the array to find all the products indexes and then match that indexed object to the response.
        // Check if the expression is true

        Product productUpdate = products[indexUpdate - 1];
        Console.WriteLine($"Enter the new name for {productUpdate.Name}");
        string nameUpdated = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(nameUpdated))
        {
            productUpdate.Name = nameUpdated;
        }
        Console.WriteLine($"Enter the new price range for {productUpdate.Name}");
        decimal priceUpdated = decimal.Parse(Console.ReadLine().Trim());
        if (priceUpdated > 0)
        {
            productUpdate.Price = priceUpdated;
        }
        Console.WriteLine($"Enter the new productID for {productUpdate.Name}");
        int updatedID = int.Parse(Console.ReadLine().Trim());
        if (updatedID == 1 || updatedID == 2) 
        {
            productUpdate.ProductTypeId = updatedID;
        }
        Console.WriteLine(@"Product updated successfully!
        ");
        DisplayAllProducts(products, productTypes);
    } else 
    {
        Console.WriteLine("Please enter a valid index!");
    }

    // If expression is true: Give option to update name and price

    //Change the parameters of that object and push back to Array. Dont use a LINQ method that doesnt change the original array.








}


// don't move or change this!
public partial class Program { }