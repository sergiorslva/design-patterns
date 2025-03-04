using Prototype;

PersonModel personModel = new PersonModel
{
    Id = 1,
    Name = "Philip Sampson",
    Emails = new List<EmailModel>
    {
        new EmailModel {Email = "phi@mail.com"},
        new EmailModel {Email = "phi.sam@mail.com"},
    },
    Addresses = new List<Address>
    {
        new Address
        {
            Street = "Elm Street",
            Number = "1428"
        }
    },
    Active = true
};


Console.WriteLine("Cloning with MemoryStream");
PersonModel personModel2 = personModel.Clone();

Console.WriteLine($"Name Person 1: {personModel.Name}");
Console.WriteLine($"Name Person 2: {personModel2.Name}");

personModel2.Name = "Name changed";

Console.WriteLine($"Name Person 1: {personModel.Name}");
Console.WriteLine($"Name Person 2: {personModel2.Name}");

Console.WriteLine("......................................");

Console.WriteLine("Cloning with Newtonsoft");
PersonModel personModel3 = personModel.DeepClone();

Console.WriteLine($"Name Person 1: {personModel.Name}");
Console.WriteLine($"Name Person 3: {personModel3.Name}");

personModel3.Name = "Name changed";

Console.WriteLine($"Name Person 1: {personModel.Name}");
Console.WriteLine($"Name Person 3: {personModel3.Name}");

Console.ReadKey();
