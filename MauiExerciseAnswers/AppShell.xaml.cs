using MauiExerciseAnswers.Models;
using MauiExerciseAnswers.Views.Lesson05;
using Microsoft.Maui;

namespace MauiExerciseAnswers;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        //Exercise ShellMenu: Adding an item to a Shell Menu in C#
        var NewsPapers = NewsSource.All;

        Tab aTab;
        foreach (var item in NewsPapers)
        {
            //Create a Tab, set its relevant properties
            //Create a ShellContent , set its relevant properties
            //Add the ShellContent into the Tab

            //Add the Tab into lesson5news2 flyout item from the Xaml page
            //Your code
            
            
            aTab = new Tab { Title = item.Name };
            aTab.Items.Add(new ShellContent
            {
                Title = item.Name,
                Route = item.Name.ToLower(),
                ContentTemplate = new DataTemplate(() => new WebViewExplore(item))
            });
            lesson5news2.Items.Add(aTab);
            
        }
    }
}
