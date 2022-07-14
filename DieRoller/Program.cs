using DieRoller;

Die myDie = new Die(); // when a die is created, a random faceValue should be set
byte currentValue = myDie.FaceValue;

myDie.Roll();
myDie.Roll();
myDie.Roll();
myDie.Roll();

Console.ReadKey();