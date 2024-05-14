namespace task1
{
    using System;

    public interface IState
    {
        void Handle(Context context);
    }

    public class ConcreteStateA : IState
    {
        public void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }

    public class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }

    public class Context
    {
        private IState _state;

        public Context(IState state)
        {
            this.State = state;
        }

        public IState State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("State: " +
                  _state.GetType().Name);
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var c = new Context(new ConcreteStateA());
            c.Request();
            c.Request();
            Console.ReadKey();
        }
    }
}