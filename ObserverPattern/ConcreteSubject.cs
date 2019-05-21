namespace ObserverPattern
{
    public class ConcreteSubject : Subject
    {
        private string _action { get; set; }

        public string SubjectState
        {
            get => _action;
            set => _action = value;
        }
    }
}