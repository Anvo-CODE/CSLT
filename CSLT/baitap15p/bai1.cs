//Bài 1
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


