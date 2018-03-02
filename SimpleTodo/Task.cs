using System;
using SQLite;

namespace SimpleTodo
{
    class Task
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Task() {}
        public Task(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
