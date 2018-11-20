using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivot
{
    class ViewModel
    {
        //Creating and defining collections/lists
        private ObservableCollection<Project> projectList = new ObservableCollection<Project>();
        private ObservableCollection<Participant> participantList = new ObservableCollection<Participant>();
        private ObservableCollection<Thing> thingList = new ObservableCollection<Thing>();

        public ViewModel()
        {
            projectList.Add(new Project() { Name = "Project One", Description = "This is Description One of Project One" });
            projectList.Add(new Project() { Name = "Project Two", Description = "This is Description Two of Project Two" });
            projectList.Add(new Project() { Name = "Project Three", Description = "This is Description Three of Project Three" });
            //Adding OrderBy
            projectList = new ObservableCollection<Project>(projectList.OrderBy(project => project.Name).ToList());

            participantList.Add(new Participant() {Name = "Adam Adamsen", Email = "adam@edu.easj.dk"});
            participantList.Add(new Participant() {Name = "Berit Beritsen", Email = "berit@edu.easj.dk"});
            participantList.Add(new Participant() {Name = "Casandra Casandrasen", Email = "casandra@edu.easj.dk"});
            //Adding OrderBy
            participantList = new ObservableCollection<Participant>(participantList.OrderBy(participant => participant.Name).ToList());

            thingList.Add(new Thing() {Name = "Strikkesæt", Delivered = DateTime.Now, Returned = DateTime.Today, Keyword = "Strikke" });
            thingList.Add(new Thing() {Name = "Smedesæt", Delivered = DateTime.Now, Returned = DateTime.Today, Keyword = "Smede" });
            thingList.Add(new Thing() {Name = "Skrivesæt", Delivered = DateTime.Now, Returned = DateTime.Today, Keyword = "Skrive"});
            //Adding OrderBy
            thingList = new ObservableCollection<Thing>(thingList.OrderBy(thing => thing.Name).ToList());
        }

        public ObservableCollection<Project> ListA
        {
            get { return projectList; }
            set { projectList = value; }
        }
        public ObservableCollection<Participant> ListB
        {
            get { return participantList; }
            set { participantList = value; }
        }

        public ObservableCollection<Thing> ListC
        {
            get { return thingList; }
            set { thingList = value; }
        }
    }
}
