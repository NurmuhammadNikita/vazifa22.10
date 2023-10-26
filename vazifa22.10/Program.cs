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

            #region o'n birinchi

            /* List<int> templist = new List<int>();
             templist.Add(5);
             templist.Add(7);
             templist.Add(13);
             templist.Add(24);
             templist.Add(6);
             templist.Add(9);
             templist.Add(8);
             templist.Add(7);

             foreach (var lstnum in templist)
             {
                 Console.WriteLine(lstnum + " ");
             }

             int n = Convert.ToInt32(Console.ReadLine());

             templist.Sort();
             templist.Reverse();


             foreach (int topn in templist.Take(n))
             {
                 Console.WriteLine(topn);
             }
 */
            #endregion o'n birinchi

            #region o'n ikkinchi misol

            /*string strNew;

            Console.Write("nimadir yozing : ");
            strNew = Console.ReadLine();

            var ucWord = WordFilt(strNew);
            
            foreach (string strRet in ucWord)
            {
                Console.WriteLine(strRet);
            }
            Console.ReadLine();*/
            #endregion

            #region o'n uchinchi misol

            /*string[] arr1;
            int n, i;

            
            Console.Write("arrayga so'z yozing :");
            n = Convert.ToInt32(Console.ReadLine());
            arr1 = new string[n];
            Console.Write("Input {0} strings for the array  :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Element[{0}] : ", i);
                arr1[i] = Console.ReadLine();
            }

            string newstring = String.Join(", ", arr1
                          .Select(s => s.ToString())
                          .ToArray());
           
            Console.WriteLine(newstring);
            Console.WriteLine();
*/


            #endregion

            #region o'n to'rtinchi misol

            /*Students e = new Students();
             // max bal topadi
            int grPointRank = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            var stulist = e.GtStuRec();
            var students = (from stuMast in stulist
                            group stuMast by stuMast.GrPoint into g
                            orderby g.Key descending
                            select new
                            {
                                StuRecord = g.ToList()
                            }).ToList();

            students[grPointRank - 1].StuRecord
                .ForEach(i => Console.WriteLine(" Id : {0},  Name : {1},  achieved Grade Point : {2}", i.StuId, i.StuName, i.GrPoint));

            Console.ReadKey();*/

            #endregion

            #region o'n beshinchi misol

            /*string[] arr1 = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };

            

            Console.Write("\nFayllar : aaa.frx, bbb.TXT, xyz.dbf,abc.pdf");
            Console.Write("\n                aaaa.PDF,xyz.frt, abc.xml, ccc.txt, zzz.txt\n");

            Console.Write("\nFayl kengaytmalari : \n\n");

            var fGrp = arr1.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
                     .GroupBy(z => z, (fExt, extCtr) => new
                     {
                         Extension = fExt,
                         Count = extCtr.Count()
                     });

            foreach (var m in fGrp)
                Console.WriteLine("{0} File(s) with {1} Extension ", m.Count, m.Extension);
            Console.ReadLine();*/

            #endregion

            #region o'n oltinchi misol

            /*string[] dirfiles = Directory.GetFiles("/home/w3r/abcd/");
            // abcd da bor fayllar:
            // abcd.txt, simple_file.txt and xyz.txt
             var avgFsize = dirfiles.Select(file => new FileInfo(file).Length).Average();
            avgFsize = Math.Round(avgFsize / 10, 1);
            Console.WriteLine("The Average file size is {0} MB", avgFsize);
            Console.ReadLine();*/

            #endregion

            #region o'n yettinchi misol

            /* List<string> listOfString = new List<string>();
             listOfString.Add("m");
             listOfString.Add("n");
             listOfString.Add("o");
             listOfString.Add("p");
             listOfString.Add("q");

             var _result1 = from y in listOfString
                            select y;
             Console.WriteLine("\n");
             foreach (var tchar in _result1)
             {
                 Console.WriteLine("Char: {0} ", tchar);
             }

             string newstr = listOfString.FirstOrDefault(en => en == "o");
             listOfString.Remove(newstr);


             var _result = from z in listOfString
                           select z;

             foreach (var rChar in _result)
             {
                 Console.WriteLine("Char: {0} ", rChar);
             }

             Console.ReadLine();*/

            #endregion

            #region o'sakkizinchi misol

            /*List<string> listOfString = new List<string>();
            listOfString.Add("m");
            listOfString.Add("n");
            listOfString.Add("o");
            listOfString.Add("p");
            listOfString.Add("q");


            

            var _result1 = from y in listOfString
                           select y;
            Console.Write("Here is the list of items : \n");
            foreach (var tchar in _result1)
            {
                Console.WriteLine("Char: {0} ", tchar);
            }

            listOfString.Remove(listOfString.FirstOrDefault(en => en == "p"));


            var _result = from z in listOfString
                          select z;
            Console.Write("\nHere is the list after removing the item 'p' from the list : \n");
            foreach (var rChar in _result)
            {
                Console.WriteLine("Char: {0} ", rChar);
            }

            Console.ReadLine();*/

            #endregion

            #region o'nto'qqizinchi misol

            /*List<string> listOfString = new List<string>();
            listOfString.Add("m");
            listOfString.Add("n");
            listOfString.Add("o");
            listOfString.Add("p");
            listOfString.Add("q");


            

            var _result1 = from y in listOfString
                           select y;
            
            foreach (var tchar in _result1)
            {
                Console.WriteLine("Char: {0} ", tchar);
            }

            listOfString.RemoveAll(en => en == "q");


            var _result = from z in listOfString
                          select z;
            Console.WriteLine("\n \n");
            foreach (var rChar in _result)
            {
                Console.WriteLine("Char: {0} ", rChar);
            }

            Console.ReadLine();*/

            #endregion

            #region yigirmanchi misol

            /*List<string> listOfString = new List<string>();
            listOfString.Add("m");
            listOfString.Add("n");
            listOfString.Add("o");
            listOfString.Add("p");
            listOfString.Add("q");


            

            var _result1 = from y in listOfString
                           select y;
            Console.WriteLine("\n");
            foreach (var tchar in _result1)
            {
                Console.WriteLine("Char: {0} ", tchar);
            }

            listOfString.RemoveAt(3);

            var _result = from z in listOfString
                          select z;
            Console.WriteLine("\n");
            foreach (var rChar in _result)
            {
                Console.WriteLine("Char: {0} ", rChar);
            }

            Console.ReadLine();*/

            #endregion

            #region yigirma birinchi misol

            /*List<string> listOfString = new List<string>();
            listOfString.Add("m");
            listOfString.Add("n");
            listOfString.Add("o");
            listOfString.Add("p");
            listOfString.Add("q");


            

            var _result1 = from y in listOfString
                           select y;
            Console.Write("Here is the list of items : \n");
            foreach (var tchar in _result1)
            {
                Console.WriteLine("Char: {0} ", tchar);
            }

            listOfString.RemoveRange(1, 3);

            var _result = from z in listOfString
                          select z;
            Console.WriteLine("\n\n");
            foreach (var rChar in _result)
            {
                Console.WriteLine("Char: {0} ", rChar);
            }

            Console.ReadLine();*/

            #endregion

            #region yigirma ikkinchi misol

            /*string[] arr1;
            int n, i, ctr;

            

           
            n = Convert.ToInt32(Console.ReadLine());
            arr1 = new string[n];
            Console.Write("\narrayga so'z kiriting  :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Element[{0}] : ", i);
                arr1[i] = Console.ReadLine();
            }

            Console.Write("\nTopmoqchi bo'lgan elementning minimal uzunligini kiriting: ");
            ctr = Convert.ToInt32(Console.ReadLine());

            IEnumerable<string> objNew = from m in arr1
                                         where m.Length >= ctr
                                         orderby m
                                         select m;
         
            foreach (string z in objNew)
                Console.WriteLine("Item: {0}", z);

            Console.ReadLine();*/

            #endregion

            #region yigirma uchinchi misol

            char[] charset1 = { 'X', 'Y', 'Z' };
            int[] numset1 = { 1, 2, 3, 4 };

            

            var cartesianProduct = from letterList in charset1
                                   from numberList in numset1
                                   select new { letterList, numberList };

            Console.WriteLine("\n");
            foreach (var productItem in cartesianProduct)
            {
                Console.WriteLine(productItem);
            }
            Console.ReadLine();

            #endregion

            #region yigirma to'rtinchi

            /*char[] set1 = { 'X', 'Y', 'Z' };
            int[] set2 = { 1, 2, 3 };
            string[] set3 = { "Green", "Pink" };

            

            var set12CartesianProduct = set1.SelectMany(
                letterList => set2.Select(numList =>
                new { letterList, numList }));

            var cartesianProduct = set12CartesianProduct.SelectMany(
                (set1and2) => set3.Select(colorList =>
                new { set1and2.letterList, set1and2.numList, colorList }));

            Console.WriteLine("\n");
            foreach (var ProductList in cartesianProduct)
            {
                Console.WriteLine(ProductList);
            }
            Console.ReadLine();*/

            #endregion

            #region yigirma beshinchi misol

            /*List<Item_mast> itemlist = new List<Item_mast>
            {
           new Item_mast { ItemId = 1, ItemDes = "Biscuit  " },
           new Item_mast { ItemId = 2, ItemDes = "Chocolate" },
           new Item_mast { ItemId = 3, ItemDes = "Butter   " },
           new Item_mast { ItemId = 4, ItemDes = "Brade    " },
           new Item_mast { ItemId = 5, ItemDes = "Honey    " }
            };

            List<Purchase> purchlist = new List<Purchase>
            {
           new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 },
           new Purchase { InvNo=101, ItemId = 2,  PurQty = 650 },
           new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },
           new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
           new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },
           new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },
           new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }
            };

            Console.Write("\nLINQ : Generate an Inner Join between two data sets : ");
            Console.Write("\n--------------------------------------------------\n");
            Console.Write("Here is the Item_mast List : ");
            Console.Write("\n-------------------------\n");

            foreach (var item in itemlist)
            {
                Console.WriteLine(
                "Item Id: {0}, Description: {1}",
                item.ItemId,
                item.ItemDes);
            }

            Console.Write("\nHere is the Purchase List : ");
            Console.Write("\n--------------------------\n");

            foreach (var item in purchlist)
            {
                Console.WriteLine(
                "Invoice No: {0}, Item Id : {1},  Quantity : {2}",
                item.InvNo,
                item.ItemId,
                item.PurQty);
            }

            Console.Write("\nHere is the list after joining  : \n\n");

            var innerJoin = from e in itemlist
                            join d in purchlist on e.ItemId equals d.ItemId
                            select new
                            {
                                itid = e.ItemId,
                                itdes = e.ItemDes,
                                prqty = d.PurQty
                            };
            Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var data in innerJoin)
            {
                Console.WriteLine(data.itid + "\t\t" + data.itdes + "\t\t" + data.prqty);
            }
            Console.ReadLine();*/

            #endregion






        }




        static IEnumerable<string> WordFilt(string mystr)
        {
            var upWord = mystr.Split(' ')
                        .Where(x => String.Equals(x, x.ToUpper(),
                        StringComparison.Ordinal));

            return upWord;

        }
    }
}

