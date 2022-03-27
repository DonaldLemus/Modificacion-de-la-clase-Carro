using Modificacion_de_la_clase_Carro.Clase;

micarro micarro = new micarro("Toyota", "Negro", 50);

Console.WriteLine(micarro.informacion());
Console.WriteLine(micarro.encerdermotor());

for(int i = 0; i < 5; i++)
{
    Console.WriteLine(micarro.acelerar());
}
Console.WriteLine(micarro.getvelocidad());

Console.WriteLine(micarro.frenar());
Console.WriteLine(micarro.getvelocidad());
Console.WriteLine(micarro.bocinar());


Console.WriteLine(micarro.frenartodo());


for (int i = 0; i < 5; i++)
{
    Console.WriteLine(micarro.desacelerar());
}
Console.WriteLine(micarro.frenartodo());
Console.WriteLine(micarro.apagarmotor());