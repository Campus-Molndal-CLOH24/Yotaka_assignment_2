
Namn: Yotaka Khaowkomol

# Inlämningsrapport

Information
OBS!!! Ändra absolut inte på rubrikerna i denna fil!!!!

## Inledning

### Hur uppfattade du uppgiften initialt?
Uppgiften innebar att använda de kunskaper jag har lärt mig under kursen för att skapa ett program som hanterar en lista av fordon, såsom bilar och motorcyklar, samt möjligheten att lägga till fler fordon. En viktig del av uppgiften var att implementera polymorfism genom att överskrida metoder ärvda från en interface-klass. Dessutom användes designmönster, som Factory-mönstret, men det skulle också kunna ändras till Builder-interface.
Målet med uppgiften var att förstå och tillämpa polymorfism, arv, interface, och designmönster, samt att kunna skriva ren och effektiv kod med tillräckliga kommentarer. Min lärare betonade vikten av att förklara varför specifika beslut togs istället för hur vi gjorde det. Jag fick även hjälp från andra programmerare och AI-verktyg som GitHub och ChatGPT för att bättre förstå koden.

--- Skriv ovanför och ta inte bort denna raden ---

## Planering och genomförande
1. Jag skapade en projektplan och prioriterade uppgifter i GitHub Projects för att hålla koll på framstegen.
2. Jag började med att analysera vilka klasser som skulle fungera som superklasser och vilka som skulle vara underklasser.
3. Därefter implementerade jag interface-klasserna och skapade fordonsklasser som ärvde från dessa interface-klasser.
4. Sedan skapade jag fordonsfabriker, som CarFactory och MotorcycleFactory, för att skapa fordonsobjekt genom överlagrade metoder.
5. Jag testade en klass i taget innan jag gick vidare till nästa.
### Vilka steg tog du för att lösa uppgiften?
För att lösa uppgiften började jag med att skapa en projektplan och prioriterade uppgifter i GitHub Projects. 
Analysering var ett viktigt steg som gjorde resten av implementationen enklare. 
Jag implementerade de grundläggande klasserna genom att utnyttja arv och polymorfism, vilket hjälpte mig att lösa problemen på ett strukturerat sätt.

--- Skriv ovanför och ta inte bort denna raden ---

## Utmaningar och lösningar

### Vilka utmaningar stötte du på under projektet?
Under projektets gång stötte jag på några utmaningar. Den största utmaningen var att IVehicleFactory.cs endast kunde ta tre argument (modell, år, och antal körda mil), vilket ledde till problem 
när jag ville lägga till ett ytterligare argument för dörrar i CarFactory.cs och MotorcycleFactory.cs. Detta skapade ett fel eftersom IVehicleFactory.cs inte kunde hantera fler än tre argument, och det gick därför inte att köra programmet.
Dessutom var det en utmaning att hålla koden ren och effektiv, särskilt när jag arbetade med polymorfism och arv. 
Jag behövde hitta en balans mellan struktur och kodens läsbarhet.

--- Skriv ovanför och ta inte bort denna raden ---

### Hur löste du dessa utmaningar?
Jag löste problemet med de extra argumenten genom att använda överlagrade metoder i CarFactory och MotorcycleFactory. Detta gjorde att programmet kunde hantera olika antal argument beroende på fordonstyp och fungerade utan att skapa fler felmeddelanden. 
Dessutom arbetade jag med att förbättra kodens struktur för att göra den mer läsbar och lätt att underhålla.

--- Skriv ovanför och ta inte bort denna raden ---

### Beskriv några implementeringsval du gjort?
Jag valde att fokusera på att skapa attribut (Ivevicle.cs) som ärvdes från interface-klasserna. 
Jag lade också särskild vikt vid att kunna visa fordonens information på ett tydligt sätt i konsolen, såsom modell och år. 
För att spara fordon använde jag dynamiska listor, vilket gjorde systemet mer flexibelt.

--- Skriv ovanför och ta inte bort denna raden ---

## Reflektion och utvärdering
 
### Vad lärde du dig genom att genomföra projektet?
Genom projektet har jag lärt mig hur man använder polymorfism, arv, interface och designmönster. Jag har också fått en djupare förståelse för hur man skriver mer effektiv och ren kod. 
Dessutom har jag lärt mig att använda GitHub Projects för att hålla reda på uppgifter och framsteg.
En annan viktig lärdom var att planering är avgörande. Genom att noggrant planera projektet och följa upp mina framsteg blev det enklare att hantera problem när de uppstod. 
Jag har också förbättrat min förmåga att strukturera och dokumentera kod, särskilt genom att använda markdown för att skriva README.md-filer på ett tydligt sätt.

--- Skriv ovanför och ta inte bort denna raden ---

### Vilka möjligheter ser du för framtida projekt baserat på denna erfarenhet?
Jag ser stor potential att använda denna erfarenhet för framtida projekt där jag kan tillämpa designmönster och objektorienterad programmering. Jag funderar också på att bygga vidare på det här projektet och göra det mer generellt så att det kan användas för andra typer av fordon, 
eller kanske till och med andra objekt som till exempel vapenfordon.

--- Skriv ovanför och ta inte bort denna raden ---