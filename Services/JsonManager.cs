using System.IO;
using System.Text.Json;
using System;
using System.Collections.ObjectModel;
using Clients.Models;

namespace Clients.Services;

public static class JsonManager<T>
{
    public static void Serializer(string path, ObservableCollection<T> values)
    {
        JsonSerializerOptions options = new JsonSerializerOptions();
        options.WriteIndented = true;
        if (values != null)
        { 
            File.WriteAllText(path, JsonSerializer.Serialize(values, options));
        }
    }
    public static ObservableCollection<T> Deserializer(string path, ObservableCollection<T> values)
    {
        using FileStream fs = new FileStream(path, FileMode.Open);
        if (fs.Length > 0)
            values = System.Text.Json.JsonSerializer.Deserialize<ObservableCollection<T>>(fs);
        if (values == null)
            values = new();
        return values;
    }
}
