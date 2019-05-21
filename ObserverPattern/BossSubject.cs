namespace ObserverPattern
{
    public class BossSubject : ISubject
    {
        public event EventHandler Update;

        public void Notify()
        {
            Update();
        }

        public string SubjectState { get; set; }
    }

    public delegate void EventHandler();
}