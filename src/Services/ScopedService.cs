namespace BlazorDIExamples.Services
{
    public class ScopedService
    {
        public string Id { get; } 
        public ScopedService()
        {
            Id = "I am a scoped service and was created at " + System.DateTime.Now.ToString("HH:mm:ss.fff") ;
        }

    }
}
