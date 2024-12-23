

namespace FacadePattern.SubSystems
{
    internal class ShippingSystem
    {
        public void ShipProduct(string productId) => Console.WriteLine($"Shipping product: {productId}");
    }
}
