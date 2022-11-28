### Singleton

One of the creative patterns, ***singleton*** , is to create an object of a class (which can be a database object, a file creation object, etc.) once and then
It also helps us to use that object in the classes that are needed. In short, an object is created once and used in different classes.


***How do we prevent an object from occurring more than once?*** Of course, if we make the constructor class private. In this way, the object of the class can only be created in that class, and not in other classes.
cannot occur.

`
public class A
   {
        private class A()
        {
        
        }
   }
` 

We also need to check if the object has already been created, and the object field is static to keep the previous changes on the object makes.

Well, we made the constructor of the class private, but in order to use the object of this class, we need to access this object somehow. 
***How do we access this object?*** Of course get with the method.
We can return the object of the class with a get method that returns a value of the class type, and we operate on this object in other classes.

Here's a class with a Singelton pattern:

`
public class A
    {
        private static A a;
        private static readonly object obj = new object();
        private A()
        {

        }

        public static A getInstance()
        {
            if (a == null)
            {
                lock (obj)
                {
                    if (a == null)
                    {
                        a = new A();
                    }

                }
            }
            return a;
        }
    }
 `
   ***What is the lock keyword here?***
   If you are performing operations on more than one Thread and you are going to function as a single Thread in certain code areas in this set of operations, Lock
   You can use the keyword. As you can see, by reducing a function section in a multi-thread flow to a single channel, you can actually use it in other channels 
   before that process ends.It will ensure that you stop the process process.So if we are going to use the singleton pattern as a multiple threah, we need to use
   the lock keyword. For example, let's consider a process with 100 threads. All threads firstIt came into if , if the object has never been created it will only 
   go into 1 thread lock and will not allow other threads to enter. Pass the second if checkwill create the object. The other 99 threads will not be able 
   to pass the second if check and produce the object, and the object will be created once.
