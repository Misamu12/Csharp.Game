# Csharp.Game
# Csharp.Game PTX


Voici une analyse détaillée de ton code C# qui implémente un petit jeu de calcul mental :

---

### **Structure générale**
- **Classe `Program`** : Contient le point d'entrée (`Main`) et la méthode `QuickMath`.
- **Méthode `Main`** : Appelle simplement `QuickMath()` pour lancer le jeu.

---

### **Méthode `QuickMath`**
#### **1. Initialisation**
- **`score`** : Variable pour compter le nombre de bonnes réponses.
- **`Random random`** : Générateur de nombres aléatoires pour créer les questions.

#### **2. Boucle de jeu**
- **5 questions** : La boucle `for` s'exécute 5 fois.
- **Génération aléatoire** :
  - `a` et `b` sont des entiers aléatoires entre 1 et 10 (inclus).
- **Affichage de la question** :
  - `Console.Write($"Combien fait {a} + {b} ? ");` : Affiche la question à l'utilisateur.

#### **3. Chronométrage**
- **`DateTime.Now`** : Capture l'heure de début avant que l'utilisateur ne réponde.
- **Lecture de la réponse** :
  - `int.TryParse(Console.ReadLine(), out answer)` : Lit la réponse et vérifie qu'elle est un nombre valide.
  - Si la réponse n'est pas un nombre, le programme demande à l'utilisateur de réessayer.

#### **4. Vérification de la réponse**
- **Comparaison** : Vérifie si la réponse (`answer`) est égale à la somme (`a + b`).
  - Si oui : incrémente le `score` et affiche "Correct !".
  - Si non : affiche la bonne réponse.
- **Affichage du temps** :
  - `TimeSpan elapsedTime` : Calcule le temps écoulé depuis le début de la question.
  - Affiche le temps en secondes avec 2 décimales (`{elapsedTime.TotalSeconds:F2}`).

#### **5. Affichage du score final**
- Affiche le score final sur 5 à la fin du jeu.

---

### **Points forts**
- **Gestion des erreurs** : Le code vérifie que l'utilisateur entre bien un nombre.
- **Feedback immédiat** : L'utilisateur sait tout de suite si sa réponse est correcte.
- **Chronométrage** : Ajoute un aspect ludique en mesurant le temps de réponse.

---

### **Améliorations possibles**
1. **Difficulté progressive** :
   - Augmenter la difficulté des questions (multiplication, soustraction) après chaque bonne réponse.
2. **Limite de temps** :
   - Ajouter un temps limite pour répondre (ex : 5 secondes).
3. **Interface utilisateur** :
   - Utiliser des couleurs dans la console pour les messages "Correct" (vert) et "Faux" (rouge).
4. **Personnalisation** :
   - Permettre à l'utilisateur de choisir le nombre de questions ou le niveau de difficulté.
5. **Gestion des exceptions** :
   - Ajouter un `try-catch` pour gérer d'éventuelles erreurs (ex : entrée vide).

---

### **Exemple d'amélioration (limite de temps)**
```csharp
TimeSpan timeLimit = TimeSpan.FromSeconds(5);
DateTime startTime = DateTime.Now;
while (DateTime.Now - startTime < timeLimit)
{
    if (int.TryParse(Console.ReadLine(), out answer))
        break;
    Console.Write("Veuillez entrer un nombre valide : ");
}
if (DateTime.Now - startTime >= timeLimit)
{
    Console.WriteLine("Temps écoulé !");
    continue;
}
```

---

### **Résumé**
Ton code est **fonctionnel, clair et bien structuré**. Il permet de tester les réflexes en calcul mental de manière simple et efficace. Si tu veux ajouter plus de fonctionnalités, tu peux explorer les idées ci-dessus !

Tu veux ajouter une fonctionnalité en particulier ou tu cherches des explications sur une partie précise ?

## Comment lancer le programme

Prérequis : avoir installé le .NET SDK (version 6.0 / 7.0 / 8.0 compatible). Sur Linux, vérifie avec :

```bash
dotnet --info
```

Pour exécuter le programme depuis la racine du dépôt :

```bash
cd HelloWorld
dotnet run
```

Ces commandes compilent et lancent l'application console contenue dans le dossier `HelloWorld`.

Remarques :
- Si tu veux seulement compiler sans exécuter : `dotnet build` dans `HelloWorld`.
- Si tu utilises une version spécifique du SDK (ex : net8.0), assure-toi que cette version est installée ou adapte le framework cible dans le fichier `HelloWorld.csproj`.

Si tu veux, je peux ajouter un petit script `run.sh` pour lancer automatiquement ces commandes ou un Makefile pour simplifier le démarrage.