namespace TaskProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            bool check = true;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Menu");
                Console.WriteLine("1. Mehsul elave et");
                Console.WriteLine("2. Mehsul sil");
                Console.WriteLine("3. Mehsula bax");
                Console.WriteLine("4. Type'a gore mehsullara bax");
                Console.WriteLine("5. Ada gore mehsullara bax");
                Console.WriteLine("0. Proqrami bitdi");
                Console.WriteLine("");

                string choiceStr;
                byte choice;

                do
                {
                    Console.WriteLine("");
                    Console.Write("Sechim edin: ");
                    choiceStr = Console.ReadLine();
                } while (!byte.TryParse(choiceStr, out choice));

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("Mehsul elave et");

                        Console.WriteLine("");
                        Console.Write("Mehsulun adi: ");
                        string productname = Console.ReadLine();

                        string priceStr = "";
                        double productprice;

                        do
                        {
                            Console.Write("Mehsulun qiymeti: ");
                            priceStr = Console.ReadLine();
                        } while (!double.TryParse(priceStr, out productprice));

                        Console.Write("Mehsulun tipi: ");
                        string producttype = Console.ReadLine();

                        string countStr = "";
                        int productcount;

                        do
                        {
                            Console.Write("Mehsulun sayi: ");
                            countStr = Console.ReadLine();
                        } while (!int.TryParse(countStr, out productcount));



                        Product product = new Product(productname, productprice, producttype, productcount);

                        store.AddProduct(product);


                        Console.WriteLine("Mehsul elave olundu");

                        break;

                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("Mehsul sil");

                        Console.WriteLine("");
                        string removeNoStr = "";
                        int removeNo;

                        do
                        {
                            Console.Write("Silmek istediyiniz mehsulun no'su: ");
                            removeNoStr = Console.ReadLine();
                        } while (!int.TryParse(removeNoStr, out removeNo));

                        Product[] removearr = store.RemoveProductByNo(removeNo);

                        for (int i = 0; i < removearr.Length; i++)
                        {
                            removearr[i].ToString();
                        }

                        break;


                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("Mehsula bax");

                        Console.WriteLine("");
                        string showNoStr = "";
                        int showNo;

                        do
                        {
                            Console.Write("Baxmaq istediyiniz mehsullarin no'su: ");
                            showNoStr = Console.ReadLine();
                        } while (!int.TryParse(showNoStr, out showNo));

                        Product[] showarr = store.GetProduct(showNo);

                        for (int i = 0; i < showarr.Length; i++)
                        {
                            showarr[i].ToString();
                        }

                        break;

                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine("Type'a gore mehsullara bax");

                        Console.WriteLine("");
                        Console.Write("Baxmaq istediyiniz mehsullarin type'i: ");
                        string showtype = Console.ReadLine();



                        Product[] typearr = store.FilterProductsByType(showtype);

                        for (int i = 0; i < typearr.Length; i++)
                        {
                            typearr[i].ToString();
                        }
                        break;

                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine("Ada gore mehsullara bax");

                        Console.WriteLine("");
                        Console.Write("Baxmaq istediyiniz mehsullarin adi: ");
                        string showname = Console.ReadLine();

                        Product[] namearr = store.FilterProductsByName(showname);

                        for (int i = 0; i < namearr.Length; i++)
                        {
                            namearr[i].ToString();
                        };
                        break;

                    case 0:
                        Console.WriteLine("");
                        Console.WriteLine("Proqram bitdi");
                        check = false;
                        break;

                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Duzgun sechin edin");
                        break;
                }


            } while (check);
        }
    }
}
