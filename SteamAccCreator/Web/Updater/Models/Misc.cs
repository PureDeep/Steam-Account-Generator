﻿using Newtonsoft.Json;

namespace SteamAccCreator.Web.Updater.Models
{
    public class Misc
    {
        [JsonProperty("mail_box_url")]
        public string MailBoxUrl { get; set; } = Program.DEFAULT_URL_MAILBOX;
    }
}
