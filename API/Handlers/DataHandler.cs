namespace API.Handlers
{
  public class DataHandler
  {
    private int? phoneNumber;
    private int? firstKmCost;
    private int? secondKmCost;

    public DataHandler()
    {
      phoneNumber = 88888888;
      firstKmCost = 1000;
      secondKmCost = 1000;
    }

    public string GetData()
    {
      string data = @"{""phoneNumber"": " + phoneNumber.ToString() + @", ""firstKmCost"": " + firstKmCost.ToString() + @", ""secondKmCost"": " + secondKmCost.ToString() + "}";
      return data;
    }

    public void SetData(int? phoneNumber, int? firstKmCost, int? secondKmCost)
    {
      this.phoneNumber = phoneNumber;
      this.firstKmCost = firstKmCost;
      this.secondKmCost = secondKmCost;
    }
  }
}
