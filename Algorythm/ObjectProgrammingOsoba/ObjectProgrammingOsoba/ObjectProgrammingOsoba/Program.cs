using ObjectProgrammingOsoba;

Console.WriteLine("Witaj, Świat!");

Console.WriteLine("Liczba zarejestrowanych osób to " + Osoba.counter);

Osoba firstPerson = new Osoba();

Console.WriteLine("Proszę wpisać swoje imię");
string name = Console.ReadLine();//w przypadku pobrania wartości null przez metode ReadLine zostaje zwrócone string.Empty, co zapobiega ewentualnym błędą
Console.WriteLine("Proszę wpisać swoje id");
int id;
while(!int.TryParse(Console.ReadLine(), out id))
{
    Console.WriteLine("wpisane Id musi być wartością numeryczną");
}
Osoba secondPerson = new Osoba(id, name);

Osoba thirdPerson = new Osoba(secondPerson);

firstPerson.Hi("Jan");
secondPerson.Hi("Jan");
thirdPerson.Hi("Jan");

Console.WriteLine("Liczba zarejestrowanych osób to " + Osoba.counter);

