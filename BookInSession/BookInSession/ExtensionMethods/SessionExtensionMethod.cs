using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace BookInSession.ExtensionMethods
{
    public static class SessionExtensionMethod
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            string objectString = JsonSerializer.Serialize(value);
            session.SetString(key,objectString);
        }

        public static T GetObject<T>(this ISession session, string key) where T : class
        {
            string objectString = session.GetString(key);
            if (string.IsNullOrEmpty(objectString))
            {
                return null;
            }

            T value = JsonSerializer.Deserialize<T>(objectString);
            return value;
        }
    }
}