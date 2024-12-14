
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


