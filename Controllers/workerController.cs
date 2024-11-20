using System.Security.Cryptography;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
namespace pizza2;
namespace PIZZA2.Controllers;

public class WorkerService:BaseController
{
 orderManneger _workerController;
 public WorkerService(IWorker worker1){
 _workerController=worker1;
 }


   

public IActionResult GetId(int id){
    var p = _workerController.getById(id);
    if (p!=null)
        return Ok("ok");

    return NotFound("the id not found in the list");
}


    public Worker GetNmae(string name)
    {
        foreach(var i in workerList)
        {
            if(i.name==name)
            {
                return i;
            }
            
        }
        return null;
    }
    public bool updateAge(int age,int id)
    {
        foreach(var i in workerList)
        {
            if(i.id==id)
            {
                i.age=age;
                return true;
            }
           
        }
         return false;
    }
     public bool addWorker(string name,int age,int id)
    {
        workerList.Add(new Worker(name,age,id));
        return  true;
    }
    public Worker deleteWorker(int id)
    {
         foreach(var i in workerList)
        {
            if(i.id==id)
            {
                workerList.Remove(i);
                return i;
            }
            
        }
        return null;
    }

    public override bool Equals(object? obj)
    {
        return obj is WorkerService service &&
               EqualityComparer<orderManneger>.Default.Equals(_workeManneger, service._workeManneger);
    }
}