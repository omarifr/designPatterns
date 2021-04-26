Factory Method
It is tedious when the client needs to specify the class name while creating the objects. 
So, to resolve this problem, we can use the Factory Method design pattern. 
It provides the client with a simple way to create the object.


    Product
     
    This defines the interface of objects the factory method creates

    ConcreteProduct
     
    This is a class that implements the Product interface.

    Creator
     
    This is an abstract class and declares the factory method, which returns an object of type Product.
     
    This may also define a default implementation of the factory method that returns a default ConcreteProduct object.
    This may call the factory method to create a Product object.

    ConcreteCreator
     
    This is a class that implements the Creator class and overrides the factory method to return an instance of a ConcreteProduct.

