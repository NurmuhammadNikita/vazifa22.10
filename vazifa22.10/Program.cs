namespace vazifa22._10
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region birinchi misol

            /*int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            

            var nQuery =
                from VrNum in n1
                where (VrNum % 2) == 0
                select VrNum;


            
            foreach (int VrNum in nQuery)
            {
                Console.Write("{0} ", VrNum);
            }
            Console.Write("\n\n");*/

            #endregion

            #region ikkinchi misol

            int[] n1 = {
                1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14
            };

           

            var nQuery =
            from VrNum in n1
            where VrNum > 0
            where VrNum < 12
            select VrNum;
 
            foreach (var VrNum in nQuery)
            {
                Console.Write("{0}  ", VrNum);
            }
            Console.Write("\n\n");

            #endregion

            #region uchinchi misol

            /*var arr1 = new[] { 3, 9, 2, 8, 6, 5 };

            

            var sqNo = from int Number in arr1
                       let SqrNo = Number * Number
                       where SqrNo > 20
                       select new { Number, SqrNo };

            foreach (var a in sqNo)
                Console.WriteLine(a);*/

            #endregion

            #region to'rtinchi misol

            /*int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
           
            Console.Write(" 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2\n");

            var n = from x in arr1
                    group x by x into y
                    select y;
            Console.WriteLine("\n \n");
            foreach (var arrNo in n)
            {
                Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
            }
            Console.WriteLine("\n");
*/
            #endregion

            #region behsinchi misol

            /* string str;

             Console.Write("Ustoz so'z kiriting : ");
             str = Console.ReadLine();
             Console.Write("\n");

             var FreQ = from x in str
                        group x by x into y
                        select y;
             Console.WriteLine("\n");
             foreach (var ArrEle in FreQ)
             {
                 Console.WriteLine("Character " + ArrEle.Key + ": " + ArrEle.Count() + " times");
             }*/

            #endregion

            #region oltinchi misol

            /*string[] dayWeek = { "Yakshanba", "Dushanba", "Seshanba", "Chorshanba", "Payshanba", "Juma", "Shanba" };

            var days = from WeekDay in dayWeek
                       select WeekDay;
            foreach (var WeekDay in days)
            {
                Console.WriteLine(WeekDay);
            }
            Console.WriteLine();*/

            #endregion

            #region yettinchi misol

            /*int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            Console.WriteLine("\n");
            
            Console.Write("  5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 \n\n");


            var m = from x in nums
                    group x by x into y
                    select y;
            Console.WriteLine("Number" + "\t" + "Number*Frequency" + "\t" + "Frequency");
            

            foreach (var arrEle in m)
            {
                Console.WriteLine(arrEle.Key + "\t" + arrEle.Sum() + "\t\t\t" + arrEle.Count());
            }
            Console.WriteLine();*/

            #endregion

            #region sakkizinchi misol

            // shuni tushunmadim

            /*string chst, chen;
            char ch;
            string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };

            Console.Write("\nLINQ : Find the string which starts and ends with a specific character : ");
            Console.Write("\n-----------------------------------------------------------------------\n");
            Console.Write("\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS' \n");

            Console.Write("\nInput starting character for the string : ");
            ch = (char)Console.Read();
            chst = ch.ToString();
            Console.Write("\nInput ending character for the string : ");
            ch = (char)Console.Read();
            chen = ch.ToString();


            var _result = from x in cities
                          where x.StartsWith(chst)
                          where x.EndsWith(chen)
                          select x;
            Console.Write("\n\n");
            foreach (var city in _result)
            {
                Console.Write("The city starting with {0} and ending with {1} is : {2} \n", chst, chen, city);
            }

            Console.ReadLine();
        }*/

            #endregion

            #region to'qqizinchi misol

            /*int i = 0;
            List<int> templist = new List<int>();
            templist.Add(55);
            templist.Add(200);
            templist.Add(740);
            templist.Add(76);
            templist.Add(230);
            templist.Add(482);
            templist.Add(95);

            
            Console.WriteLine("\nThe members of the list are : ");
            foreach (var lstnum in templist)
            {
                Console.Write(lstnum + " ");
            }
            List<int> FilterList = templist.FindAll(x => x > 80 ? true : false);
            Console.WriteLine("\n\nThe numbers greater than 80 are : ");
            foreach (var num in FilterList)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();*/

            #endregion

            #region o'ninchi misol

            /*int i = 0;
            int memlist, n, m;
            List<int> templist = new List<int>();
            Console.Write("\nLINQ : Accept the members of a list and display the members more than a specific value : ");
            Console.Write("\n----------------------------------------------------------------------------------------\n");

            Console.Write("Input the number of members on the List : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("Member {0} : ", i);
                memlist = Convert.ToInt32(Console.ReadLine());
                templist.Add(memlist);
            }

            Console.Write("\nInput the value above you want to display the members of the List : ");
            m = Convert.ToInt32(Console.ReadLine());

            List<int> FilterList = templist.FindAll(x => x > m ? true : false);
            Console.WriteLine("\nThe numbers greater than {0} are : ", m);
            foreach (var num in FilterList)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();*/

            #endregion


        }
    }
}
