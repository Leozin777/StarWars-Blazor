namespace StarWarsBlazor.Domain;

public class Vehicles
{
    public string Name { get; set; }
    public string Model { get; set; }
    public string Vehicle_Class { get; set; }
    public string Manufacturer { get; set; }
    public string Length { get; set; }
    public string Cost_In_Credits { get; set; }
    public string Crew { get; set; }
    public string Passengers { get; set; }
    public string Max_Atmosphering_Speed { get; set; }
    public string Cargo_Capacity { get; set; }
    public string consumables { get; set; }
    public List<Film> Films { get; set; }
    public List<People> Pilots { get; set; }
    public string Url { get; set; }
    public string Created { get; set; }
    public string Edited { get; set; }
}
