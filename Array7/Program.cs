using System;
using System.Collections; //Подключаем коллекции
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array7
{
    class Program
    {
        static void Main(string[] args)
        {
            


            /**************************** Задание 1 *************************************/
            //--------- ArrayList --------- //
            Console.WriteLine("Задание 1");
            ArrayList arr_list = new ArrayList();
            // Применен метод Add()
            arr_list.Add(0.25);
            arr_list.Add(1.15);
            arr_list.Add(0.7);
            arr_list.Add(3.25);
            arr_list.Add(0.15);
            arr_list.Add(7d);
            arr_list.Add(4.85);
            arr_list.Add(0.123456);
            arr_list.Add(9.876);
            arr_list.Add(12.0008);

            arr_list.RemoveAt(1);

            //Использовано свойство Count
            for (int i = 0; i < arr_list.Count; i++)
            {
                Console.WriteLine(arr_list[i]);
            }

            //Применен метод Sort()
            arr_list.Sort();
            for (int i = 0; i < arr_list.Count; i++)
            {
                Console.WriteLine(arr_list[i]);
            }

            //--------------- Queue ------------ //
            Queue que = new Queue();
            que.Enqueue(0.8);
            que.Enqueue(1.3);
            que.Enqueue(2.1);
            que.Enqueue(5.9);
            que.Enqueue(0.13);

            Console.WriteLine(que.Contains(2.1));
            Console.WriteLine(que.Peek());
            que.Dequeue();
            que.Dequeue();
            Console.WriteLine(que.Peek());

            //------------- Hashtable --------------//
            /*
            Dictionary<string, int> a = new Dictionary<string, int>() { { "", 5 }, { "",8} }; //new Dictionary<string, int>();
            a.Add("", 3);
            a.Add("", 5);
            a.Add(" ", 45);
            */

            Hashtable hash = new Hashtable() { {0.1,70.5}, { 0.2, 170.8 }, { 0.3, 0.5 }, { 0.4, 5d } };
            Console.WriteLine(hash[0.3]);
            Console.WriteLine(hash.ContainsKey(0.4));


            /******************************* Задание 2 ************************/
            Console.WriteLine("\n\n\nЗадание 2");
            try
            {
                double a = (double) arr_list[70];
            }
            catch (ArgumentOutOfRangeException a)
            {                
                Console.WriteLine(a.Message);
            }

            try
            {
                int b = 3/((int)(double)arr_list[0]);
            }
            catch (DivideByZeroException a)
            {
                Console.WriteLine(a.Message);
            }

            CheckHash newHash = new CheckHash(hash);
            try
            {
                Console.WriteLine(newHash.inspect(0.7));
            }
            catch (NotExistExcept except)
            {
                Console.WriteLine(except.Message);
            }

            /**************************** Задание 3 *************************************/
            Console.WriteLine("\n\n\nЗадание 3");
            for (int i = 0; i < arr_list.Count; i++)
            {
                Console.WriteLine(arr_list[i]);
            }
            Console.WriteLine("\n\n" + Average.execute(ref arr_list));
            Console.WriteLine("\n\n");
            for (int i = 0; i < arr_list.Count; i++)
            {
                Console.WriteLine(arr_list[i]);
            }

            /**************************** Задание 4 *************************************/
            Console.WriteLine("\n\n\nЗадание 4");
            string brackets_true = "(), (())(), ()(), ((())),";
            string brackets_false = ")(, ())((), (, )))), ((())";
            Console.WriteLine("\n"+ brackets_true);
            Console.WriteLine("\n" + Average.StackVerification(brackets_true));
            Console.WriteLine("\n" + brackets_false);
            Console.WriteLine("\n" + Average.StackVerification(brackets_false));

            /**************************** Задание 5 *************************************/
            Console.WriteLine("\n\n\nЗадание 5 массив");
            Student[] arrSt =
            {
                new Student("Иванов", "Иван", 1, 2,3,4),
                new Student("Петров", "Петр", 2, 5,2,4),
                new Student("Сидоров", "Сидр", 2, 2,3,4),
                new Student("Кукушкина", "Клава", 2, 3,4,4),
                new Student("Петрушкина", "Галина", 1, 5,3,4),
                new Student("Симоненко", "Александр", 2, 2,2,2),
                new Student("Семенов", "Семен", 2, 3,3,3),
                new Student("Вагин", "Аркадий", 2, 3,3,4),
                new Student("Муслимов", "Илларион", 1, 5,2,4),
                new Student("Тувинов", "Турумбай", 2, 3,4,4),
            };

            string badBoy = "";
            double badBoyValue = 10;
            //для каждого студента из массива
            foreach(Student st in arrSt)
            {
                // проверяем второкурсник ли он
                if (st.course == 2)
                {
                    //если да находи его средний бал
                    double averageValue = (st.valueMath+st.valuePhysics+st.valueInf)/3d;
                    // если его бал меньше чем предыдущий худший бал
                    if (averageValue < badBoyValue)
                    {
                        //перезаписываем худший бал и сохраняем его фамилию
                        badBoyValue = averageValue;
                        badBoy = st.familyName;
                    }
                }
            }

            Console.WriteLine("\nХудший студент второго курса: " + badBoy);

            Console.WriteLine("\n\n\nЗадание 5 очередь");
            
            Queue queSt = new Queue();
            
            
            queSt.Enqueue(new Student("Иванов", "Иван", 1, 2, 3, 4));
            queSt.Enqueue(new Student("Петров", "Петр", 2, 5, 2, 4));
            queSt.Enqueue(new Student("Сидоров", "Сидр", 2, 2, 3, 4));
            queSt.Enqueue(new Student("Кукушкина", "Клава", 2, 3, 4, 4));
            queSt.Enqueue(new Student("Петрушкина", "Галина", 1, 5, 3, 4));
            queSt.Enqueue(new Student("Симоненко", "Александр", 2, 2, 2, 2));
            queSt.Enqueue(new Student("Семенов", "Семен", 2, 3, 3, 3));
            queSt.Enqueue(new Student("Вагин", "Аркадий", 2, 3, 3, 4));
            queSt.Enqueue(new Student("Муслимов", "Илларион", 1, 5, 2, 4));
            queSt.Enqueue(new Student("Тувинов", "Турумбай", 2, 3, 4, 4));
            
            
            string queBadBoy = "";
            double queBadBoyValue = 10;
            Student currentItem;
            
            for (int i = queSt.Count;i>0;i--)
            {
                currentItem = (Student)queSt.Dequeue();
                if (currentItem.course == 2)
                {                    
                    double averageValue = (currentItem.valueMath + currentItem.valuePhysics + currentItem.valueInf) / 3d;
                    
                    if (averageValue < queBadBoyValue)
                    {
                        queBadBoyValue = averageValue;
                        queBadBoy = currentItem.familyName;
                        
                    }
                }
                queSt.Enqueue(currentItem);
            }
            Console.WriteLine("\nХудший студент второго курса: " + queBadBoy);

            return;
        }
    }
}
