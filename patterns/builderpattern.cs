using System;
/* builder pattern is a pattern which is used to make configurable complex objects step by step using classes such
as bulder, concrete builder, director and client or product.
*/
namespace builder
{
public abstract class burritoBuilder
{
    //Virtual gives the liberty of overriding or not overriding the method in the child class.
    public virtual void addLettuce(){}
    public virtual void addTomatoes(){}
    public virtual void addRice(){}
    public virtual void addBeans(){}
    public virtual void addChicken(){}
    public virtual void addSourcream(){}
    public virtual void addSalsa(){}
    public virtual void addBarramundi(){}
    public virtual void addPork(){}
}
public class chickenBurritoBuilder : burritoBuilder
{
    //ChickenBurrito chickenburrito;
    
    public override void addLettuce()
    {
        Console.WriteLine("Adding lettuce to chicken burrito");
    }
    
    public override void addTomatoes()
    {
        Console.WriteLine("Adding tomatoes to chicken burrito");
    }
    
    public override void addChicken()
    {
        Console.WriteLine("Adding chicken to chicken burrito");
    }

    public override void addRice()
    {
        Console.WriteLine("Adding rice to chicken burrito");
    }
    
    public override void addBeans()
    {
        Console.WriteLine("Adding beans to chicken burrito");
    }
     
    public override void addSalsa()
    {
        Console.WriteLine("Adding salsa to chicken burrito"); 
    }

    /*public burrito GetBurrito()
    {
        return chickenburrito;
    }*/
}

public class Director
{
    burritoBuilder burritobuilder;
    public Director(burritoBuilder burritobuilder)
    {
        this.burritobuilder = burritobuilder;
    }
    public void constructBurrito()
    {
        burritobuilder.addLettuce();
        burritobuilder.addTomatoes();
        burritobuilder.addChicken();
        burritobuilder.addRice();
        burritobuilder.addBeans();
        burritobuilder.addSalsa();
    }
}
public class Client
{
    public static void main()
    {
        burritoBuilder burritobuilder = new chickenBurritoBuilder();
        Director director = new Director(burritobuilder);
        director.constructBurrito();
        /*
        burrito burrito = burritobuilder.GetBurrito();
        Console.WriteLine(burrito.toString());
        */
    }
}
}
