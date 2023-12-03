// Lambanın durumunu yöneten sınıfı oluşturalım
using StateDesignPattern;

LightContext lightContext = new LightContext();

// Lambayı açalım
lightContext.TurnOn();

// Lambayı parlatalım
lightContext.Brighten();

// Lambayı kapatalım
lightContext.TurnOff();

// Lambayı tekrar parlatalım (kapalı durumda parlaklık arttırılamaz)
lightContext.Brighten();

Console.ReadLine();