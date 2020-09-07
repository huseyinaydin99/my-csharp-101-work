using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _026_Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int sayi1, int sayi2);
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.SendMessage();
            customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;

            myDelegate();
            myDelegate -= customerManager.ShowAlert;

            MyDelegate2 myDelegate2 = customerManager.ShowAlert;
            myDelegate2 += customerManager.SendMessage;

            myDelegate2("Hello");

            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Cikar;

            int result = myDelegate3(10,5); //en son verdiğin delege neyse onu geriye döndürür
            Console.WriteLine("sonuc {0}",result);

            customerManager.Show(() =>
            {
                Console.WriteLine("Selamun aleyküm!");
            });

            Func<int, int, int> func = topla;
            int toplam = func(10, 5);
            Console.WriteLine(toplam);

            Func<int> func1 = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            int rnd = func1();
            Console.WriteLine(rnd);

            Thread.Sleep(1000);

            Func<int> getRandomNumber = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber.Invoke());
            Console.ReadKey();
        }

        static int topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }

        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert(string message)
        {
            Console.WriteLine(message);
        }

        public void Show(Action action)
        {
            action.Invoke();
        }
    }

    class Matematik
    {
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
