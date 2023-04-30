namespace StarWarsBlazor.Domain;

public class Specie
{
    public string Name { get; set; }
    public string Classification { get; set; }
    public string Designation { get; set; }
    public string Average_Height { get; set; }
    public string Average_Lifespan { get; set; }
    public string Eye_Colors { get; set; }
    public string Hair_Colors { get; set; }
    public string Skin_Colors { get; set; }
    public string Language { get; set; }
    public string Homeworld { get; set; }
    public List<People> People { get; set; }
    public List<Film> Films { get; set; }
    public string Url { get; set; }
    public string Created { get; set; }
    public string Edited { get; set; }
}
