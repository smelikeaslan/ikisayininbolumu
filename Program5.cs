Console.Write("Birinci sayyıyı giriniz:");

double birincisayi = Convert.ToInt32(Console.ReadLine());


Console.Write("İkinci sayıyı giriniz:");

double ikincisayi = Convert.ToInt32(Console.ReadLine());


double bolum = birincisayi / ikincisayi;


Console.Write("Birinci sayının, ikinci sayıya bölümü:" + bolum);

Console.ReadKey();