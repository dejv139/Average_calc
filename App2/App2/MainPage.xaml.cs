using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{

	public partial class MainPage : ContentPage
	{
        MyDatabase db = DBManager.Database;

        public MainPage ()
		{
            /*db.InsertSubject(new Subject { Name = "Math" });
            db.InsertSubject(new Subject { Name = "English language" });
            db.InsertSubject(new Subject { Name = "Czech Language" });
            db.InsertSubject(new Subject { Name = "Social studies" });
            db.InsertSubject(new Subject { Name = "Physical Education" });
            db.InsertSubject(new Subject { Name = "Programming" });*/
            InitializeComponent();
            FillSubjects();
        }

        public async void FillSubjects()
        {
            List<Subject> subjects = await db.GetListOf<Subject>();
            listviewSubjects.ItemsSource = subjects;
        }
	}
}