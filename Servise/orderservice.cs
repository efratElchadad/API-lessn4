using Microsoft.AspNetCore.Mvc;
using pizza2;


using Microsoft.AspNetCore.Mvc;
#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace PIZZA2.Controllers
#pragma warning restore IDE0130 // Namespace does not match folder structure
{
    class orderServices: orderManneger{
    List<orders> ordersList=new List<orders>()
    {
    new orders("elisheva",500,0765445554),
    new orders("sara",501,0765445554),
    new orders("chani",503,0765445554),
    new orders("riki",504,0765445554),
    };

    [Route("[action]/{id}")]
    [HttpGet]
    public orders getById(int id){
        foreach(var i in ordersList){
            if(i.id==id)
              return i;
        }
        return null;
    }
    [Route("[controller]/getByName/{name}")]
    [HttpGet]
    public orders getByName(String name){
        foreach(var i in ordersList){
            if(i.name==name)
              return i;
        }
        return null;
    }
    [Route("[action]/{id}")]
    [HttpGet]
    public bool delitedOrders(int id){
        foreach(var i in ordersList){
            if(i.id==id){
                ordersList.Remove(i);
                return true;
            }
            return false;        
        }
        return false;
    }
    }
}