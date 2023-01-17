using AdressbokVS.Interfaces;
using AdressbokVS.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AdressbokVS.Services;

internal class MenuService
{
    public List<IPerson> persons = new List<IPerson>();
    public readonly FileService fileService = new FileService();

    public string FilePath { get; set; } = null!;
    public void WelcomeMenu()
    {
        Console.Clear();
        Console.WriteLine("ADRESSBOKEN");
        Console.WriteLine("1. Skapa en kontakt ");
        Console.WriteLine("2. Visa alla kontakter ");
        Console.WriteLine("3. Visa en specifik kontakt ");
        Console.WriteLine("4. Ta bort en specifik kontakt ");
        Console.WriteLine("Välj ett alternativ ovan: ");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1": OptionOne(); break;
            case "2": OptionTwo(); break;
            case "3": OptionThree(); break;
            case "4": OptionFour(); break;
        }
    }
    public void OptionOne()
    {
        Console.Clear();
        Console.WriteLine("Add a new contact");
        
        IPerson person = new Person();
        Console.Write("Enter first name: ");
        person.FirstName = Console.ReadLine() ?? "";
        Console.Write("Enter last name: ");
        person.LastName = Console.ReadLine() ?? "";
        Console.Write("Enter e-mail adress: ");
        person.Email = Console.ReadLine() ?? "";
        Console.Write("Enter phone number ");
        person.Number = Console.ReadLine() ?? "";
        Console.Write("Enter adress: ");
        person.Adress = Console.ReadLine() ?? "";

        persons.Add(person);

        fileService.Save(FilePath, JsonConvert.SerializeObject(new { persons }));
    }
    public void OptionTwo()
    {
            try
            {
                var items = JsonConvert.DeserializeObject<List<IPerson>>(fileService.Read(FilePath));
                if (items != null)
                persons = items;
            }
            catch { }

        foreach (IPerson person in persons)
        {
            Console.WriteLine(person.Adress);
        }
    }
    private void OptionThree()
    {

    }
    private void OptionFour()
    {

    }
}
