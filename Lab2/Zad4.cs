using ConsoleApp1;

static void run()
{
    Licz licz1 = new Licz(10);
    Licz licz2 = new Licz(20);
    Licz licz3 = new Licz(5);

    licz1.WypiszStan();
    licz2.WypiszStan();
    licz3.WypiszStan();

    licz1.Dodaj(5); 
    licz2.Odejmij(10);  
    licz3.Dodaj(15);  

    licz1.WypiszStan();  
    licz2.WypiszStan();  
    licz3.WypiszStan();  
}

run();
