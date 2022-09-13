using System;
using System.Collections.Generic;

namespace Observer {

    public class Observable<T> : IObservable<T> {

        private List<IObserver<T>> _observers;

        public Observable()
        {
            _observers = new List<IObserver<T>>();
        }

        IDisposable IObservable<T>.Subscribe(IObserver<T> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);

            return new Unsubscriber<T>(_observers, observer);
        }


        public void Notify(T value)
        {
            foreach (var o in _observers)
                o.OnNext(value);
        }
    }

    public class Unsubscriber<T> : IDisposable
    {

        private List<IObserver<T>> _observers;

        private IObserver<T> _observer;

        public Unsubscriber (List<IObserver<T>> observers, IObserver<T> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }

    public abstract class Observer<T> : IObserver<T>
    {

        private IDisposable _unsubscriber;

        public void OnCompleted()
        {
            _unsubscriber.Dispose();
        }

        public abstract void OnError(Exception error);

        public abstract void OnNext(T value);

        public void Subscribe(IObservable<T> observable)
        {
            _unsubscriber = observable.Subscribe(this);
        }
    }

}