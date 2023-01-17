# Nugget Documentation🤞✌
 A class library can be used as a NuGet package. NuGet is a package manager for the .NET platform that allows developers to easily share and reuse code in the form of packages. A NuGet package is a ZIP file that contains a set of assemblies, along with metadata that describes the package and its contents.
 Here, I have created a simple bank nugget package that allows for deposit, withdrawal and get balance by users.Feel free to explore🎗🤞🤷‍♀️

## How We arrived at this Nugget package👌

To create a NuGet package from a class library, you will need to use a tool such as the NuGet Package Explorer or the NuGet Command Line tool. These tools will allow you to create a package from your class library, including the DLL file and any other assets that you want to include in the package.

Once you have created the NuGet package, you can then distribute it to other developers or make it available on NuGet.org, where it can be easily discovered and installed by other developers.

It's worth noting that NuGet package can also include other files, like documentation, examples, and scripts. It can be used to distribute not only class libraries but also other types of assets such as tools, frameworks, and assets.

In summary, class libraries can be easily converted into a NuGet package and shared with other developers, allowing them to easily reuse your code and functionality in their own projects.


To create a NuGet package from this class library, you will first need to install the NuGet Package Explorer or the NuGet Command Line tool, depending on your preference.

Once you have the tool installed, you can use it to create a new NuGet package from your class library. For example, using the NuGet Package Explorer, you can do the following steps:

* Open NuGet Package Explorer and click on the "Create a new package" button.

* Fill in the package metadata, such as the package name, version, and description.

* Drag and drop the DLL file of your class library (MyLibrary.dll) into the "lib" folder.

* Optionally, you can add other files, such as documentation and examples, to the package.

* Save the package by clicking on the "Save" button.


Once the package is saved, you can distribute it to other developers or make it available on NuGet.org, where it can be easily discovered and installed by other developers.

Alternatively, you can use the NuGet Command Line tool, where you can create a nuspec file that describes the package, and use the command nuget pack MyLibrary.csproj to create the package, and then use the command nuget push MyLibrary.1.0.0.nupkg -Source https://www.nuget.org/api/v2/package to push it to the nuget gallery.

Keep in mind that creating a NuGet package requires that you have a valid API key, and if you plan to distribute it to nuget.org, you need to have an account in the nuget.org website.

Once the package is created it can be easily installed and used by other developers in their projects by searching for it on nuget.org or by installing it from a local folder or a local nuget server

Here's an example of how the NuGet package that you created from your class library can be used in a client application:


## Installation of the BankNugget
Open your .NET CLI and enter

```C#
      dotnet add package BankNuggets --version 1.0.0
```


## Sample Usage in a Client Application🔥👓
In your client application, open the solution in Visual Studio and go to the "Manage NuGet Packages" option.

Search for the package on nuget.org by its name (BankNuggets) and click on "install" button to install it to the client application.

Once the package is installed, you can start using the classes, interfaces, and other types that it contains in your client application.

```c#
class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("123456", 1000);

        // deposit 500 into account
        account.Deposit(500);

        // withdraw 200 from account
        account.Withdraw(200);

        // get current balance
        Console.WriteLine("Current balance: " + account.GetBalance());

        Console.ReadLine();
    }
}

```

## Conclusion🤷‍♀️
In this example, the client application is able to use the BankAccount class from the MyLibrary package, as well as the other classes, interfaces and types that the package contains, by adding the package to the project and referencing it in the code.

You can also use the class library's methods and properties without creating an instance of the class, by making the class static and invoking methods and properties directly on the class.

It's worth noting that if the package was created with dependencies, then those dependencies should be installed as well, and the package will not be installed if the dependencies are not met.


