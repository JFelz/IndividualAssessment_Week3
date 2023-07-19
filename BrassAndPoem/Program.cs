
void ViewProductDetails()
{
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



    //put your greeting here

    string greeting = @"Welcome to Brass&Poems!
    We provide the musical notes and tools for you, just bring the talent!";

    //implement your loop here

    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($@"{i + 1}. {products[i]}");
    }

}
    void DisplayMenu()
    {
        throw new NotImplementedException();
    }

    void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
    {
        throw new NotImplementedException();
    }

    void DeleteProduct(List<Product> products, List<ProductType> productTypes)
    {
        throw new NotImplementedException();
    }

    void AddProduct(List<Product> products, List<ProductType> productTypes)
    {
        throw new NotImplementedException();
    }

    void UpdateProduct(List<Product> products, List<ProductType> productTypes)
    {
        throw new NotImplementedException();
    }


// don't move or change this!
public partial class Program { }