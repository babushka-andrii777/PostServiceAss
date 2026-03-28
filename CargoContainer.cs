namespace Ass12;

class CargoContainer<T> where T : DeliveryItem
{
    private List<T> _itemList = new ();

    public void AddItem(T item)
    {
        _itemList.Add(item);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach(T item in _itemList)
        {
            totalCost += item.CalculateCost();
        }
        return totalCost;
    }
}