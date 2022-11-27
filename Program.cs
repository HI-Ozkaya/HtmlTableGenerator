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
htmlTable += "<table>\n";

htmlTable += "\t<th>\n";
htmlTable += "\t\t<tr>\n";
htmlTable += "\t\t\t<td>id</td>\n";
htmlTable += "\t\t\t<td>title</td>\n";
htmlTable += "\t\t\t<td>rating</td>\n";
htmlTable += "\t\t\t<td>genre</td>\n";
htmlTable += "\t\t\t<td>duration</td>\n";
htmlTable += "\t\t</tr>\n";
htmlTable += "\t</th>\n";

htmlTable += "\t<tbody>\n";
foreach (var item in Movies)
{
    htmlTable += "\t\t<tr>\n";
    htmlTable += "\t\t\t<td>" + item.Id + "</td>\n";
    htmlTable += "\t\t\t<td>" + item.Title + "</td>\n";
    htmlTable += "\t\t\t<td>" + item.Rating + "</td>\n";
    htmlTable += "\t\t\t<td>" + item.Genre + "</td>\n";
    htmlTable += "\t\t\t<td>" + item.Duration + "</td>\n";
    htmlTable += "\t\t</tr>\n";
}
htmlTable += "\t</tbody>\n";
htmlTable += "</table>";

path = Path.Combine(rootPath, "sample.html");
File.WriteAllText(path, htmlTable);

System.Console.WriteLine(htmlTable);