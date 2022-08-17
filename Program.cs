namespace JsonExample
{
    class Program
    {
        public static void Main(String[] args)
        {
            String path = "C:\\Users\\HP\\RFP.NET\\JsonExample\\JsonExample\\StockInventry.json";
            //FetchJsonOfStock fetchJsonOf = new FetchJsonOfStock();

            FetchJsonOfStock fetchJsonOfStock = new FetchJsonOfStock();

            Stock inventory = fetchJsonOfStock.Read(path);

            for (int i = 0; i < inventory.banking.Count; i++)
            {

                Console.WriteLine(inventory.banking[i].stockName);
                Console.WriteLine(inventory.banking[i].numberOfShares);
                Console.WriteLine(inventory.banking[i].price);

                int value = inventory.banking[i].numberOfShares * inventory.banking[i].price;
                Console.WriteLine("The price of {0} for {1}kg is: {2}", inventory.banking[i].stockName, inventory.banking[i].numberOfShares, inventory.banking[i].price);
                Console.WriteLine("--------------------------");
            }
        }   
    }
}