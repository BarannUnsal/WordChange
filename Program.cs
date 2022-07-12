restart:
Console.WriteLine("Lütfen bir kelime giriniz");
string kelime = Console.ReadLine();
Console.WriteLine("Kelimeden çıkartmak istediğiniz harfin basamağını giriniz: ");
int basamak = Convert.ToInt32(Console.ReadLine());
if(basamak >= 0)
{
    var son = kelime.Remove(basamak, 1);
    Console.WriteLine($"Girdiğiniz kelime: {kelime} \nSonuç: {son}");
}
else
{
    Console.WriteLine("Yanlış değer girdiniz! Tekrar Denemek İster Misinz? (y/n)");
    string result = Console.ReadLine();
    if (result.ToLower() == "y")
        goto restart;
    else if(result.ToLower() == "n")
        Console.WriteLine("Görüşmek Üzere !!");
    else
        Console.WriteLine("Geçersiz Seçim Kapatılıyor!!!");
}