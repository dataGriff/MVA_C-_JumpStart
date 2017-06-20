using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2ConstructComplexTypes
{
    public class Trainer
    {
        void Operate()
        {
            var dog = new Poodle();

            //add method to event handler
            // after type += below then tab does all code for me :)
            dog.HasSpoken += Dog_HasSpoken;  
        }

        //here's the method that gets called by event
        private void Dog_HasSpoken(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }

    //could mark this as abstract if only want people
    //to make derived classes like poodle
    public partial class Dog
    {

        //properties hold values
        public string Colour { get; set; }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                //look at value
                _name = value;
            }
        }


        //only by this class
        private void foo() { }

        //only by this and derived classes
        protected void Bar() { }

        //only in this assembly
        internal void Daw() { }

        //default of bark
        public void speak(string whatToSay = "bark")
        {
            //TODO...
            //only raise event if event is not null
            HasSpoken?.Invoke(this, EventArgs.Empty);
            /*
             simplified version of this
                if(HasSpoken != null)
            HasSpoken(this, EventArgs.Empty);
             */
        }

        //default has to come after non defaults
        public void speak(int speakTimes, string whatToSay = "bark", bool sit=true)
        {
            //TODO...
        }

        //example of event handler
        //see top of this app to see trainer using this
        public event EventHandler HasSpoken;


    }
    class Poodle: Dog
    {
        //examples of overloading speak method

        void x() {
            this.speak("woof");
        }

        //can specifiy parameters when call method with :

        void y()
        {
            this.speak(2, sit: true);
        }


    }
}
