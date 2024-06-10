using System;

namespace TextAdventure
{
    internal class Task : Game
    {
        public string Title { get; protected set; }
        public string Choice { get; private set; }
        protected string Description { get; set; }
        public string[] KeyWords { get; protected set; }
        public bool CanProgress { get; private set; }

        public Task(string title, string choice, string description, bool canProgress, params string[] keyWords)
        {
            Title = title;
            Choice = choice;
            Description = description;
            CanProgress = canProgress;
            KeyWords = keyWords;
        }

        public virtual void DoTask()
        {
            console.PrintLine(Description);
        }

    }
}