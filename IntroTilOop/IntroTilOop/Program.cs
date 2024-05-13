using IntroTilOop;

//var pikachu = new Pikachu();
//Console.WriteLine(pikachu.Health + "hp, level: " + pikachu.Level);
var pikachu = new Pokemon("Pikachu", 26, 2);
var bulbasaur = new Pokemon("Bulbasaur", 22, 32);
Console.WriteLine($"{pikachu.Name} is level {pikachu.Level} and has {pikachu.Health}hp");
Console.WriteLine($"{bulbasaur.Name} is level {bulbasaur.Level} and has {bulbasaur.Health}hp");