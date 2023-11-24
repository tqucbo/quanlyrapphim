namespace QuanLyRapPhim.Models
{
    public class MessageViewModel
    {
        public string title { set; get; } = "Thông báo";

        public string content { set; get; } = "";

        public string urlRedirect { set; get; } = "/";

        public int secondsWait { set; get; } = 5;
    }
}