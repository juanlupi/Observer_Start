namespace Observer
{
    public interface IObserver
    {
       // void StartReporting(ISubject provider);
        void Update(Temperature value);
    }
}