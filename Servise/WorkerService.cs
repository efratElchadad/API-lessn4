using System.Security.Cryptography;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
namespace pizza2;


public class WorkerService: Worker
{

     List <Worker> workerList=new List<Worker>
    {
        new Worker("chaim",20,1548),
        new Worker("moshe",25,45987),
        new Worker("tamir",30,46546),
        new Worker("shlomo",40,746874),
        new Worker("rami",30,17467),
    };
    public Worker GetId(int id)
    {
        foreach(var i in workerList)
        {
            if(i.id==id)
            {
               return i;
            }
           
        }
         return null;
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

}