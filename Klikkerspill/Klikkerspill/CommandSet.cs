namespace Klikkerspill
{
    internal class CommandSet
    {
        private ICommand[] _commands = 
        [
            new KeyIsK(),
            new KeyIsS(),
            new KeyIsX(),
            new KeyIsSpace()
        ];

        public void RunCommand(char keyPressed)
        {
            ICommand? commandToRun = _commands.FirstOrDefault(el => el.Key == keyPressed);
            commandToRun.Run();
        }
    }
}
