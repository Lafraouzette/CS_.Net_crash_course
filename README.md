# Objectif
L'objectif de ce dépôt est d'apprendre les bases de .NET Framework en utilisant le langage C#.

---

## 1. Théorie

### .NET Framework
.NET est principalement composé de deux éléments fondamentaux :
- **CLR (Common Language Runtime)** : Il assure l'exécution du code en le convertissant en code machine grâce à la compilation Just-In-Time (JIT).
- **Bibliothèques de classes** : Elles fournissent un ensemble d'APIs permettant le développement d'applications.

### 2. Common Language Runtime (CLR)
Lorsqu'un projet C# est compilé, le code est transformé en langage intermédiaire (IL). Le CLR intervient ensuite pour traduire ce code IL en code machine exécutable par l'ordinateur.

---

## 3. Créer un projet

Utilisez la commande suivante pour créer un nouveau projet .NET :

```bash
 dotnet new <project-type> <option>
```

Pour afficher la liste des modèles de projets disponibles :

```bash
 dotnet new
```

### 4. Types de projets .NET

- **Console** : Application en ligne de commande.
- **WebApp** : Application web.
- **MVC** : Application web basée sur le modèle MVC.
- **MAUI** : Application multi-plateforme.
- **WPF** : Application de bureau Windows.

Pour afficher la liste complète des types de projets :

```bash
 dotnet new list
```

---

## 5. Structure des fichiers et dossiers

### 5.1. Fichiers .NET

- **.csproj** : Fichier de configuration XML contenant les métadonnées du projet. Utilisé pour restaurer les dépendances et les outils avec :

  ```bash
  dotnet restore
  ```

- **.cs** : Fichier principal du code source C#.

### 5.2. Dossiers .NET

- **bin/** : Contient les fichiers compilés.
- **obj/** : Contient des fichiers temporaires utilisés pendant le processus de compilation.

---

## 6. Composantes principales du code C#

- **Classe** : Modèle permettant de créer des objets.
- **Namespace** : Espace de noms regroupant plusieurs classes.
- **Assembly** : Unité logique regroupant plusieurs types et ressources.

---
Voici une reformulation de votre texte pour le rendre plus clair et structuré :

---

# Pratique : Découverte de C# avec un projet .NET Console

Dans ce dépôt, nous allons explorer les bases de C# en créant un projet .NET Console. Ce projet servira de démonstration pour comprendre les concepts fondamentaux du langage.

---

## 1. Création du projet

Pour commencer, créez un nouveau projet .NET Console avec la commande suivante :

```bash
dotnet new console -n my_first_project
```

Cela génère un projet nommé `my_first_project` avec une structure de base.

---

## 2. Premier programme : "Hello World"

Ouvrez le fichier `Program.cs` et ajoutez le code suivant pour afficher un message dans la console :

```csharp
Console.WriteLine("Mon premier programme en C#");
```

### Compilation et exécution

- Pour compiler le projet, utilisez :
```bash
  dotnet build
```

- Pour exécuter le projet, utilisez :
```bash
 dotnet run

  ```

---

## 3. Types de données en C#

### Types de données primitifs

- **`int`** : Entier (exemple : `int age = 25;`).
- **`double`** : Nombre à virgule flottante (exemple : `double pi = 3.14;`).
- **`char`** : Caractère unique (exemple : `char letter = 'A';`).
- **`string`** : Chaîne de caractères (exemple : `string name = "Alice";`).
- **`bool`** : Booléen (`true` ou `false`, exemple : `bool isActive = true;`).

### Types de données non-primitifs

- **Classes et objets** : Structures personnalisées pour modéliser des entités.
- **Interfaces** : Contrats définissant des méthodes que les classes doivent implémenter.
- **Tableaux** : Collections de taille fixe (exemple : `int[] numbers = { 1, 2, 3 };`).
- **Listes** : Collections dynamiques (exemple : `List<string> names = new List<string>();`).

---

## 4. Structures de contrôle

### Condition `if-else`

Permet d'exécuter du code en fonction d'une condition :

```csharp
if (age > 18)
{
    Console.WriteLine("Vous êtes majeur.");
}
else
{
    Console.WriteLine("Vous êtes mineur.");
}
```

### Boucle `for`

Permet de répéter une action un nombre défini de fois :

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Itération : " + i);
}
```

### Boucle `while`

Permet de répéter une action tant qu'une condition est vraie :

```csharp
int count = 0;
while (count < 5)
{
    Console.WriteLine("Compteur : " + count);
    count++;
}
```

---

## 5. Gestion des événements

Les événements permettent de déclencher des actions en réponse à des actions utilisateur ou à des changements d'état. Par exemple :

```csharp
event EventHandler Clique;

// Déclencheur d'événement
Clique?.Invoke(this, EventArgs.Empty);
```
! on va les apprendre apres . 
---

## 6. Les fonctions

Les fonctions (ou méthodes) permettent de regrouper du code réutilisable. Par exemple :

```csharp
public int Addition(int a, int b)
{
    return a + b;
}
```

---

## 7. Héritage

L'héritage permet de créer une nouvelle classe basée sur une classe existante. Par exemple :

- public class Dog : Animal et son constructeur : public Dog(string name) : base(name) // Appel du constructeur de la classe de base{    }


## 8. Gestion des exceptions

Les exceptions permettent de gérer les erreurs de manière structurée. Utilisez les blocs `try`, `catch`, et `finally` :

```csharp
try
{
    int result = 10 / 0; // Division par zéro
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Erreur : " + ex.Message);
}
finally
{
    Console.WriteLine("Exécuté dans tous les cas.");
}
```

---

## 10. Ressources utiles

- [Documentation officielle .NET](https://learn.microsoft.com/fr-fr/dotnet/)
- [Tutoriels C#](https://learn.microsoft.com/fr-fr/dotnet/csharp/)

Bon apprentissage ! 🚀