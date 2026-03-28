namespace Ass12;

class Program
{
    public static void Main()
    {
        var letter1 = new Letter("523535", 0.23);
        var letter2 = new Letter("455132", 0.15);
        
        var parcel1 = new Parcel("234344", 6.8, "3x12x1");
        var parcel2 = new Parcel("786967", 12.2, "6x13x6");

        letter1.PrintInfo();
        parcel1.PrintInfo();

        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
        myCargo.AddItem(letter1);
        myCargo.AddItem(letter2);
        myCargo.AddItem(parcel1);
        myCargo.AddItem(parcel2);

        Console.WriteLine(myCargo.GetTotalCost());
    }
}