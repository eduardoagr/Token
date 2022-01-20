using Newtonsoft.Json;

using System.Text;

using Token;

var credentials = new ThingsBoardCredentials("e.gromero@alumnos.upm.es", "Xamarin20#");

var json = JsonConvert.SerializeObject(credentials);
var data = new StringContent(json, Encoding.UTF8, "application/json");


using (var client = new HttpClient()) {

    var response = await client.PostAsync("https://srv-iot.diatel.upm.es/api/auth/login", data);
    if (response.IsSuccessStatusCode) {
        var dataRes = await response.Content.ReadAsStringAsync();
        var jsonRes = JsonConvert.DeserializeObject<Rootobject>(dataRes);

        Console.WriteLine(jsonRes.token);

    }
}