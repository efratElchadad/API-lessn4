public interface pizzaManneger{
public pizza2.urriesPizza getById(int id);
public pizza2.urriesPizza getByName(String name);
public bool delitedPizza(int id);
public bool putPizza(String name,int id,bool gluten);
public bool postPizza(int id,bool isGlutan);
}