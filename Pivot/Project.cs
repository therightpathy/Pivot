using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivot
{
    class Project
    {
        //Creating methods 
        public string name;
        public string description;
        private ObservableCollection<Participant> participantList = new ObservableCollection<Participant>();

        public Project()
        {
        }

        //Creating default constructor to inherit from Participant class
        public Project(string name, string email)
        {
            participantList.Add(new Participant() { Name = "Adam Adamsen", Email = "adam@edu.easj.dk" });
            participantList.Add(new Participant() { Name = "Berit Beritsen", Email = "berit@edu.easj.dk" });
            participantList.Add(new Participant() { Name = "Casandra Casandrasen", Email = "casandra@edu.easj.dk" });
            //Adding OrderBy
            participantList = new ObservableCollection<Participant>(participantList.OrderBy(participant => participant.Name).ToList());
        }

        public ObservableCollection<Participant> ParticipantList
        {
            get { return participantList; }
            set { participantList = value; }
        }       

        //Adding get&set to methods
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
