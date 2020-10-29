string[] nameArray = { "name", "othername", "anothername" };
var dict = new Dictionary<string, data>();
foreach ( var file in nameArray )
{
    dict[file] = new data();
}