# AdminDashboard

Tableau de bord d'administration développé avec ASP.NET Core MVC (.NET 10)** et Entity Framework Core. L'application permet de gérer des produits et d'authentifier des utilisateurs.

## Fonctionnalités

- Inscription et connexion des utilisateurs
- Mots de passe hachés avec `PasswordHasher` (ASP.NET Core Identity)
- Tableau de bord affichant la liste des produits
- Ajout de produits (CRUD)
- Pages d'erreur dédiées (utilisateur introuvable, mot de passe incorrect, utilisateur existant)

## Technologies

- C# / .NET 10
- ASP.NET Core MVC (Modèle-Vue-Contrôleur)
- Entity Framework Core (approche Code First, migrations)
- SQL Server
- Bootstrap, Razor (cshtml)

## Prérequis

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- SQL Server (ou SQL Server LocalDB)
- Visual Studio 2022 ou plus récent

## Installation

1. Cloner le dépôt :
   ```bash
   git clone https://github.com/adamabusiness24-sys/AdminDashboard.git
   cd AdminDashboard/AdminDashboard_UI
   ```
2. Vérifier la chaîne de connexion dans `appsettings.json` (`DefaultConnection`).
3. Créer la base de données :
   ```bash
   dotnet ef database update
   ```
4. Lancer l'application :
   ```bash
   dotnet run
   ```

## Structure du projet

- `Controllers/` : logique des requêtes (HomeController, ProductController)
- `Models/` : entités (Users, Products) et contexte de base de données
- `Views/` : pages Razor
- `Migrations/` : historique du schéma de la base de données

## Améliorations prévues

- Authentification par cookie et autorisation par rôles (`[Authorize]`)
- Tests unitaires
- Couche de services pour alléger les contrôleurs

## Auteur

Adama Camara
