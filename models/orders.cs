namespace pizza2;
using Microsoft.AspNetCore.Mvc;


public class orders{
public String name{get; set;}
public int id{get; set;}
public int phone{get; set;}
public orders(String _name,int _id,int _phone){
    this.id=_id;
    this.name=_name;
    this.phone=_phone;
}
}