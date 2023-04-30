namespace StarWarsBlazor.Domain;

public class Planet
{
    public string Name { get; set; }
    public string Diameter { get; set; }
    public string Rotation_Period { get; set; }
    public string Orbital_Period { get; set; }
    public string Gravity { get; set; }
    public string Population { get; set; }
    public string Climate { get; set; }
    public string Terrain { get; set; }
    public string Surface_Water { get; set; }   
    public List<People> Residents { get; set; }
    public List<Film> Films { get; set; }
    public string Url { get; set; } 
    public string Created { get; set; }
    public string Edited { get; set; }

}
