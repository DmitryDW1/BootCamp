public class TelegramBot
{
    string token;
    public Action<TelegramMessageModel> action;
    HttpClient hc;
    Thread thread;

    public TelegramBot(string token)
    {
        this.token = token;
        hc = new HttpClient();
        hc.BaseAddress = new Uri($"https://api.telegram.org/bot{token}/");
        thread = new Thread(GetUpdates);
    }

    private void GetUpdates()
    {
        long offset = 0;
        while (true)
        {
            string content = hc.GetStringAsync($"getupdates?offset={offset}").Result;

            TelegramMessageModel[] ms = new JsonParser().GetMessage(content);
            if (ms.Length != 0)
            {
                foreach (var item in ms)
                {
                    Console.WriteLine(item);
                    action(item);
                    offset = item.updateId;
                }
            }
            Thread.Sleep(1000);
        }
    }

    public void SendMessage(long userId, string text)
    {

    }

    public void Start()
    {

    }
}