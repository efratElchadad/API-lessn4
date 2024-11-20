using Microsoft.AspNetCore.Mvc;
using pizza2;

public interface orderManneger{
public orders getById(int id);
public orders getByName(String name);
public bool delitedOrders(int id);
public bool putOrders(String name,int id);

}