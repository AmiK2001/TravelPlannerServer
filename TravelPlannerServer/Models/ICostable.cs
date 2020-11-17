namespace TravelPlannerServer.Models
{
    public interface ICostable
    {
        public double Cost { get; set; }
        public int Quantity { get; set; }

        public double TotalCost => Cost * Quantity;
    }
}