“Adapter” as the name suggests is the object which lets two mutually incompatible interfaces
communicate with each other.

This pattern involves a single class called adapter which is responsible for communication between
two independent or incompatible interfaces.

But why we want “someone” to adapt to something? You will get an answer if you answer this
simple thing- Your laptop charger which you bought in US has flattish pins which easily gets
hooked into electrical sockets in US. But when you travel to European countries you may have
round holes in the electrical sockets. What do you do then?-Simple buy socket adapters/converters
for that.

We use Adapters when incompatible interfaces are involved. Our client object wants to call a method
but it is not able to because the interface which our client object can use, is not available with the
code which our client object wants to call. Based on what an adapter does the adapter design pattern
is also called wrapper pattern, translator pattern.

The Adapter design pattern is easy to implement and ensures calling the existing code which was otherwise
difficult because their interfaces being incompatible. It is quiet common when legacy code has to be called.