using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {   
        //instancias do tipo cliente  e atribuir clientes
        Cliente cliente1 = new Cliente(01, "Vanessa Rodrigues", "123.456.789-00", "vanessrodrigues@hotmail.com", "Dom");
        Cliente cliente2 = new Cliente(02, "Vany Rodrigues", "012.345.678-91", "vanyrodrigues@hotmail.com", "Fred");
        Cliente cliente3 = new Cliente(03, "Juliana Roberto", "234.567.891-12", "julianaroberto@hotmail.com", "Bene");
        Cliente cliente4 = new Cliente(04, "Marlene Rodrigues", "345.678.911-23", "marlenerodrigues@hotmail.com", "Frederico");
        Cliente cliente5 = new Cliente(05, "Amaro Severino", "456.789.112-34", "amaroseverino@hotmail.com", "Benedita");
        
        //Lista Clientes 
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        //instancias do tipo fornecedores e atribuir fornecedores
        Fornecedor fornecedor1 = new Fornecedor(01, "C# Pet S/A", "14.182.102/0001-88", "c#pets@hotmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "JavaScript LTDA", "14.182.102/0001-89", "jsltda@hotmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "NodeJS ME", "14.182.102/0001-10", "nodejsme@hotmail.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "HTML S/A", "10.182.102/0001-89", "htmlsa@hotmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Python LTDA", "16.182.102/0001-00", "pythonltda@hotmail.com");
        
        //Lista Forncedores 
         List<Fornecedor> listaFornecedores = new List<Fornecedor>();
         
         listaFornecedores.Add(fornecedor1);
         listaFornecedores.Add(fornecedor2);
         listaFornecedores.Add(fornecedor3);
         listaFornecedores.Add(fornecedor4);
         listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
