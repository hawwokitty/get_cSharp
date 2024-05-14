using OrganTransplant;

var bernt = new Pasienter("Bernt", "Bernt sin bra nyre", "Bernt sin dårlige nyre");
var kåre = new Pasienter("Kåre", "Kåre sin bra nyre", "Kåre sin bra nyre");

Console.WriteLine("Det har vært en akutt ulykke og Bernt ligger på sykehuset.");
Console.WriteLine("Han trenger en ny Nyre!");
Console.WriteLine("Heldigvis har fetteren hans Kåre to sunne Nyrer, og det er utført tester som tilsier at Kåre kan gi bort en av nyrene til Bernt og det vil være en høy suksessrate for overlevelse!");
Console.WriteLine("Slik ser Bernt sine nyrer ut nå:");
Console.WriteLine($"Nyre 1: {bernt.Kidney1}, Nyre 2: {bernt.Kidney2}");
Console.WriteLine("Slik ser Kåre sine nyrer ut nå:");
Console.WriteLine($"Nyre 1: {kåre.Kidney1}, Nyre 2: {kåre.Kidney2}");
Pasienter.DoTransplant(bernt, kåre);
Console.WriteLine("Beep beep, boop boop, transplantasjon skjer her!");
Console.WriteLine("Etter transplantasjonen ser Bernt sine nyrer sånn her ut:");
Console.WriteLine($"Nyre 1: {bernt.Kidney1}, Nyre 2: {bernt.Kidney2}");
Console.WriteLine("Og slik ser Kåre sine nyrer ut etter transplantasjonen:");
Console.WriteLine($"Nyre 1: {kåre.Kidney1}, Nyre 2: {kåre.Kidney2}");


