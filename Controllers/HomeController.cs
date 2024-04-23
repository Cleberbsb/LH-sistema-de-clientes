using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;
using LHPet.models;

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
        //instancias do tipo cliente
        cliente cliente1 = new cliente(01, "Arthur A. Ferreira", "528.567.94-02", "arthutr,ferreira@sp.com.br", "madruga");
        cliente cliente2 = new cliente(02, "joao francisco", "798.584.165-98", "joaofrancisco@sp.com.br", "dantas");
        cliente cliente3 = new cliente(03, "maria jose", "135.978.946-15", "maria-jose@sp.com.br", "apolo");
        cliente cliente4 = new cliente(04, "joaquim rodrigues", "978.567.85-01", "joaquim.rodrigues@sp.com.br", "negao");
        cliente cliente5 = new cliente(05, "joana maria", "648.912.35-68", "joana.maria@sp.com.br", "caramelo");
        
         //lista de clientes  = atribui os clientes
        List<cliente> listaClientes = new List<cliente>();
       listaClientes.Add(cliente1);
       listaClientes.Add(cliente2);
       listaClientes.Add(cliente3);
       listaClientes.Add(cliente4);
       listaClientes.Add(cliente5);

         ViewBag.listaClientes = listaClientes;
       
        //entancias do tipo fornecedor 
        Fornecedor fornecedor1 = new Fornecedor(01, "pets S/A", "28.459.987/0001-88", "c-sharps@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "distri S/A", "57.159.935/0001-99", "distri@pet.org");
        Fornecedor fornecedor3 = new Fornecedor(03, " Agropecuaria S/A", "82.989.877/0001-98", "agrop@pet.org");
        Fornecedor fornecedor4 = new Fornecedor(04, "ximenes S/A", "29.499.357/0001-48", "ximenes@pet.org");
        Fornecedor fornecedor5 = new Fornecedor(05,"cavalcante S/A", "25.159.997/0001-35", "cavalcante@pet.org");
       
        //lista de fornecedores  = atribui os clientes
        List<fornecedor> listaFornecedores = new List<Fornecedor>();
       listaFornecedores.Add(fornecedor1);
       listaFornecedores.Add(fornecedor2);
       listaFornecedores.Add(fornecedor3);
       listaFornecedores.Add(fornecedor4);
       listaFornecedores.Add(fornecedor5);
       
    ViewBag.listaFornecedores = listaFornecedores;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
