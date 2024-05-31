using Lagerstyringssystem;

Lager lager = new Lager();
Klær genser = new Klær("Genser", 299, "S");
Klær kjole = new Klær("Kjole", 549, "XL");
Matvare melk = new Matvare("Melk", 36, DateOnly.Parse("2024-10-30"));
Matvare ost = new Matvare("Ost", 119, DateOnly.Parse("2024-06-14"));
Elektronikk smartWatch = new Elektronikk("Smart Watch", 2999, 14);
Elektronikk webCam = new Elektronikk("web Camera", 499, 12);

lager.LeggTilProdukt(genser);
lager.LeggTilProdukt(kjole);
lager.LeggTilProdukt(melk);
lager.LeggTilProdukt(ost);
lager.LeggTilProdukt(smartWatch);
lager.LeggTilProdukt(webCam);
lager.ListOppAlleProdukter();
lager.FjernProdukt(genser);
lager.ListOppAlleProdukter();