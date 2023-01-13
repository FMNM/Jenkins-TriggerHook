using System.Text;
using Jenkins_TriggerHook.TriggerHookUp.DTO;
using Newtonsoft.Json;

namespace Jenkins_TriggerHook.TriggerHookUp
{
    public static class Hook
    {
        public static async Task Trigger()
        {
            using var client = new HttpClient();

            // Get crumbs for Jenkins
            var credentials = GetJenkinsCredentials();
            var byteArray = Encoding.ASCII.GetBytes(credentials.username + ":" + credentials.password);
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            var crumbResponse = client.GetAsync("http://localhost:8088/crumbIssuer/api/json").Result;
            var crumbResponseContent = crumbResponse.Content.ReadAsStringAsync();
            var crumbs = JsonConvert.DeserializeObject<Crumbs>(crumbResponseContent.Result);

            // Trigger the build
            client.DefaultRequestHeaders.TryAddWithoutValidation(crumbs.crumbRequestField, crumbs.crumb);
            var content = new StringContent("{\"key\":\"value\"}", Encoding.UTF8, "application/json");

            await client.PostAsync("http://localhost:8088/job/OpenhausMVP-PatchBuild/build?token=OphsToken", content);
        }

        private static JenkinsCreds GetJenkinsCredentials()
        {
            var jsonString = File.ReadAllText(Directory.GetCurrentDirectory() + "/TriggerHookUp/JenkinsCreds.json");
            return JsonConvert.DeserializeObject<JenkinsCreds>(jsonString) ?? throw new InvalidOperationException();
        }
    }
}