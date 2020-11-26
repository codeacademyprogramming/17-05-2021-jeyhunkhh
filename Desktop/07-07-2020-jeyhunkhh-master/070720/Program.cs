using System;
using System.Collections;
using System.Collections.Generic;

namespace _070720
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arrayList = new ArrayList();
            //// Insert
            //arrayList.Add(12); // single item push to end
            ////arrayList.AddRange() // multi item push to end
            //arrayList.Insert(0, 14); // single item push to index
            //arrayList.InsertRange() // multi item pusht to index

            // Search
            //arrayList.Contains(12); // bool
            //arrayList.IndexOf(12); // int->index -1
            //arrayList.LastIndexOf(12); // int->index -1

            // Remove
            //arrayList.Remove(12); // remove by value
            //arrayList.RemoveAt(1); // remove by index
            //arrayList.RemoveRange(1, 3); // remove by range
            //arrayList.Clear(); // remove all items

            // Others
            //arrayList.Count
            //arrayList.Sort();
            //arrayList.Reverse();
            //arrayList.CopyTo()

            //Hashtable examResults = new Hashtable();
            //examResults.Add("C#", 70);
            //examResults.Add("Asp.net", 80);

            ////examResults.ContainsKey("C#");
            ////examResults.ContainsValue("80");
            ////examResults.Remove("C#");

            //foreach (var item in examResults.Keys)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine(examResults[item]);
            //}

            //SortedList students = new SortedList();

            //students.Add("1", "Saleh");
            //students.Add("2", "Gabil");
            //students.Add("4", "Vusal");
            //students.Add("3", "Aytac");

            ////foreach (var item in students.Keys)
            ////{
            ////    Console.WriteLine(item + ":" + students[item]);
            ////}

            //students.TrimToSize();

            //Console.WriteLine(students.Capacity);
            //Console.WriteLine(students.Count);

            //Queue novbe = new Queue();

            //novbe.Enqueue("Saleh");
            //novbe.Enqueue("Gabil");
            //novbe.Enqueue("Aytac");

            //foreach (var item in novbe)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("===========================");

            //Console.WriteLine(novbe.Dequeue()+" xidmet aldi");

            //foreach (var item in novbe)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("===========================");

            //Console.WriteLine(novbe.Dequeue() + " xidmet aldi");
            //novbe.Enqueue("Vusal");

            //foreach (var item in novbe)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(novbe.Dequeue() + " xidmet aldi");
            //Console.WriteLine(novbe.Dequeue() + " xidmet aldi");
            //Console.WriteLine(novbe.Count);

            //Stack stack = new Stack();

            //stack.Push("Saleh");
            //stack.Push("Gabil");
            //stack.Push("Aytac");

            //stack.Pop();
            //stack.Push("Vusal");
            //stack.Pop();

            //Console.WriteLine(stack.Peek());

            //MyArray<int> ages = new MyArray<int>();
            //ages.Add(12);
            //ages.Add(14);

            //Console.WriteLine(ages.Get(0));

            //MyArray<string> names = new MyArray<string>();

            //names.Add("Saleh");
            //names.Add("Gabil");

            //Console.WriteLine(names.Get(0));

            List<int> firstClass = new List<int>
            {
                41,
                12
            };

            List<int> ages = new List<int>();

            // Insert
            ages.Add(12);// last item added
            ages.Insert(1, 15); // insert by index
            ages.AddRange(firstClass); // add items to end
            //ages.InsertRange(1, firstClass); // insert items by index

            // Remove
            //ages.Clear(); // remove all items
            //ages.Remove(12); // remove by value first match
            //ages.RemoveAt(2); // remove by index
            //ages.RemoveRange(2, 3); // remove by index and count
            //ages.RemoveAll(a => a < 20);
            //for (int i = 0; i < ages.Count; i++)
            //{
            //    var a = ages[i];
            //    if (a == 12)
            //    {
            //        ages.RemoveAt(i);
            //    }
            //}

            // Search
            //ages.Contains(12);
            //ages.IndexOf(12);
            //ages.LastIndexOf(12);
            //ages.Exists(a => a > 50);
            //ages.Find(a => a > 12); // first match value
            //List<int> over12 = ages.FindAll(a => a > 12); // all match value
            //ages.FindIndex(a => a > 12); // first match index


            // Others
            //ages.Sort();
            //ages.Reverse();
            //ages.Count;

            ages[0] = 21;
            List<int> partOfAges = ages.GetRange(1, 2);

            //Console.WriteLine(ages[1]);
            Console.WriteLine("===============================");
           

            foreach (var item in partOfAges)
            {
                Console.WriteLine(item);
            }


            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "Saleh", Surname = "Haciyev" });
            students.Add(new Student { Name = "Aytac", Surname = "Zulfugarova" });

            foreach (Student student in students)
            {
                Console.WriteLine(student.Name + " " + student.Surname);
            }
        }
    }
}
