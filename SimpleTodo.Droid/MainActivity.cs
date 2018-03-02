using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace SimpleTodo.Droid
{
    [Activity(Label = "Simple Todo", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private ListView tasksListView;
        private Button addTaskButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            tasksListView = FindViewById<ListView>(Resource.Id.tasksListView);
            addTaskButton = FindViewById<Button>(Resource.Id.addTaskButton);

            addTaskButton.Click += AddButtonClicked;
        }

        private void AddButtonClicked(object sender, EventArgs e)
        {
            StartActivity(typeof(AddTaskActivity));
        }
    }
}