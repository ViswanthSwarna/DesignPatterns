using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{
    public abstract class IPublisher<T>
    {
        private T data;

        public void SetData(T data) 
        {
            this.data = data;
            Notify(data);
        }
        public abstract void Subscribe(ISubscriber<T> subcriber);

        public abstract void UnSubscribe(ISubscriber<T> subcriber);

        public abstract void Notify(T data);
    }
}
