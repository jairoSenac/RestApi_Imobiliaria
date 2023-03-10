using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_ImobiliariaSantos.Models;
using Microsoft.AspNetCore.Mvc;
namespace WebAPI_ImobiliariaSantos.Controllers
{



    [ApiController]
    [Route("/WebAPI_ImobiliariaSantos/api/[controller]")]

    public class ImoveisController:ControllerBase
    {
        

     [HttpPost]
public IActionResult Cadastra(Imoveis imoveis)
{
   
    
    if(!ModelState.IsValid) // faz validação no parametro recebido, nesse  caso, ele faz validação em "Imoveis imoveis"
        return BadRequest(ModelState);
    
    ImoveLServices Im = new ImoveLServices();
    Im.CadastrarImovel(imoveis);
    return Ok(imoveis);
    
}


[HttpGet]
public IActionResult ListarTodos()
{
    try{
        ImoveLServices Im = new ImoveLServices();
        List<Imoveis> imoveis = Im.ListarImoveis();
        return Ok(imoveis);
    }
    catch(Exception)
    {
        return StatusCode(500, "Falha ao processar dados");
    }
}
        
    }
}