namespace pizza2;

public class urriesPizza{

public String name{get; set;}
public int id{get; set;}
public bool isGlutan{get; set;}

public urriesPizza(String name,int id,bool isGlutan){
    this.name=name;
    this.id=id;
    this.isGlutan=isGlutan;
}
}