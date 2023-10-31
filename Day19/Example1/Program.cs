using Example1.Data;
using Example1.Entities;

namespace Example2;

public class Program
{

    private readonly IInstitutionService _institutionService;
    public Program(string connectionString)
    {
        _institutionService = new InstitutionService(connectionString);
    }


    static void Main(string[] args)
    {
        Program program = new Program("Server=localhost;Database=institute;Trusted_Connection=True;");
        Console.WriteLine("What CRUD operation do you want to execute?\n1. Create\n2. Update\n3. Delete\n4. GetAll\n5. GetSingle");
        string? option = Console.ReadLine();

        switch (option)
        {
            case "1":
                program.CreateInstitution();
                break;
            case "2":
                program.UpdateInstitution();
                break;
            case "3":
                Console.WriteLine("Enter institution id");
                int id = Convert.ToInt32(Console.ReadLine());
                program.Delete(id);
                break;
            case "4":
                program.GetInstitutions();
                break;
            case "5":
                Console.WriteLine("Enter institution id");
                int singleId = Convert.ToInt32(Console.ReadLine());
                program.GetSingleInstitution(singleId);
                break;
            default:
                Console.WriteLine("Error: Invalid option");
                break;
        }
    }

    private void CreateInstitution()
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


        bool result = _institutionService.AddInstitution(institution);

        if (result)
        {
            Console.WriteLine("Institution added successfully");
        }
    }

    private void UpdateInstitution()
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


        bool result = _institutionService.UpdateInstitution(institution);

        if (result)
        {
            Console.WriteLine("Institution updated successfully");
        }
    }

    public void GetInstitutions()
    {
        List<Institution> institutions = _institutionService.GetAll();

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
    public void GetSingleInstitution(int id)
    {
        Institution institution = _institutionService.GetById(id);

        Console.WriteLine("=====================");

        Console.WriteLine($"Id: {institution.Id}");
        Console.WriteLine($"Name: {institution.Name}");
        Console.WriteLine($"City: {institution.City}");
        Console.WriteLine($"State: {institution.State}");
        Console.WriteLine($"Country: {institution.Country}");

        Console.WriteLine("=====================");

    }
    public void Delete(int id)
    {
        bool institution = _institutionService.Delete(id);

        Console.WriteLine(institution);


        Console.WriteLine($"Data at {id} has been deleted");

    }

}