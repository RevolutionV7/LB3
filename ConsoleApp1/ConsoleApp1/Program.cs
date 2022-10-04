using System;
namespace Invoice
{
    class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;
        public Invoice(int Account, string Customer, string Provider)
        {
            this.account = Account;
            this.customer = Customer;
            this.provider = Provider;
        }

        public string Article { get; set; }
        public int Quantity { get; set; }


        public double Price()
        {
            double price = 680;
            double sum = 0;
            if (Quantity > (account / price))
            {
                Console.WriteLine("У вас недостатньо грошей на рахунку!");
            }
            else if (Article == "так" )
            {
                double tax = 1.2;
                sum = (price * Quantity) * tax;
                Console.WriteLine($"Ціна з ПДВ = {sum}.");
            }
            else if (Article == "ні")
            {
                sum = (price * Quantity);
                Console.WriteLine($"Ціна без ПДВ = {sum}.");
            }

            return sum;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ви бажаєте отримати розрахунок з врахуванням ПДВ?");
            Console.WriteLine("Так чи нi? ");
          
            Invoice invoice = new Invoice(37550, "Cосновський Дмитро", "Prom.ua");
            string article = Console.ReadLine();
            invoice.Article = article;

            Console.Write("Введiть кiлькiсть товару: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            invoice.Quantity = quantity;

            invoice.Price();
            Console.ReadKey();
        }
    }
}