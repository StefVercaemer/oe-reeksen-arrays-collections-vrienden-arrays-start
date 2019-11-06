oe-reeksen-arrays-collections-vrienden-arrays-start
Bijhouden van de namen en geboortejaren van vrienden via 2 arrays
# Vrienden
Screenshot van het resultaat

![screenshot](/images/screenshot.png)

**Houd je code overzichtelijk door gebruik te maken van methoden.**
## Array
In de array **vrienden** kun je de namen van 10 vrienden opslaan.
In de array **geboorteJaren** worden de geboortejaren van de vrienden
bijgehouden. In het eerste element zit het geboortejaar van de eerste vriend, in
het tweede dat van de tweede vriend … 

![arrays](/images/arrays.png)

## Opstarten
Bij het opstarten wordt de methode *VulHuidigeVrienden* opgestart. 
- In de array vrienden wordt een aantal namen van vrienden in de elementen geplaatst. 
In de andere elementen wordt een lege string ingeladen.
- In de array geboorteJaren worden de resp. geboortejaren toegewezen. Dit is enkel nodig als er een naam aan de vriend gegeven is.
In bovenstaand voorbeeld is Koos geboren in 1992, Kees in 1985, etc.
## VulListbox
Via de methode VulListbox worden alle items in lstVrienden leeg gemaakt en opgevuld met de elementen van de array vrienden.
## Functionaliteiten
- Als er  een item in lstVrienden geselecteerd wordt, verschijnt de naam van de geselecteerde vriend in de textbox.
- Wanneer op de button btnOpslaan wordt geklikt, wordt de informatie uit de txtNaam in de resp. array opgeslagen.

- Als er  een item in lstVrienden geselecteerd wordt, verschijnt ook het geboortejaar van de geselecteerde vriend in de textbox.
- Wanneer op de button btnOpslaan wordt geklikt, wordt de informatie uit de txtGeboorteJaar in de resp. array opgeslagen.
## Uitbreiding
- Schrijf een methode om uit de systeemdatum het huidige jaar te halen. 
- Schrijf een methode om de leeftijd te berekenen op basis van het geboortejaar.
- Schrijf een methode om de leeftijd op basis van een geboortejaar weer in het label lblLeeftijd.
- Toon de leeftijd van de vriend bij selectie in de listbox en bij het opslaan.
