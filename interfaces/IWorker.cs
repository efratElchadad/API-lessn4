using Microsoft.AspNetCore.Mvc;

using pizza2;
using System.ComponentModel;
public interface IWorker{

    public Worker GetId(int id);
public Worker GetName(String name);
public bool updateAge(int age,int id);
public bool addWorker(String name,int age,int id);
  public Worker deleteWorker(int id);
}