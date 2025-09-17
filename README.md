# GroceryApp sprint2 

## Docentversie  
In deze versie zijn de wijzigingen doorgevoerd en is de code compleet.  

## GitFlow
De branches die altijd aanwezig zijn, en dus niet worden verwijderd zijn: main & develop. 

### Feature
Voor het maken van een nieuwe functionaliteit (use case) maak je gebruik van een feature branch deze maak je aan vanuit de develop branch. 
- Feature branch naamgeving: feature/[use case]

Na het afronden van een use case in de feature branch, wordt een pull request gedaan naar de develop branch. Hierna wordt de feature branch verwijderd.
Na het afronden van alle use cases voor de minor version merge je de develop branch naar de release branch. 

### Hotfix
Voor hotfixes wordt gebruikgemaakt van een hotfix branch, deze wordt aangemaakt via de main branch. 
- Hotfix branch naamgeving: hotfix/[use case]-[wat verkeerd is]
Bij de hotfix kan wat verkeerd is van alles zijn, zoals een typo of kleur. Probeer zo kort mogelijk op te schrijven wat opgelost wordt met de hotfix.

Merge de hotfix naar de main branch en naar de develop branch. Maak vanuit de main branch een release aan met een correct releasenummer

### Release branch
Wanneer de use cases zijn gemerged van de develop branch naar de release branch wordt getest of er bugs in de code zitten. 
Wanneer dit het geval is zorg je ervoor dat deze gefixt worden in de release branch. Als alles goed werkt zonder bugs merge je naar de main en naar de develop branch
zodat allebei de branches up to date zijn.

## Studentversie:  
### UC04 Kiezen kleur boodschappenlijst  
Is compleet.

### UC05 Product op boodschappenlijst plaatsen:   
- `GetAvailableProducts()`  
	De header van de functie bestaat maar de inhoud niet.  
	Zorg dat je een lijst maakt met de beschikbare producten (dit zijn producten waarvan nog voorraad bestaat en die niet al op de boodschappenlijst staat).  
- `AddProduct()`   
	Zorg dat het gekozen beschikbare product op de boodschappenlijst komt (door middel van de GroceryListItemsService).  

### UC06 Inloggen  
Een collega is ziek maar heeft al een deel van de inlogfunctionaliteit gemaakt.  
Dit betreft het Loginscherm (LoginView) met bijbehorend ViewModel (LoginViewModel),  
maar ook al een deel van de authenticatieService (AuthServnn,mnmice in Grocery.Core),  
de clientrepository (ClientRepository in Grocery.Core.Data)  
en de client class (Client in Grocery.Core).  
De opdracht is om zelfstandig de login functionaliteit te laten werken.  

*Stappenplan:*  
1. Begin met de Client class en zorg dat er gebruik wordt gemaakt van Properties.  
2. In de ClienRepository wordt nu steeds een vaste client uit de lijst geretourneerd. Werk dit uit zodat de juiste Client wordt geretourneerd.  
3. Werk de klasse AuthService verder uit, zodat daadwerkelijk de controle op het ingevoerde password wordt uitgevoerd.
4. Zorg dat de LoginView.xaml wordt toegevoegd aan het Grocery.App project in de Views folder (Add ExistingItem). De file bevindt zich al op deze plek, maar wordt nu niet meegecompileerd.  
5. In MauiProgramm class van de Grocery.App staan de registraties van de AuthService en de LoginView in comment --> haal de // weg.  
6. In App.xaml.cs staat /*LoginViewModel viewModel*/ haal hier /* en */ weg, zodat het LoginViewModel beschikbaar komt.  
7. In App.xaml.cs staat //MainPage = new LoginView(viewModel); Haal hier de // weg en zet de regel erboven in commentaar, zodat AppShell wordt uitgeschakeld.  
8. Uncomment de route naar het Login scherm in AppShell.xaml.cs: //Routing.RegisterRoute("Login", typeof(LoginView)); 
 
