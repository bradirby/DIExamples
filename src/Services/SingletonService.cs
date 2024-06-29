namespace BlazorDIExamples.Services
{
    public class SingletonService
    {
        public string Id { get; } 
        public SingletonService()
        {
            Id = "I am a Singleton service and was created at " + System.DateTime.Now.ToString("HH:mm:ss.fff") ;
        }
    }
}
