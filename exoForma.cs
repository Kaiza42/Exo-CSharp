using System;
using System.Collections.Generic;
using System.Net;
using System.Net.WebSockets;
using System.Threading.Channels;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("C'est mon premier programme en c# !");
            //Console.WriteLine("c'est simple ! ");

            //string msg = "bonjour tout le monde.";

            //Console.WriteLine(msg);

            //int age = 25;

            //string prenom = "Alice";

            //bool sonAge = true;

            //Console.WriteLine("Son age est " + age + " ,son prenom est " + prenom + " ,elle est majeur ? " + sonAge);

            //string  monNombre = Console.ReadLine();

            //string monNombreDeux = Console.ReadLine();

            //int conversion = int.Parse(monNombreDeux);

            //int conversionDeux = int.Parse(monNombre);

            //Console.WriteLine(conversion + conversionDeux);
            //Console.WriteLine(conversion - conversionDeux);
            //Console.WriteLine(conversion * conversionDeux);

            //string age = Console.ReadLine();

            //string ageDeux = Console.ReadLine();

            //int conversion = int.Parse(age);

            //int conversionDeux = int.Parse(ageDeux);

            ////Console.WriteLine(conversion < conversionDeux);

            ////Console.WriteLine(conversion > conversionDeux);

            ////Console.WriteLine(conversion == conversionDeux);

            //if (conversion >= 18)
            //{
            //    Console.WriteLine("Je suis majeure");
            //}
            //else
            //{
            //    Console.WriteLine("je suis mineur");
            //}

            //int jour = 3;

            //switch (jour)
            //{
            //    case 1:
            //        Console.WriteLine("lundi");
            //        break;
            //    case 2:
            //        Console.WriteLine("mardi");
            //        break;
            //    case 3:
            //        Console.WriteLine("mercredi");
            //        break;
            //    case 4:
            //        Console.WriteLine("Jeudi");
            //        break;
            //    case 5:
            //        Console.WriteLine("Vendredi");
            //        break;
            //    case 6:
            //        Console.WriteLine("Samedi");
            //        break;
            //    case 7:
            //        Console.WriteLine("Dimanche");
            //        break;
            //    default:
            //        Console.WriteLine("Mais tu fait quoi ?");
            //            break;
            //}


            //string saisie = Console.ReadLine();

            //if (saisie.Length <= 8)
            //{
            //    Console.WriteLine("Mot de passe confirmer");
            //}
            //else
            //{
            //    Console.WriteLine("Trop long");
            //}

            //string saisie = Console.ReadLine();

            //int conversionSaisieDeux = int.Parse(saisie);

            //for (int c = 0; c <= 10; c++)
            //{
            //    Console.WriteLine("mes table de multiplication de " + conversionSaisieDeux * c);
            //}

            //int conversionSaisie;
            //int trouveMoi = 0;
            //int result = 0;


            //do
            //{
            //    string saisieTrois = Console.ReadLine();

            //    if (int.TryParse(saisieTrois, out conversionSaisie))
            //    {
            //        if (conversionSaisie != trouveMoi)
            //        {
            //            Console.WriteLine("hey c'est pas compliquer .. un chiffre entre 0 et 9 ");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Bravo.");

            //        }
            //        result += conversionSaisie;
            //        Console.WriteLine("le resultat de toute tes saisie donne sa " + result);

            //    }
            //} while (conversionSaisie != trouveMoi);


            //Exo tableau 
            // int result = 0;

            // int[] chiffre = new int[5];

            //for( int i = 0; i < chiffre.Length; i++)
            // {
            //    chiffre[i] = int.Parse(Console.ReadLine());
            //     if (5 == chiffre.Length)
            //     {
            //       Console.WriteLine(chiffre[i]);
            //     }
            //     else
            //     {
            //         Console.WriteLine("il y a une erreure");
            //     }
            //     result += chiffre[i];


            // }

            // Console.WriteLine("le resultat c'est " + result);

            //exo 1 
            //string saisie = Console.ReadLine();

            //int saisieUtilisateur = int.Parse(saisie);

            //if (saisieUtilisateur < 10)
            //{
            //    Console.WriteLine("la saisie est plus petite que 10");
            //}
            //else
            //{
            //    Console.WriteLine("La saisie est plus grande que 10");
            //}

            //exo 2 
            //string saisie = Console.ReadLine();

            //int saisieUtilisateur = int.Parse(saisie);

            //if (saisieUtilisateur < 0)
            //{
            //    Console.WriteLine("Ce nombre est negatif");
            //}
            //else if (saisieUtilisateur == null)
            //{
            //    Console.WriteLine("ce nombre est null");
            //}
            //else
            //{
            //    Console.WriteLine("ce nombre est positif");
            //}

            //exo 3 
            //string ageUtilisateur = Console.ReadLine();

            //int conversionAgeUtilisateur = int.Parse(ageUtilisateur);


            //if(conversionAgeUtilisateur < 18)
            //{
            //    Console.WriteLine("vous ete mineur");
            //}
            //else
            //{
            //    Console.WriteLine("vous ete majeure");
            //}

            //exo 4

            //string vide = "";

            //if (vide == "")
            //{
            //    Console.WriteLine("la Chaine de caractère est vide");
            //}
            //else
            //{
            //    Console.WriteLine("la Chaine de caractère n'est pas vide ");
            //}

            //exo 5 

            //for(int n = 0; n <= 10; n++)
            //{
            //    if(n % 2 == 0)
            //    {
            //        Console.WriteLine("Le chiffre " + n + " est pair");
            //    }
            //    else
            //    {
            //        Console.WriteLine("le chiffre " + n + " est impaire");
            //    }
            //}

            //exo 6
            //string saisie = Console.ReadLine();

            //string saisieDeux = Console.ReadLine();

            //int conversionSaisie = int.Parse(saisie);

            //int conversionSaisieDeux = int.Parse(saisieDeux);



            //if ( conversionSaisie > conversionSaisieDeux)
            //{
            //    Console.WriteLine("Je veut le plus grand nombre " + conversionSaisie);
            //}
            //else 
            //{
            //    Console.WriteLine("Je veut le plus grand nombre " + conversionSaisieDeux);
            //}

            //exo 7 

            //int c = 15;

            // if( c % 5 == 0 || c % 3 == 0)
            //{
            //    Console.WriteLine(c);
            //}else
            //{
            //    Console.WriteLine("n'est pas divisible par 3 ou 5");
            //}

            // }

            //exo 8
            //string mdp = "Admin";
            //string utilisateur = "Yes";
            //string saisie = Console.ReadLine();
            //string saisieMdp = Console.ReadLine();


            //if (saisie == utilisateur && saisieMdp == mdp)
            //{
            //    Console.WriteLine("utilisateur correct ");
            //}
            //else
            //{
            //    Console.WriteLine("utilisateur incorrect");
            //}

            //exo 9

            //string test = "b";


            //if (test =="a" || test == "e" || test =="i" || test == "o" || test == "u")
            //{
            //    Console.WriteLine("c'est une voyelle");
            //}
            //else
            //{
            //    Console.WriteLine("C'est une consonne");
            //}


            //exo 10 

            // IList<string> jsaispas = new List <string>();

            // jsaispas.Add("jsais pas");

            //if (jsaispas.Count == 0)
            // {
            //     Console.WriteLine("la liste est vide");
            // }
            // else
            // {
            //     Console.WriteLine("La liste n'est pas vide");
            // }

            //exo 11 

            //int c = 10; 

            //if ( c <= 20 && c >= 10)
            //{
            //    Console.WriteLine("il est supérieur ou égale a 10 mais inférieur ou égale a 20");
            //}
            //else
            //{
            //    Console.WriteLine("Inferieur a 10 ou supérieur a 20");
            //}

            //exo 12

            //string saisie = Console.ReadLine();

            //int saisieAge = int.Parse(saisie);

            //if(saisieAge < 12)
            //{
            //    Console.WriteLine("t'es un enfant");
            //}
            //else if (saisieAge <= 18)
            //{
            //    Console.WriteLine("t'es un adolescent");
            //}
            //else
            //{
            //    Console.WriteLine("t'es un adulte");
            //}

            //exo 13 

            //    int annee = 1500;

            //if (annee % 4 == 0 && annee % 100 != 0 || annee % 400 == 0)
            //{
            //    Console.WriteLine("c'est une année bisextile");
            //}
            //else
            //{
            //    Console.WriteLine("c'est pas une année bisextile");
            //}

            //exo 14 

            //int c = 2; 

            //if (c < 0 && c % 5 == 0)
            //{
            //    Console.WriteLine("Le chiffre est négatif et un multiple de 5");
            //}
            //else if(c > 0 && c % 5 == 0)
            //{
            //    Console.WriteLine("le chiffre est Positif est un multiple de 5");
            //}
            //else
            //{
            //    Console.WriteLine("Mais c'est quoi sa ?");
            //}

            //exo 15
            //string fruit = "amande";

            //bool verifications = fruit.Contains("a");

            //Console.WriteLine(verifications);

            //exo 16 

            //int c = 12; 

            //if(c % 3 == 0 && c % 2 == 0 && c % 9 != 0)
            //{
            //    Console.WriteLine("est divible par 3 et 2 mais pas par 9");
            //}
            //else
            //{
            //    Console.WriteLine("ce n'est pas divisible");
            //}

            //exo 17
            //string mdp = "Admin";
            //string utilisateur = "Yes";
            //string saisie = Console.ReadLine();
            //string saisieMdp = Console.ReadLine();


            //if (saisie == utilisateur && saisieMdp == mdp)
            //{
            //    Console.WriteLine("utilisateur correct ");
            //}
            //else
            //{
            //    Console.WriteLine("utilisateur incorrect");
            //}

            //exo18

            //int note = 50;

            //if(note > 85)
            //{
            //    Console.WriteLine("Excelent");
            //}
            //else if (note > 70)
            //{
            //    Console.WriteLine("Bien");
            //}
            //else
            //{
            //    Console.WriteLine("peut mieux faire");
            //}

            //exo 19


            //string yes = "juste";

            //for(int i = 0; i < yes.Length / 2; i++)
            //{

            //    if (yes[i] != yes[yes.Length - 1 - i])
            //    {
            //        Console.WriteLine("ce n'est pas un palindrome");
            //    }
            //    else
            //    {
            //        Console.WriteLine("c'est un palindrome");
            //    }
            //}

            //exo 20 

            //int chiffre = 120;

            //if (chiffre > 0 && chiffre% 2 == 0 && chiffre > 100)
            //{
            //    Console.WriteLine("le chiffre " + chiffre + " est un multiple de 2 , est positif , et est supérieur a 100");
            //}
            //else
            //{
            //    Console.WriteLine(" le chiffre " + chiffre + " n'est pas l'un des argument");
            //}

            //exo 21 

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //exo 22 

            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine("le nombre " + i + " est pair");
            //    }

            //}


            //exo 23

            //IList <string> montreMoi = new List<string>();

            //montreMoi.Add("Jean");
            //montreMoi.Add("morron");
            //montreMoi.Add("jardi");
            //montreMoi.Add("land");

            //foreach ( string montremois in montreMoi)
            //{
            //    Console.WriteLine(montremois);
            //}

            //exo 24

            //string n = Console.ReadLine();

            //int convertN = int.Parse(n);

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine( n + "*" + i + "=" + convertN * i);
            //}

            //exo 25 
            //string yes = "envie de canner";
            //for( int c = 0; c <yes.Length; c++)
            //{
            //    Console.WriteLine(yes[c]);
            //}


            //exo 26

            //int n = 0; 

            //while(n < 100)
            //{
            //    n += 10;
            //    Console.WriteLine(n);
            //}

            //exo 27 

            //IList<string> yes = new List<string> {"jpp","de","ses","list","...","ALED"};

            //for (int i = 0; i < yes.Count; i++)
            //{
            //    Console.WriteLine("l'index " + i + " ma liste " + yes[i]);
            //}

            //exo 28 

            //for(int i = 10; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //exo 29

            //int result = 0;
            //for(int n = 0; n <= 50; n++ )
            //{
            //    result += n; 

            //}
            //Console.WriteLine(result);

            //exo 30 

            //for (char c = 'a'; c <= 'e'; c++)

            //{
            //    Console.WriteLine(c + " ");
            //}

            //exo 31 

            //int n = 0; 

            //while(n < 10)
            //{
            //    n += 1;
            //    Console.WriteLine(n);
            //}

            //exo 32
             //int n = 0;
 //int result = 0; 

 //while( n < 100)
 //{
 //    n += 1;
 //    result += n;
 //}

 //Console.WriteLine(result);

 //exo 33 

 //while (true)
 //{
 //    int saisie = int.Parse(Console.ReadLine());

 //    if (saisie >= 0)
 //    {
 //        Console.WriteLine("recomence");

 //    }
 //    else
 //    {
 //        Console.WriteLine("bien jouer");
 //        break;
 //    }
 //}

 //exo 34 
 //string mdp = "yes";

 //while (true)
 //{
 //    string saisie = Console.ReadLine();
 //    if (saisie == mdp)
 //    {
 //        Console.Write("Mot de passe correct");
 //        break;
 //    }
 //    else
 //    {
 //        Console.Write("Recomence");
 //    }
 //}

 //exo 35

 //int n = 1;

 //while( n <= 50 )
 //{
 //    n += 1;
 //    Console.WriteLine(n * 5);
 //}

 //exo 36 

 //int n = 0; 

 //while(n < 10)
 //{
 //    n += 1;
 //    Console.WriteLine(n);
 //    if (n == 10)
 //    {
 //        Console.WriteLine("Fin de la boucle.");
 //    }
 //}

 //exo 37 

 //int n = 11; 

 //while(n >= 1)
 //{
 //    n -= 1;
 //    Console.WriteLine(n);
 //}

 //exo 38

 //facorial pas mon delir hein



 //exo 39

 //int n = 0; 

 //while (n < 200)
 //{
 //    n += 1;
 //    if (n %2 == 0 && n%3 == 0)
 //    {
 //        Console.WriteLine("le chiffre " + n + " est pair et divise par 3");

 //    }

 //}

 //exo 40

 //int[] tableau = new int[5];

 //int n = 0;

 //while (n < tableau.Length)
 //{
    
 //    tableau[n] = int.Parse(Console.ReadLine());
 //    n += 1;
 //    if(n == tableau.Length)
 //    {
 //        Console.WriteLine("mon tableau est remplie");
         
 //    }
 //}
  // exo 41 

 //for(int n = 0; n <20; n++)
 //{
 //    Console.WriteLine(n);
 //    if(n== 10)
 //    {
 //        break;
 //    }
 //}

 //exo 42 

 //while (true)
 //{
 //    int saisie = int.Parse(Console.ReadLine());
 //    if (saisie == 0)
 //    {
 //        Console.WriteLine("Bien jouer");
 //        break;
 //    }
 //    else
 //    {
 //        Console.WriteLine("Recomence");
 //    }
 //}
 //exo 43

 //for (int n = 0; n <= 10; n++)
 //{
 //    Console.WriteLine(n);
 //    if (n % 2 == 0)
 //    {
 //        if (n <= 4)
 //        {
 //        Console.WriteLine(n);
 //        continue;
 //        }
 //    }
 //}


 //exo 44

 //for(int n = 0; n <= 20; n++)
 //{
 //    if( n %3 != 0)
 //    {
 //        Console.WriteLine(n + " c'est un multiple de 3 ? je crois pas ");
 //    }
 //}

 //exo 45 
 //  int saisie = int.Parse(Console.ReadLine());
 //for(int n = 0; n < saisie; n++)
 //{
    
 //    if (n % 4 != 0)
 //    {
 //        Console.WriteLine(n);
 //    }
 //}




}
     }
        }