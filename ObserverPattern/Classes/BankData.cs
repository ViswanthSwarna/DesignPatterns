using ObserverPattern.Interfaces;

namespace ObserverPattern.Classes
{
    public class BankData : IPublisher<string>
    {
        List<ISubscriber<string>> subscribers = new List<ISubscriber<string>>();
        public override void Notify(string data)
        {
            foreach(ISubscriber<string> subcriber in subscribers) 
            {
                subcriber.OnChange(data);
            }
        }

        public override void Subscribe(ISubscriber<string> subcriber)
        {
            subscribers.Add(subcriber);
        }

        public override void UnSubscribe(ISubscriber<string> subcriber)
        {
            subscribers.Remove(subcriber);
        }
    }
}
