namespace pizza2;
using Microsoft.AspNetCore.Mvc;
    public class Worker
    {
        public String name{get;set;}
        public int age{get;set;}
        public int id{get;set;}

        public Worker(String name,int age,int id){
            this.name=name;
            this.age=age;
            this.id=id;
        }
    }
