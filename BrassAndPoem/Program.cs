

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
We provide the musical notes and tools for you, just bring the talent!
";

    Console.WriteLine(greeting);

//implement your loop here

for (int i = 0; i < products.Count; i++)
{
        Console.WriteLine($@"{i + 1}. {products[i].Name}");
}

//This will be checked off by the while loop until it is false. This is before the user adds an input response.
Product chosenProduct = null;

while (chosenProduct == null)
{
    //While the user hasnt put in an answer, it will display this message and TRY to receive a response from you.
    Console.WriteLine("Please choose a product number!");
    try
    {
        int response = int.Parse(Console.ReadLine().Trim());
        chosenProduct = products[response - 1];
        Console.WriteLine($"You chose {chosenProduct.Name}");
    }
    catch (ArgumentOutOfRangeException)
    {
        //These catch calls will shoot off and then revert back to the TRY call again.
        Console.WriteLine("Try again! Choose a number between 1 and 5!");
    }
    catch (FormatException)
    {
        //These catch calls will shoot off and then revert back to the TRY call again.
        Console.WriteLine("Try again! Choose only an integer type of response.");
    }
}


void DisplayMenu()
    {
    Console.WriteLine(@"
1. Display all products
2. Delete a product
3. Add a new product
4. Update product properties
5. Exit ");
}

    void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
    {
            for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine(@$"{i + 1}. {products[i].Name} for {products[i].Price}");
            //To implement productType, must use Linq method. Research before proceeding.
        }
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