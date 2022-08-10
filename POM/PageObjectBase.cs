namespace POM
{
    public abstract class PageObjectBase
    {
        protected int ActionDelay { get; set; } = 0;

        public void WithDelay(int delay)
        {
            ActionDelay = delay;
        }

        public void DoAction(Action action)
        {
            if (action == null)
            {
                throw new ArgumentNullException("action is null, please set some action.");
            }

            action();

            Thread.Sleep(ActionDelay);
        }
    }
}
