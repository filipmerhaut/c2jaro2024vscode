C#2 Jaro 2024
Lekce 08 Breakout Room 02
Rozšířená verze

Původní zadání: 
https://dotnetfiddle.net/rwz8Y8
- napiste dva ruzne interfacy: IUmiPocitatObsah, IUmiPocitatObvod
- implementujte tridy obdelnik a kruh, ktere oba interfacy pouzivaji
- vlozte jejich instance do seznamu a zavolejte na nich prislusne metody na vypocet obsahu a obvodu

Rozšířené zadání:
- vytvořte abstraktní třídu BaseClass s jednou vlastností id typu Guid, z této třídy budou dědit všechny třídy v projektu
- účel třídy BaseClass je poskytnout jedinečné id (guid) pro každý objekt každé naší třídy 
- vytvořte abstraktní třídu Tvar, která bude sloužit jako rodičovská třída pro všechny třídy geometrikých objektů (Obdelnik, Kruh) 
- účel třídy je umožnit vytváření smíšené kolekce obsahující jak objekty Obdelnik, tak objekty Kruh
- tato třída také bude používat rozhraní IUmiPocitatObsah, IUmiPocitatObvod (tzn. třídy Obdelnik a Kruh nebudou tyto rozhraní používat přímo)
- třída Obdelnik bude implementovat také interface IComparable 
- toto rozhraní umožní nad kolekcí objektů Obdelnik volat metodu Sort()
- otestuje výpisem kolekce obdelníků před voláním metody Sort() a po volání metody Sort()
