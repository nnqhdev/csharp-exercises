using System;
using System.Collections;
using System.Data.SqlTypes;

namespace HungCode
{
    //class Bai1
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Input your name");
    //        string YourName = Console.ReadLine();
    //        Console.WriteLine("Hello, {0}!", YourName);
    //    }
    //}

    //class Bai2
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Input stringNumber");
    //        string stringNumber = Console.ReadLine() ;
    //        Console.WriteLine("\"stringNumber\" value & type:");
    //        Console.WriteLine("{0}, {1}",stringNumber,stringNumber.GetType());


    //        int intNumber = int.Parse(stringNumber);
    //        Console.WriteLine("\"intNumber\" value & type:");
    //        Console.WriteLine("{0}, {1}", intNumber, intNumber.GetType());
    //        Console.ReadKey();
    //    }
    //}




    //class Bai3
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("input a: ");
    //        int a = Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine("input b: ");
    //        int b = Convert.ToInt32(Console.ReadLine());

    //        Console.WriteLine("{0} + {1} ={2}",a,b,a+b);
    //        Console.WriteLine("{0} + {1} ={2}", a, b, a - b);
    //        Console.WriteLine("{0} + {1} ={2}", a, b, a * b);
    //        Console.WriteLine("{0} + {1} ={2}", a, b, a / b);
    //        Console.WriteLine("{0} + {1} ={2}", a, b, a % b);

    //    }

    //}


    //class Bai4
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("input a");
    //        double a = Convert.ToDouble(Console.ReadLine());
    //        Console.WriteLine("input b");
    //        double b = Convert.ToDouble(Console.ReadLine());
    //        Console.WriteLine("Before swapping: \n a = {0}, b = {1}", a, b);

    //        double c = a;
    //        a = b;
    //        b = c;
    //        Console.WriteLine("After swapping: \n a = {0}, b = {1}", a, b);
    //    }

    //}







    //class Bai5
    //{
    //    static void Main(string[] args)
    //
    //   {
    //        Console.WriteLine("input r: ");
    //        double r = Convert.ToDouble(Console.ReadLine());

    //        double P = 2 * r * Math.PI;
    //        double A = Math.PI * Math.Pow(r, 2);
    //        Console.WriteLine("P = {0}, A = {1}", Math.Round(P,2), Math.Round(A, 2));



    //    }

    //}



    //class Bai6
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("input 1<=n<=10: ");
    //        int n = Convert.ToInt32(Console.ReadLine());
    //        if (1 <= n && n <= 10)
    //        {
    //            for (int i = 1; i < 11; i++)
    //            {
    //                int KetQua = n * i;
    //                Console.WriteLine("{0,2} x {1,2} = {2,2}", n, i, KetQua);  //{1,2} 2 là canh lề phải, -2 là canh lề trái
    //            }

    //        }
    //        else
    //        {
    //            Console.WriteLine("Nhap sai yeu cau");
    //        }

    //    }
    //}





    //class Bai7
    //{
    //    static void Main(string[] args)
    //    {

    //        Console.Write("Working hours: ");
    //        double WorkingHours = Convert.ToDouble(Console.ReadLine());
    //        Console.Write("Unit price: ");
    //        int UnitPrice = Convert.ToInt32(Console.ReadLine());


    //        double LuongThang = WorkingHours * UnitPrice;
    //        Console.WriteLine("Oy Salary: {0}", LuongThang);

    //    }
    //}





    //class Bai8
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Input Money: ");
    //        int Money = Convert.ToInt32(Console.ReadLine());

    //        int Money100, Money50, Money20, Money10, Money5, Money2, Money1;

    //        Money100 = Money / 100;
    //        Money = Money% 100;
    //        Console.WriteLine("100 : {0}", Money100);

    //        Money50 = Money / 50;
    //        Money = Money % 50;
    //        Console.WriteLine("50 : {0}", Money50);

    //        Money20 = Money / 20;
    //        Money = Money % 20;
    //        Console.WriteLine("20 : {0}", Money20);

    //        Money10 = Money / 10;
    //        Money = Money % 10;
    //        Console.WriteLine("10 : {0}", Money10);

    //        Money5 = Money / 5;
    //        Money = Money % 5;
    //        Console.WriteLine("5 : {0}", Money5);

    //        Money2 = Money / 2;
    //        Money = Money % 2;
    //        Console.WriteLine("2 : {0}", Money2);

    //        Money1 = Money / 1;
    //        Money = Money % 1;
    //        Console.WriteLine("1 : {0}", Money1);



    //class Bai9
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Imput Time");
    //        int Time = Convert.ToInt32(Console.ReadLine());
    //        int Hours = Time / 3600;
    //        Time = Time % 3600;

    //        int Min = Time / 60;
    //        int Sec = Time % 60;
    //        Console.WriteLine("{0} : {1} : {2}", Hours, Min, Sec);
    //    }


    //class Bai10
    //{
    //    static void Main(string[] args)
    //    {





    //    }

    //}



    //class Buoi2Bai1
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("input so nguyen n: ");
    //        int SoNguyen = Convert.ToInt32(Console.ReadLine());
    //        int SoNguyen1 = SoNguyen * -1;

    //        if (SoNguyen1 < 0)
    //        {
    //            int SoNguyen2 = SoNguyen1 % 2;
    //            if (SoNguyen2 == 0)
    //            {
    //                Console.WriteLine("So {0} la so duong, va la la so chan", SoNguyen);
    //            }
    //            else
    //            {
    //                Console.WriteLine("So {0} la so duong, va la la so le", SoNguyen);
    //            }
    //        }
    //        else
    //        {
    //            int SoNguyen2 = SoNguyen1 % 2;
    //            if (SoNguyen2 == 0)
    //            {
    //                Console.WriteLine("So {0} la so am, va la la so chan", SoNguyen);
    //            }
    //            else
    //            {
    //                Console.WriteLine("So {0} la so am, va la la so le", SoNguyen);
    //            }
    //        }
    //    }
    //}



    //class Buoi2Bai2
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Nhap gia tri a: ");
    //        int a = Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine("Nhap gia tri b: ");
    //        int b = Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine("Nhap gia tri c: ");
    //        int c = Convert.ToInt32(Console.ReadLine());

    //        if (a == 0)
    //        {
    //            switch (b)
    //            {
    //                case 0:
    //                    Console.WriteLine();
    //                    if (c == 0)
    //                    {
    //                        Console.WriteLine("Phuong trinh vo so nghiem");
    //                    }
    //                    else { Console.WriteLine("Phuong trinh vo nghiem"); }
    //                    break;
    //                default:
    //                    Console.WriteLine("x = {0}",(double) -c / b);
    //                    break;
    //            }
    //        }
    //        else
    //        {
    //            double denlta = Math.Pow(b, 2) - 4 * a * c;
    //            switch (denlta)
    //            {
    //                case 0:
    //                    double x = -b / (2.0 * a);
    //                    Console.WriteLine("phuong trinh co nghiem kep {0} ", x) ;
    //                    break;
    //                case < 0 : Console.WriteLine("Phuong trinh vo nghiem");
    //                    break;
    //                case > 0: 
    //                    double x1 = (-b + Math.Sqrt(denlta)) / (2 * a);
    //                    double x2 = (-b - Math.Sqrt(denlta)) / (2 * a);
    //                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet x = {0}, x = {1}",x1,x2);
    //                    break;

    //            }
    //        }

}



//class Buoi2Bai23 {
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap so a: ");
//        int a = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Nhap so b: ");
//        int b = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Nhap so c: ");
//        int c = Convert.ToInt32(Console.ReadLine());

//        if (a > b)
//        {
//            if (a > c)
//            {
//                Console.WriteLine("So lon nhat la so: {0}", a);
//            }
//            else
//            {
//                if (b > c)
//                {
//                    Console.WriteLine("So lon nhat la so: {0}", b);
//                }q
//                else
//                {
//                    Console.WriteLine("So lon nhat la so: {0}", c);
//                }
//            }
//        }
//        else
//        {
//            if (b > c)
//            {
//                Console.WriteLine("So lon nhat la so: {0}", b);
//            }
//            else
//            {
//                Console.WriteLine("So lon nhat la so: {0}", c);
//            }
//        }
//    }
//}


//class Buoi2Bai4
//{
//    static void Main(string[] args)
//    {
//        {
//            Console.WriteLine("Nhap so a: ");
//            int a = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Nhap so b: ");
//            int b = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Nhap so c: ");
//            int c = Convert.ToInt32(Console.ReadLine());

//            int tam;
//            if (a > b) { tam = a; a = b; b = tam; }
//            if (a > c) { tam = a; a = c; c = tam; }
//            if (b > c) { tam = b; b = c; c = tam; }


//            Console.WriteLine("Xap xep theo tang dan: {0},{1},{2}", a, b, c);
//        }
//    }
//}




//class Buoi2Bai5
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap so a: ");
//        int a = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Nhap so b: ");
//        int b = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Nhap so c: ");
//        int c = Convert.ToInt32(Console.ReadLine());

//        if (a + b > c && a + c > b && c + b > a)
//        {
//            Console.WriteLine("Ba so thoa man dieu kien tam giac");
//            int P = a + b + c;
//            Console.WriteLine("Chu vi hinh tam giac la {0}", P);

//        }
//        else
//        {
//            Console.WriteLine("Ba so khong thoa man dieu kien tam giac");
//            int DienTich = ((a + b * c) / 2);
//            Console.WriteLine("Dien tich hinh thang la {0}", DienTich);
//        }
//    }
//}


//class Buoi2Bai6
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("nhap so nguyen [0,12]");
//        int months = Convert.ToInt32(Console.ReadLine());

//        if (months <= 12 && months >= 1)
//        {
//            switch (months)
//            {
//                case 1:
//                    Console.WriteLine("January")
//                    ;
//                    break;
//                case 2:
//                    Console.WriteLine("February")
//                    ;
//                    break;
//                case 3:
//                    Console.WriteLine("March")
//                    ;
//                    break;
//                case 4:
//                    Console.WriteLine("April")
//                    ;
//                    break;
//                case 5:
//                    Console.WriteLine("May")
//                    ;
//                    break;
//                case 6:
//                    Console.WriteLine("June")
//                    ;
//                    break;
//                case 7:
//                    Console.WriteLine("July")
//                    ;
//                    break;
//                case 8:
//                    Console.WriteLine("August")
//                    ;
//                    break;
//                case 9:
//                    Console.WriteLine("September")
//                    ;
//                    break;
//                case 10:
//                    Console.WriteLine("October")
//                    ;
//                    break;
//                case 11:
//                    Console.WriteLine("November")
//                    ;
//                    break;
//                case 12:
//                    Console.WriteLine("December")
//                    ;
//                    break;
//            }
//        }
//        else
//        {
//            Console.WriteLine("So thang khong hop le");
//        }
//    }

//    }


//class Buoi2Bai7
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("nhap a: ");
//        int a = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("nhap b: ");
//        int b = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("nhap phep tinh: ");
//        char c = Convert.ToChar(Console.ReadLine());

//        switch (c)
//        {
//            case '+':
//                Console.WriteLine("Ket qua la: {0}", a + b);
//                break;
//            case '-':
//                Console.WriteLine("Ket qua la: {0}", a - b);
//                break;
//            case '*':
//                Console.WriteLine("Ket qua la: {0}", a * b);
//                break;
//            case '/':
//                Console.WriteLine("Ket qua la: {0}", a / b);
//                break;
//            case '%':
//                Console.WriteLine("Ket qua la: {0}", a % b);
//                break;

//        }
//    }
//}





//class Buoi2Bai8
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("nhap so thuc doan [0,100]: ");
//        double x = Convert.ToDouble(Console.ReadLine());
//        if (x <= 100 && x >= 0)
//        {
//            switch (x)
//            {
//                case <= 25:
//                    Console.WriteLine("{0} Thuoc Doan [0,25]", x);
//                    break;
//                case <= 50:
//                    Console.WriteLine("{0} Thuoc Doan [25,50]", x);
//                    break;
//                case <= 75:
//                    Console.WriteLine("{0} Thuoc Doan [50,75]", x);
//                    break;
//                case <= 100:
//                    Console.WriteLine("{0} Thuoc Doan [75,100]", x);
//                    break;
//            }
//        }
//        else { Console.WriteLine("Nhap sai y/c"); }
//    }
//}




//class buoi2bai9
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap ma san pham: ");
//        int Code = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Nhap ma so luong: ");
//        double SoLuong = Convert.ToInt32(Console.ReadLine());
//        double CochorroQuente = 4.00;
//        double XSalada = 4.50;
//        double XBacon = 5.00;
//        double Torradasimples = 2.00;
//        double Refrigerante = 1.00;
//        double Tien;
//        switch (Code)
//        {
//            case 1:
//                Tien = SoLuong * CochorroQuente;
//                Console.WriteLine("{0,-16}|{1,8}|{2,10}|{3,12}", "PRODUCT NAME", "PRICE", "QUANTITY", "TOTAL(R$)");
//                Console.WriteLine("{0,-16}|{1,8:F2}|{2,10}|{3,12:F2}", "CachorroQuente", CochorroQuente, SoLuong, Tien);
//                break;
//            case 2:
//                Tien = SoLuong * XSalada;
//                Console.WriteLine("{0,-16}|{1,8}|{2,10}|{3,12}", "PRODUCT NAME", "PRICE", "QUANTITY", "TOTAL(R$)");
//                Console.WriteLine("{0,-16}|{1,8:F2}|{2,10}|{3,12:F2}", "XSalada", XSalada, SoLuong, Tien);
//                break;
//            case 3:
//                Tien = SoLuong * XBacon;
//                Console.WriteLine("{0,-16}|{1,8}|{2,10}|{3,12}", "PRODUCT NAME", "PRICE", "QUANTITY", "TOTAL(R$)");
//                Console.WriteLine("{0,-16}|{1,8:F2}|{2,10}|{3,12:F2}", "XBacon", XBacon, SoLuong, Tien);
//                break;
//            case 4:
//                Tien = SoLuong * Torradasimples;
//                Console.WriteLine("{0,-16}|{1,8}|{2,10}|{3,12}", "PRODUCT NAME", "PRICE", "QUANTITY", "TOTAL(R$)");
//                Console.WriteLine("{0,-16}|{1,8:F2}|{2,10}|{3,12:F2}", "TorradaSimples", Torradasimples, SoLuong, Tien);
//                break;
//            case 5:
//                Tien = SoLuong * Refrigerante;
//                Console.WriteLine("{0,-16}|{1,8}|{2,10}|{3,12}", "PRODUCT NAME", "PRICE", "QUANTITY", "TOTAL(R$)");
//                Console.WriteLine("{0,-16}|{1,8:F2}|{2,10}|{3,12:F2}", "Refrigerante", Refrigerante, SoLuong, Tien);
//                break;
//            default:
//                Console.WriteLine("Ma san pham khong hop le");
//                break;
//        }
//    }
//}





//class buoi2bai10
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap Luong Hien Tai: ");
//        double TienLuong = Convert.ToDouble(Console.ReadLine());

//        switch (TienLuong)
//        {
//            case < 400.000:
//                Console.WriteLine("Luong Moi Cua Ban La {0}", ((TienLuong) * 0.15 + TienLuong));
//                break;
//            case < 800.000:
//                Console.WriteLine("Luong Moi Cua Ban La {0}", ((TienLuong) * 0.12 + TienLuong));
//                break;
//            case < 1200.000:
//                Console.WriteLine("Luong Moi Cua Ban La {0}", ((TienLuong) * 0.10 + TienLuong));
//                break;

//            case < 2000.000:
//                Console.WriteLine("Luong Moi Cua Ban La {0}", ((TienLuong) * 0.07 + TienLuong));
//                break;

//            case > 2000.000:
//                Console.WriteLine("Luong Moi Cua Ban La {0}", ((TienLuong) * 0.04 + TienLuong));
//                break;


//        }

//    }
//}




//class buoi2bai11
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap x: ");
//        double x = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("Nhap y: ");
//        double y = Convert.ToDouble(Console.ReadLine());


//        if (x == 0)
//        {
//            if (y == 0)
//            {
//                Console.WriteLine("Goc toa do");
//            }
//            else
//            {
//                if (y > 0)
//                {
//                    Console.WriteLine("Truc Oy");
//                }
//                else
//                {
//                    Console.WriteLine("Truc Oy");
//                }

//            }
//        }
//        else
//        {
//            if (x > 0)
//            {
//                if (y == 0)
//                {
//                    Console.WriteLine("Truc Ox");
//                }
//                else
//                {
//                    if (y > 0)
//                    {
//                        Console.WriteLine("Thuoc Q1");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Thuoc Q4 ");
//                    }
//                }
//            }
//            else
//            {
//                if (y == 0)
//                {
//                    Console.WriteLine("Truc Ox");
//                }
//                else
//                {
//                    if (y > 0)
//                    {
//                        Console.WriteLine("Thuoc Q2");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Thuoc Q3 ");

//                    }
//                }
//            }
//        }
//    }
//}


