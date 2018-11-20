using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Pivot.Annotations;

namespace Pivot
{
    class ViewModel : INotifyPropertyChanged
    {
        //Creating and defining collections/lists
        private ObservableCollection<Project> projectList = new ObservableCollection<Project>();
        private ObservableCollection<Thing> thingList = new ObservableCollection<Thing>();
        private Project selectedProject;

        public ViewModel()
        {
            projectList.Add(new Project() { Name = "Project One", Description = "This is Description One of Project One" });
            projectList.Add(new Project() { Name = "Project Two", Description = "This is Description Two of Project Two" });
            projectList.Add(new Project() { Name = "Project Three", Description = "This is Description Three of Project Three" });
            //Adding OrderBy
            projectList = new ObservableCollection<Project>(projectList.OrderBy(project => project.Name).ToList());

            thingList.Add(new Thing() {Name = "Strikkesæt", Delivered = DateTime.Now, Returned = DateTime.Today, Keyword = "Strikke" });
            thingList.Add(new Thing() {Name = "Smedesæt", Delivered = DateTime.Now, Returned = DateTime.Today, Keyword = "Smede" });
            thingList.Add(new Thing() {Name = "Skrivesæt", Delivered = DateTime.Now, Returned = DateTime.Today, Keyword = "Skrive"});
            //Adding OrderBy
            thingList = new ObservableCollection<Thing>(thingList.OrderBy(thing => thing.Name).ToList());

            selectedProject = projectList[0];
        }

        public ObservableCollection<Project> ListA
        {
            get { return projectList; }
            set { projectList = value; }
        }

        public ObservableCollection<Thing> ListC
        {
            get { return thingList; }
            set { thingList = value; }
        }

        public Project SelectedProject
        {
            get { return selectedProject; }
            set
            {
                selectedProject = value; 
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
