using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace lab3mp3
{
    public class jsonHelper
    {
        public string Pathstring = @"C:\Users\matsp\AppData\Local\Quiz\question.json";

        private readonly JsonSerializerOptions _options = new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
        public async Task<List<Question>> LoadQuestions()
        {
            string json = await File.ReadAllTextAsync(Pathstring);
            List<Question> Questions = JsonConvert.DeserializeObject<List<Question>>(json);
            return Questions;
        }

        public async Task SaveQuestions(List<Question> objquestion)
        {
            var jsonString = JsonConvert.SerializeObject(objquestion, Formatting.Indented);
            await File.WriteAllTextAsync(Pathstring, jsonString);

        }
    }
}
