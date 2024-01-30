using System.Text.Json.Serialization;

namespace PasswordManager
{
    public class PMData
    {
        [JsonInclude]
        public byte[] hashedMasterPassword;
        [JsonInclude]
        public string salt;
        [JsonInclude]
        public List<Entry> entries = new();

        public PMData(byte[] hashedMasterPassword, string salt)
        {
            this.hashedMasterPassword = hashedMasterPassword;
            this.salt = salt;
        }
    }
}
