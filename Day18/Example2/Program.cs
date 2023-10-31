using Example2.Data;
using Example2.Entities;

namespace Example2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What do youo want to do?");
        GetInstitutions();
    }

    private static void CreateInstitution()
    {

        Institution institution = new Institution();
        Console.WriteLine("Please provide institution's name");

        institution.Name = Console.ReadLine();
        Console.WriteLine("Please provide institution's country");
        institution.Country = Console.ReadLine();

        Console.WriteLine("Please provide institution's state");
        institution.State = Console.ReadLine();

        Console.WriteLine("Please provide institution's city");
        institution.City = Console.ReadLine();

        InstitutionData institutionData = new InstitutionData("Server=localhost;Database=institute;Trusted_Connection=True;");
        bool result = institutionData.AddInstitution(institution);

        if (result)
        {
            Console.WriteLine("Institution added successfully");
        }
    }

    private static void UpdateInstitution()
    {
        Institution institution = new Institution();

        Console.WriteLine("Please provide institution's id");
        institution.Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please provide institution's name");
        institution.Name = Console.ReadLine();

        Console.WriteLine("Please provide institution's country");
        institution.Country = Console.ReadLine();

        Console.WriteLine("Please provide institution's state");
        institution.State = Console.ReadLine();

        Console.WriteLine("Please provide institution's city");
        institution.City = Console.ReadLine();

        InstitutionData institutionData = new InstitutionData("Server=localhost;Database=institute;Trusted_Connection=True;");
        bool result = institutionData.UpdateInstitution(institution);

        if (result)
        {
            Console.WriteLine("Institution updated successfully");
        }
    }

    public static void GetInstitutions()
    {
        InstitutionData institutionData = new InstitutionData("Server=localhost;Database=institute;Trusted_Connection=True;");

        List<Institution> institutions = institutionData.GetInstitutions();

        foreach (Institution institution in institutions)
        {
            Console.WriteLine("=====================");

            Console.WriteLine($"Id: {institution.Id}");
            Console.WriteLine($"Name: {institution.Name}");
            Console.WriteLine($"City: {institution.City}");
            Console.WriteLine($"State: {institution.State}");
            Console.WriteLine($"Country: {institution.Country}");

            Console.WriteLine("=====================");
        }
    }
}