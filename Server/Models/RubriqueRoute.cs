namespace BlazorCrud.Server.Models
{
    public class RubriqueRoute
    {
        public int Id { get; set; }
        public string RouteNameCf { get; set; }
        public string RouteNameUs { get; set; }

        public RubriqueRoute(int rubriqueId, string routeNameCf, string routeNameUs)
        {
            Id = rubriqueId;
            RouteNameCf = routeNameCf;
            RouteNameUs = routeNameUs;
        }
    }
}
