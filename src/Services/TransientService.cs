namespace BlazorDIExamples.Services
{
    public class TransientService
    {
        public string Id { get; } 
        public TransientService()
        {
            Id = "I am a transient service and was created at " + System.DateTime.Now.ToString("HH:mm:ss.fff") ;
        }

    }
}
