using System;
using System.IO;
using SQLite;

namespace SimpleTodo
{
    public class Task
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

        public void Store()
        {
            var connection = new SQLiteConnection(Path.Combine(
                System.Environment.GetFolderPath(Environment.SpecialFolder.Personal), "tasks.db3"));
            connection.CreateTable<Task>();
            connection.Insert(this);
            connection.Close();
        }
    }
}
