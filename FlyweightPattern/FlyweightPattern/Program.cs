using FlyweightPattern.Flyweight;

var myCity = new City();

myCity.BuildHome("21 Street, number 15", "Condominium", 5);
myCity.BuildHome("21 Street, number 127", "Townhouse", 1);
myCity.BuildHome("White Street, number 6", "Condominium", 5);
myCity.BuildHome("Red Street, number 51", "Townhouse", 2);
myCity.BuildHome("Green Street, number 144", "Townhouse", 2);

myCity.PrintHomes();