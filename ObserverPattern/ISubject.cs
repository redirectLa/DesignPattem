namespace ObserverPattern
{
    public interface ISubject
    {
        void Notify();

        string SubjectState { get; set; }
    }
}