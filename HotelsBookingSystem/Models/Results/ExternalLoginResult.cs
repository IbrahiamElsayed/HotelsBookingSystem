namespace HotelsBookingSystem.Models.Results
{
    public class ExternalLoginResult : LoginResult
    {
        public new bool Succeeded { get; set; }
        public new bool IsAdmin { get; set; }
        public new string? ErrorMessage { get; set; }
    }
}
