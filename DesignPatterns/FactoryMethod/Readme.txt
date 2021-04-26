
The Prototype Pattern 

The Prototype pattern is a creational pattern in which objects are created using a prototypical instance of said object.  
This pattern is particularly useful for creating lots of instances of an object, 
all of which share some or all of their values.


The situation in which this pattern as being the most useful is when all of the following happens:

    You need to create a lot of instances of an object,
    AND those instances will be the same or similar as the prototypical instance.
    AND creating a new instance of this object would be markedly slower than cloning an existing instance.

What you need to implement?

    The Prototype declares an interface for cloning itself.
    The ConcretePrototype implements the cloning operation defined in the Prototype.
    The Client creates a new object by asking the Prototype to clone itself.


    this.MemberwiseClone();
    it create the instance of the class