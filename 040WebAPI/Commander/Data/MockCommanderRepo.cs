using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kattle"},
                new Command{Id=1, HowTo="Cut bread", Line="get a knife", Platform="knife & chopping board"},
                new Command{Id=2, HowTo="make cup of tea", Line="place teabag", Platform="Kattle & cup"},
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kattle"};
        }
    }
}