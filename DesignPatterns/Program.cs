using DataBusPattern.Classes;

A a = new A();
B b = new B();
C c = new C();
D d = new D();

DataBus.GetInstance()
    .AddSubscriber(a);
DataBus.GetInstance()
    .AddSubscriber(b);
DataBus.GetInstance()
    .AddSubscriber(c);
DataBus.GetInstance()
    .AddSubscriber(d);

a.DataSend("hi");

b.DataSend(10);

