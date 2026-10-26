using MedicalSystem.Users;
using MedicalSystem.Spravki;
using MedicalSystem.Interfaces;
using MedicalSystem.Buhgalteria;

Patient patient = new Patient("Aktan", "Asanov", "+996 555 123 456");
patient.DisplayInfo();

Spravka83 spravka83 = new Spravka83
{
    SpravkaName = "Spravka 83",
    Patient = patient,
    Price = 500
};

SpravkaSanknijka spravkaSanknijka = new SpravkaSanknijka
{
    SpravkaName = "Spravka Sanknijka",
    Patient = patient,
    Price = 1000,
    AnalysisCount = 3
};

List<ISpravka> spravkiList = 
    new List<ISpravka> { spravka83, spravkaSanknijka };

foreach (var spravka in spravkiList)
{
    spravka.DisplayInfo();
    Console.WriteLine($"Total Price: {spravka.CalculatePrice()}");
    Console.WriteLine();
}

Kassa kassa = new Kassa();

decimal totalAmount = kassa.Total(spravkiList);

Console.WriteLine($"Total Amount in Kassa: {totalAmount}");