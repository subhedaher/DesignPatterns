using ObserverPattern.Classes;

A a = new A();

a.AddSubscriber(new B());
a.AddSubscriber(new C());
a.AddSubscriber(new D());
a.AddSubscriber(new E());

a.NewData("Hi");