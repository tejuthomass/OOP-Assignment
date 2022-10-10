package assignment_2;

abstract class Animal
{
    public String name;
    
    public Animal(String name)
    {
        this.name = name;
    }
    
    abstract void greets();
}

class Cat extends Animal
{
    Cat(String name)
    {
        super(name);
    }
    
    @Override
    public void greets()
    {
        System.out.println("Meow");
    }
}

class Dog extends Animal
{
    Dog(String name)
    {
    	super(name);
    }
    
    @Override
    public void greets()
    {
        System.out.println("Woof");
    }
    
    public void greets(Dog d)
    {
        System.out.println("Woooof");
    }
}

class BigDog extends Dog
{
    BigDog(String name)
    {
    	super(name);
    }
    
    @Override
    public void greets()
    {
        System.out.println("Wooow");
    }
    
    @Override
    public void greets(Dog d)
    {
        System.out.println("Woooooow");
    }
    
    public void greets(BigDog d)
    {
        System.out.println("Wooooooooow");
    }
}

public class Level_2 {

	public static void main(String[] args) {

		Cat c = new Cat("Bob");
		Dog d = new Dog("Jack");
		Dog d1 = new Dog("Cooper");
		BigDog dd = new BigDog("Max");
		
		c.greets();
		d1.greets(d);
		dd.greets(d1);		

	}

}
