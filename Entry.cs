using System.Text.Json.Serialization;

namespace PasswordManager
{
    public class Entry
    {
        [JsonInclude]
        public string service;
        [JsonInclude]
        public string username;
        [JsonInclude]
        public byte[] encryptedPassword; // encrypted
        [JsonInclude]
        public string note;

        public Entry(string service, string username, byte[] encryptedPassword, string note)
        {
            this.service = service;
            this.username = username;
            this.encryptedPassword = encryptedPassword;
            this.note = note;
        }
    }
}
