using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
namespace PIZZA2.Controllers;

public class pizzaControllers : BaseController{


 pizzaManneger _pizzaManneger;
 public pizzaControllers(pizzaManneger pizza){
 _pizzaManneger=pizza;

 }
[Route("[action]/{id}")]
[HttpGet]
public IActionResult getById(int id){
    var p = _pizzaManneger.getById(id);
    if (p!=null)
        return Ok("the pizza name is:"+p.name+"is gluten:"+p.isGlutan);

    return NotFound("the id not found in the list");
}
[Route("[controller]/getByName/{name}")]
[HttpGet]
public IActionResult getByName(String name){
    var p = _pizzaManneger.getByName(name);
    if (p!=null)
          return Ok("the id of pizza is:"+p.id+"is gluten:"+p.isGlutan);
    return NotFound("the name not found in the list");
}
[Route("[action]/{id}")]
[HttpGet]
public IActionResult delitedPizza(int id){
    var p = _pizzaManneger.delitedPizza(id);  
     if (p!=null)
            return Ok("the remove succes");
        return NotFound("this id didnt found");        
}

public IActionResult putPizza(String name,int id,bool gluten){
    var p = _pizzaManneger.putPizza(name,id,gluten);  
     if (p!=null)
     return Ok("this nis added");
return NotFound("this id didnt added"); 
}
public IActionResult postPizza(int id,bool isGlutan){
     var p = _pizzaManneger.postPizza(id,isGlutan);  
     if (p!=null)
     return Ok("this is added a gluten");
return NotFound("this id didnt added a gluten"); 
}
        
    }


