using Microsoft.AspNetCore.Mvc;

namespace PIZZA2.Controllers;

public class orderController : BaseController{
 orderManneger _orderManneger;
 public orderController(orderManneger order1){
 _orderManneger=order1;
 }
[Route("[action]/{id}")]
[HttpGet]


public IActionResult getByIdOrder(int id){
    var p = _orderManneger.getById(id);
    if (p!=null)
        return Ok("ok");

    return NotFound("the id not found in the list");
}



[Route("[controller]/getByName/{name}")]
[HttpGet]



public IActionResult getByName(String name){
    var p = _orderManneger.getByName(name);
    if (p!=null)
          return Ok("ok");
    return NotFound("the name not found in the list");
}

[Route("[action]/{id}")]
[HttpGet]

public IActionResult delitedOrders(int id){
    var p = _orderManneger.delitedOrders(id);  
     if (p!=null)
            return Ok("the remove succes");
        return NotFound("this id didnt found");        
}
    public override bool Equals(object? obj)
    {
        return obj is orderController controller &&
               EqualityComparer<orderManneger>.Default.Equals(_orderManneger, controller._orderManneger);
    }
}