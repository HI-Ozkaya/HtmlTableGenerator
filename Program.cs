using System.Text.Json;
using System.Text.Json.Serialization;

string rootPath = Environment.CurrentDirectory;
string path = Path.Combine(rootPath, "movies.json");
string jsonMovies = File.ReadAllText(path);

List<Movie> Movies;

JsonSerializerOptions options = new();
options.PropertyNameCaseInsensitive = true;

Movies = JsonSerializer.Deserialize<List<Movie>>(jsonMovies, options);

string htmlTable = "";

htmlTable += "<table>";
htmlTable += "<th>";
htmlTable += "<tr>";
htmlTable += "<td>id</td>";
htmlTable += "<td>title</td>";
htmlTable += "<td>rating</td>";
htmlTable += "<td>genre</td>";
htmlTable += "<td>duration</td>";
htmlTable += "</tr>";
htmlTable += "</th>";

htmlTable += "<tbody>";
foreach (var item in Movies)
{
    htmlTable += "<tr>";
    htmlTable += "<td>" + item.Id + "</td>";
    htmlTable += "<td>" + item.Title + "</td>";
    htmlTable += "<td>" + item.Rating + "</td>";
    htmlTable += "<td>" + item.Genre + "</td>";
    htmlTable += "<td>" + item.Duration + "</td>";
    htmlTable += "</tr>";
}
htmlTable += "</tbody>";
htmlTable += "</table>";

path = Path.Combine(rootPath, "output.html");
File.WriteAllText(path, htmlTable);
