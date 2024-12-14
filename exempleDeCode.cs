
// il faudras décomenter pour tester 

// l'exemple sert a quoi a dire qu'on peut aller chercher des valeur dans un tableau comme ceci

int[] combienDeLivre = new int[]{20 , 10 , 15, 25 , 35};

for (int n = 0; n <= 40 ; n++)
{
    if(combienDeLivre[n] == 25)
    {
        Console.WriteLine("j'ai " + combienDeLivre[n] + " livre sa fait peu non ?");
        break; // le break sert a dire ta trouver ce que tu chercher non ? on s'arrete la.
    }
}

// fin des livre
//  debut test de continue ou break

int chiffre = 0; 

for( int n = chiffre; n <= 20 ; n++)
{
    Console.WriteLine(n);
    if( n  == 2 || n == 10)
    {
        Console.WriteLine("j'ai touver mon chiffre c'est " + n);
        continue; // Comme on peut voir le code continue malgres avoir trouver l'un des deux nombre 
    }
}

//  l'utilisation de char dans une boucle for pour afficher l'alphabet
  // parfois je trouve des choses un peu inutile interessante et je pense que sa en fait partie.. Mais chacun sont interet apres tout.

for(char l = 'a'; l <= 'y'; l++)
// tout dabord pourquoi j'ai choisie L comme variable ? pour lettre. 
// ensuite = 'a' béh l'alphabet commence par A mais j'aurais pu comencer par 'n'
// la suite  "l <= 'y'" je vais resumé par la condition que on comence par 'a' donc disons 1 et l'ittération continueras jusqu'a 'y' je sais plus c'est quelle chiffre.
// l++ ? pour avancer dans l'alphabet car apres 1 (a) Bah c'est 2(b) ect
{
    Console.WriteLine(l + "");
// l'affichage on va dire que on affiche le resulat qui se met dans la string vide vue qu'on les additionne 
}


//  une boucle while pour faire saisir a l'utilisateur une valeur voulue tant que la la saisie n'est pas bonne il recomence 

  while (true)
//   Boucle infinie
  {
      int saisie = int.Parse(Console.ReadLine());
    //   la saisie utilisateur 

      if (saisie >= 0)
    //   La condition de la boucle 
      {
          Console.WriteLine("recomence");
        // texte en cas d'echec 

      }
      else
      {
          Console.WriteLine("bien jouer");
        //   Texte en cas de reussite 
          break;
        //   la sortie de la boucle infinie
      }
  }

  // boucle infinie 
// declaration de ma varibale 
int chiffre = 0; 

 while (true){
  // le principe de la "while (true)" est que while seras toujours "true" donc tounreras a l'infinie 

  //chiffre +1
chiffre++; 
// La condition pour sortir de cette boucle infinie
if( chiffre == 6){
    // affichage du resultat
  Console.WriteLine("Chiffre trouver " + chiffre);
//   ce qui permet de sortir de la boucle 
  break;
}
// Pourquoi mettre l'affichage apres la condition de sortie de boucle ? pour éviter la répétition de la condition de sortie de boucle
Console.WriteLine(chiffre);
 }




 Random chiffreMystere = new Random();
 int numeroMystere = chiffreMystere.Next(1, 51);
 int resultEssaie = 0;
 

 Console.WriteLine("--- Trouver le nombre Mystère ---");
 while (true)
 {
     resultEssaie += 1;

     
     Console.ForegroundColor = ConsoleColor.White;
     Console.Write("\tVeuillez saisir un nombre : ");
     int saisieUtilisateur = int.Parse(Console.ReadLine());
     
     if(saisieUtilisateur != numeroMystere)
     {

     
         if (saisieUtilisateur < numeroMystere)
         {
         Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine("\t\tLe nombre mystere est plus grand");
         }
         else if(saisieUtilisateur > numeroMystere)
         {
             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("\t\tLe nombre mystere est plus petit");
         };
     }
     else
     {
         Console.ForegroundColor = ConsoleColor.Green;
         Console.WriteLine("\nBravo !!!! vous avez trouber le nombre mystere !\n");
         Console.WriteLine("Vous avez trouver en " + resultEssaie + " coups.");
             Console.ForegroundColor = ConsoleColor.White;
         break;
     }
 }

//Afficher Deux liste cote a cote 
// celui la je le trouve interessant Pour moi j'aller le complexifier alors que ? bah c'est si simple
 var list_0 = new List<object> { 5, 89, 79, 4, false };
var list_1 = new List<object> { 8, 9, 12, "azed", 7.7 };

  // vue qu'elle sont egale i va compter le meme nombre d'élément pour chaque list non ? 
    for(int i = 0; i < list_0.Count; i++)
    {
      //  et la je les affiche cote a cote. 
        Console.WriteLine(list_0[i] + "  " + list_1[i]);
    }


// celui ci je le trouve pertinent 

// Donc ta une liste pour le moment tous va bien Mais maintenant la liste a des SOUS liste 
var elements = new List<List<object>> {
    new List<object> { 5, 89, 79, 4, false },
    new List<object> { 8, 9, 12, "azed", 7.7, 9 },
    new List<object> { 7.12, "aba", 4689, true, 3 }
};

// Ici On parcours la LISTE 
for(int i = 0; i <elements.Count; i++)
{
    //Et la les sous list 
    for(int n = 0; n < elements[i].Count; n++)
    {
      //Mais du coup Pourquoi [i][n] car I parcours La liste Principal et N parcours les sous Liste Trop bien.
        Console.WriteLine(elements[i][n]);
    }
}