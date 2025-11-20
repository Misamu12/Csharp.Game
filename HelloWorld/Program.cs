using System;

class Program
{
    static void Main()
    {
        // Point d'entrée du programme : appelle la méthode qui lance le jeu
        QuickMath();
    }

    static void QuickMath()
    {
        // score : compteur de bonnes réponses
        int score = 0;

        // Générateur de nombres aléatoires pour créer les questions
        Random random = new Random();

        // Boucle principale : 5 questions
        for (int i = 0; i < 5; i++)
        {
            // Génère deux entiers entre 1 et 10 (inclus)
            int a = random.Next(1, 11); // Entre 1 et 10 inclus
            int b = random.Next(1, 11);

            // Pose la question à l'utilisateur
            Console.Write($"Combien fait {a} + {b} ? ");

            // Démarre le chronomètre afin de mesurer le temps de réponse
            DateTime startTime = DateTime.Now;

            // Lecture et validation de l'entrée utilisateur
            // TryParse renvoie false si l'entrée n'est pas un entier valide
            int answer;
            while (!int.TryParse(Console.ReadLine(), out answer))
            {
                // Demande à l'utilisateur de saisir à nouveau si l'entrée est invalide
                Console.Write("Veuillez entrer un nombre valide : ");
            }

            // Calcule le temps écoulé depuis l'affichage de la question
            TimeSpan elapsedTime = DateTime.Now - startTime;

            // Vérifie la réponse et affiche un feedback immédiat
            if (answer == a + b)
            {
                score++; // bonne réponse -> incrémente le score
                Console.WriteLine("Correct !");
            }
            else
            {
                // Affiche la bonne réponse si l'utilisateur s'est trompé
                Console.WriteLine($"Faux ! La bonne réponse était {a + b} ");
            }

            // Affiche le temps mis pour répondre (en secondes, 2 décimales)
            Console.WriteLine($"Temps : {elapsedTime.TotalSeconds:F2} secondes");
        }

        // Résumé final du score après les 5 questions
        Console.WriteLine($"Votre score : {score}/5");
    }
}