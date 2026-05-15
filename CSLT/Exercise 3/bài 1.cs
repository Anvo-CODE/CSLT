using System;
namespace bai1
{
    public partial class Program

    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("nhập 2 số: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(" nhập phép toán (+, -, *, /): ");
            String c = Console.ReadLine();
            if (c == "+")
            {
                Console.WriteLine("kết quả: " + (a + b));
            }
            else if (c == "-")
            {
                Console.WriteLine("kết quả: " + (a - b));
            }
            else if (c == "*")
            {
                Console.WriteLine("kết quả: " + (a * b));
            }
            else if (c == "/")
            {
                if (b != 0)
                {
                    Console.WriteLine("kết quả: " + (a / b));
                }
                else
                {
                    Console.WriteLine("Lỗi: Không thể chia cho 0.");
                }
            }
            else
            {
                Console.WriteLine("Phép toán không hợp lệ.");
            }




            //Bài 2
            Console.WriteLine("Giá trị của hàm x = y^2 + 2y + 1");
            for (int y = -5; y <= 5; y++)
            {
                int x = (y * y) + (2 * y) + 1;
                Console.WriteLine($"y = {y}, x = {x}");
            }


            //bài 3
            Console.Write("Nhập quãng đường (km): ");
            double distanceKm = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập giờ: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập phút: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập giây: ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            double timeHours = hours + (minutes / 60.0) + (seconds / 3600.0);

            double speedKmH = distanceKm / timeHours;
            double speedMilesH = speedKmH / 1.609;

            Console.WriteLine($"Tốc độ: {speedKmH:F2} km/h");
            Console.WriteLine($"Tốc độ: {speedMilesH:F2} miles/h");



            //bài 4
            Console.Write("Nhập bán kính hình cầu: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double surface = 4 * Math.PI * r * r;
            double volume = (4.0 / 3.0) * Math.PI * r * r * r;

            Console.WriteLine($"Diện tích mặt cầu: {surface:F2}");
            Console.WriteLine($"Thể tích hình cầu: {volume:F2}");





            //bài 5
            Console.Write("Nhập một ký tự: ");
            char ch = Convert.ToChar(Console.ReadLine());

            if ("aeiouAEIOU".IndexOf(ch) >= 0)
            {
                Console.WriteLine("Đây là nguyên âm.");
            }
            else if (Char.IsDigit(ch))
            {
                Console.WriteLine("Đây là chữ số.");
            }
            else
            {
                Console.WriteLine("Đây là ký hiệu khác.");
            }


            //bài 6
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.Write("nhập độ dài cạnh A: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("nhập độ dài cạnh B: ");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.Write("nhập độ dài cạnh C: ");
                int l = Convert.ToInt32(Console.ReadLine());
                if (n + m > l && n + l > m && m + l > n)
                {
                    if (n == m && m == l)
                    {
                        Console.WriteLine("Đây là tam giác đều.");
                    }
                    else if (n == m || n == l || m == l)
                    {
                        Console.WriteLine("đây là tam giác cân.");
                    }
                    else
                    {
                        Console.WriteLine("đây là tam giác thường.");
                    }
                }
                else
                {
                    Console.WriteLine("Đây không phải là tam giác.");
                }
            }


            //bài 7
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                int sum = 0;
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("nhập số:");
                    int num = Convert.ToInt32(Console.ReadLine());
                    sum += num;
                }
                Console.WriteLine("tổng của 10 số là " + sum);
                Console.WriteLine("giá trị trung bình là " + (sum / 10.0));
            }


            //bài 8
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("nhập cửu chương:");
                int cuuchuong = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("kết quả cửu chương:" + cuuchuong * i);
                }
            }



            //bài 9 

            {
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }
            }
            {
                int num = 1;
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(num + " ");
                        num++;
                    }
                    Console.WriteLine();
                }
            }
            {
                int num2 = 1;
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(num2 + " ");
                        num2++;
                    }
                    Console.WriteLine();
                }
            }

            //bài 10
            {
                Console.WriteLine("nhap so n: ");
                int n = Convert.ToInt32(Console.ReadLine());
                double sum = 0.0;
                Console.WriteLine("day dieu hoa: ");
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("1/" + i + "+");
                    sum += 1.0 / i;
                }
                Console.WriteLine("\n tong cua day = " + sum);
            }


            //bài 11

            {
                Console.WriteLine("nhap so n: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("cac so hoan hao tu 1 den" + n + ".");
                for (int num = 0; num < n; num++)
                {
                    int sum = 0;
                    for (int i = 1; i <= num / 2; i++)
                    {
                        if (num % i == 0)
                        {
                            sum += i;
                        }
                    }
                    if (sum == num && num != 0)
                    {
                        Console.WriteLine(num);
                    }
                }
            }


            //bài 12
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.Write("Nhập số n: ");
                int n = int.Parse(Console.ReadLine());

                bool isPrime = true;

                if (n < 2)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = 2; i <= Math.Sqrt(n); i++)
                    {
                        if (n % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                    Console.WriteLine(n + " là số nguyên tố.");
                else
                    Console.WriteLine(n + " không phải số nguyên tố.");
            }
        }
    }
}


