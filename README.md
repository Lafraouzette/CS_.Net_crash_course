# Objectif :  
L'ibjectife de ce repo est d'apprendre les basiques de C# et .NET

## C# vs .NET
C# est un langage de programmation, tandis que .NET est un framework qui supporte C# ainsi que d'autres langages comme F# et VB.NET.

## .NET Framework 
.NET est principalement composé du CLR (Common Language Runtime) et de bibliothèques.

### CLR 
Lorsque un projet C# est compilé, le code est transformé en langage intermédiaire (IL). Le CLR intervient alors pour traduire ce code IL en code machine afin que la machine puisse le comprendre. Cela se fait grâce à la compilation Just-In-Time (JIT).

### Architecture .NET 
- **Classe** : Une classe est un modèle pour créer des objets.
- **Namespace** : Un espace de noms regroupe plusieurs classes.
- **Assembly** : Un assembly est un ensemble de types et de ressources qui sont traités comme une unité logique dans la distribution et le versionnement.

# Introduction à C#

C# est un langage de programmation orienté objet développé par Microsoft. Il est largement utilisé pour développer des applications Windows, des services web, et des applications pour la plateforme .NET. Voici quelques concepts clés :

## 1. Structure de base d'un programme C#
```csharp
using System;

namespace MonPremierProgramme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, monde!");
        }
    }
}
```
- **using System;** : Importe l'espace de noms System, qui contient des classes de base comme `Console`.
- **namespace** : Déclare un espace de noms qui permet d'organiser le code.
- **class Program** : Déclare une classe nommée `Program`.
- **static void Main(string[] args)** : Point d'entrée du programme. C'est la méthode qui est exécutée en premier.

## 2. Types de données

### Types de données primitifs
```csharp
int nombreEntier = 5;
double nombreDecimal = 4.5;
char caractere = 'A';
string texte = "Bonjour";
bool estVrai = true;
```
- **int** : Entier
- **double** : Nombre à virgule flottante
- **char** : Caractère unique
- **string** : Chaîne de caractères
- **bool** : Booléen (true ou false)


### Types de données Non-primitifs
Voici une version concise du contenu que vous avez fourni, structurée dans un fichier `README.md` :

```markdown
# Types de données en C#

## Types de données primitifs
```csharp
int nombreEntier = 5;
double nombreDecimal = 4.5;
char caractere = 'A';
string texte = "Bonjour";
bool estVrai = true;
```
- **int** : Entier
- **double** : Nombre à virgule flottante
- **char** : Caractère unique
- **string** : Chaîne de caractères
- **bool** : Booléen (`true` ou `false`)

---

## Types de données non-primitifs

### 1. **Classes**
```csharp
class Personne
{
    public string Nom;
    public int Age;
}
```

### 2. **Tableaux**
```csharp
int[] nombres = { 1, 2, 3, 4, 5 };
```

### 3. **Listes**
```csharp
List<string> fruits = new List<string>();
fruits.Add("Pomme");
```

### 4. **Dictionnaires**
```csharp
Dictionary<string, int> ages = new Dictionary<string, int>();
ages["Alice"] = 30;
```

### 5. **Chaînes de caractères (`string`)**
```csharp
string texte = "Bonjour";
```

### 6. **Objets (`object`)**
```csharp
object obj = 42;
```

### 7. **Interfaces**
```csharp
interface IVehicule { void Demarrer(); }
```

### 9. **Événements (`event`)**
```csharp
event EventHandler Clique;
```

### 13. **Collections génériques**
```csharp
HashSet<string> fruits = new HashSet<string>();
```

## 3. Structures de contrôle
- **Condition if-else**
```csharp
int age = 18;
if (age >= 18)
{
    Console.WriteLine("Vous êtes majeur.");
}
else
{
    Console.WriteLine("Vous êtes mineur.");
}
```
- **Boucle for**
```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("i vaut " + i);
}
```
- **Boucle while**
```csharp
int i = 0;
while (i < 5)
{
    Console.WriteLine("i vaut " + i);
    i++;
}
```

## 4. Fonctions
```csharp
static int Addition(int a, int b)
{
    return a + b;
}

static void Main(string[] args)
{
    int resultat = Addition(3, 4);
    Console.WriteLine("Le résultat est : " + resultat);
}
```
- Les fonctions sont déclarées avec un type de retour, un nom, et des paramètres entre parenthèses.

## 5. Classes et objets
```csharp
class Personne
{
    public string Nom;
    public int Age;

    public void SePresenter()
    {
        Console.WriteLine("Bonjour, je m'appelle " + Nom + " et j'ai " + Age + " ans.");
    }
}

static void Main(string[] args)
{
    Personne personne = new Personne();
    personne.Nom = "Alice";
    personne.Age = 30;
    personne.SePresenter();
}
```
- Une classe définit un modèle pour un objet. Un objet est une instance d'une classe.
- **public** : Membre accessible depuis l'extérieur de la classe.

## 6. Héritage
```csharp
class Animal
{
    public void Manger()
    {
        Console.WriteLine("L'animal mange.");
    }
}

class Chien : Animal
{
    public void Aboyer()
    {
        Console.WriteLine("Le chien aboie.");
    }
}

static void Main(string[] args)
{
    Chien chien = new Chien();
    chien.Manger();  // Méthode héritée de la classe Animal
    chien.Aboyer();
}
```
- L'héritage permet de créer une nouvelle classe basée sur une classe existante.

## 7. Interfaces
```csharp
interface IVehicule
{
    void Demarrer();
}

class Voiture : IVehicule
{
    public void Demarrer()
    {
        Console.WriteLine("La voiture démarre.");
    }
}

static void Main(string[] args)
{
    Voiture voiture = new Voiture();
    voiture.Demarrer();
}
```
- Une interface définit un contrat que les classes doivent respecter. Une classe qui implémente une interface doit fournir des implémentations pour toutes les méthodes de l'interface.

## 8. Gestion des exceptions
```csharp
try
{
    int a = 5;
    int b = 0;
    int resultat = a / b;
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Erreur : Division par zéro.");
}
```
- Les exceptions sont gérées avec les blocs `try`, `catch`, et éventuellement `finally`.

## 9. Propriétés
```csharp
class Personne
{
    private string nom;

    public string Nom
    {
        get { return nom; }
        set { nom = value; }
    }
}

static void Main(string[] args)
{
    Personne personne = new Personne();
    personne.Nom = "Alice";
    Console.WriteLine(personne.Nom);
}
```
- Les propriétés permettent d'encapsuler les champs d'une classe et d'ajouter des logiques spécifiques lors de l'accès ou la modification des valeurs.

## 10. Collections
- **Tableaux**
```csharp
int[] nombres = { 1, 2, 3, 4, 5 };
```
- **Listes**
```csharp
List<string> fruits = new List<string>();
fruits.Add("Pomme");
fruits.Add("Banane");
```
- **Dictionnaires**
```csharp
Dictionary<string, int> ages = new Dictionary<string, int>();
ages["Alice"] = 30;
ages["Bob"] = 25;
```

## .NET
- **dotnet new console** : La commande dotnet new console est utilisée pour créer un nouveau projet de type "console" dans .NET. Un projet console est une application qui s'exécute dans une fenêtre de terminal ou de commande, et qui prend en entrée des commandes de l'utilisateur pour produire des sorties textuelles.
- **dotnet build** : Pour compiler le projet.
- **dotnet run** : Pour compiler et exécuter immédiatement le projet.
- **dotnet restore** : Pour restaurer les packages NuGet nécessaires (cela se fait automatiquement avec dotnet build ou dotnet run si nécessaire).
- **dotnet new** : Sans arguments, cette commande affiche la liste des modèles de projet disponibles (web, bibliothèque de classes, tests unitaires, etc.).
