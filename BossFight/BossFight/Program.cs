using BossFight;

GameCharacter hero = new GameCharacter("Hero", 100, 20, 40);
GameCharacter boss = new GameCharacter("Boss", 400, 20, 10);

RunMatch();

void RunMatch()
{
    while (hero.Health > 0 && boss.Health > 0)
    {
        hero.Fight(boss);
        boss.Fight(hero);
    }

    RunCheckWinner();
}

void RunCheckWinner()
{
    string winner = "";
    if (hero.Health > 0)
    {
        winner = hero.Type;
    }
    else
    {
        winner = boss.Type;

    }

    Console.WriteLine($"The winner is the {winner}");
}