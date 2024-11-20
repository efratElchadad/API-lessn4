using Microsoft.AspNetCore.Mvc;
namespace pizza2;


class pizzservice:pizzaManneger{
List<pizza2.urriesPizza> pizzaList=new List<pizza2.urriesPizza>()
{
new pizza2.urriesPizza("shamenet",500,false),
new pizza2.urriesPizza("mutzrela",501,true),
new pizza2.urriesPizza("lafa",502,true),
new pizza2.urriesPizza("yevanit",503,false),
new pizza2.urriesPizza("italkit",504,false)
};

[Route("[action]/{id}")]
[HttpGet]
public pizza2.urriesPizza getById(int id){
    foreach(var i in pizzaList){
        if(i.id==id)
          return i;
    }
    return null;
}
[Route("[controller]/getByName/{name}")]
[HttpGet]
public pizza2.urriesPizza getByName(String name){
    foreach(var i in pizzaList){
        if(i.name==name)
          return i;
    }
    return null;
}
[Route("[action]/{id}")]
[HttpGet]
public bool delitedPizza(int id){
    foreach(var i in pizzaList){
        if(i.id==id){
            pizzaList.Remove(i);
            return true;
        }
        return false;        
    }
    return false; 
}

public bool putPizza(String name,int id,bool gluten){
    new pizza2.urriesPizza(name,id,gluten);
     return true;
}
public bool postPizza(int id,bool isGlutan){
    foreach(var i in pizzaList){
        if(i.id==id){
            i.isGlutan=isGlutan;
        }
        return true;   
    }
    return false;
}
}