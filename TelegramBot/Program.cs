//https://api.telegram.org/bot5810330907:AAGNXIV1WBdjNLd4udkvlxR40-5Iwu0A_7U/getME
//dotnet add package Newtonsoft.Json
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
// JSON
// {
//     "ok":true,
//     "result":
//     {
//          "id":5810330907,
//          "is_bot":true,
//          "first_name":"\u042d\u0442\u043e \u043c\u043e\u0439 \u0442\u0435\u0441\u0442\u043e\u0432\u044b\u0439 \u0431\u043e\u0442",
//          "username":"DDW1981_bot",
//          "can_join_groups":true,
//          "can_read_all_group_messages":false,"supports_inline_queries":false
//     }
// }

string token = File.ReadAllText("token.config");

TelegramBot bot = new TelegramBot(token);

void Updates(TelegramMessageModel msg)
{
    bot.SendMessage(msg.chatId, $"{msg.text}: получено");
}

bot.action = Updates;

bot.Start();

System.Console.WriteLine("+++++++");

// JObject obj = JObject.Parse(rawData);
// JArray messages = JArray.Parse(obj["result"].ToString());

// for (int i = 0; i < messages.Count; i ++)
// {
//     Console.Write($"{messages[i]["update_id"]}  ");
//     //Console.Write($"{messages[i]["message"]["text"]}");
//     //Console.Write($"{messages[i]["message"]["from"]["first_name"]} -> ");
//     Console.WriteLine($"{messages[i]["message"]["text"]}");
// }

// System.Console.WriteLine(messages.Count);

// class GetModel
// {
//     bool ok;
//     ResultModel result;
// }

// class ResultModel
// {
//     long id;
//     bool is_bot;
//     string first_name;
//     string username;
// }