namespace _9_Context_and_DI.Services
{
    public class SimpleTimeService : ITimeService
    {
        public string GetTime()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
