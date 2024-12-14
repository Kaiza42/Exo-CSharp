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


