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
        private List<Participant> _participantList = new List<Participant>();

        public Project()
        {
        }

        //Creating default constructor to inherit from Participant class
        public Project(string name, string description, List<Participant> participants)
        {
            this.name = name;
            this.description = description;
            _participantList = participants;
            
            _participantList = new List<Participant>(_participantList.OrderBy(participant => participant.Name).ToList());
        }

        public List<Participant> ParticipantList
        {
            get { return _participantList; }
            set { _participantList = value; }
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
