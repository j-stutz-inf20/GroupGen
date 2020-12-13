using System;
using System.Threading;

namespace Random_Group_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Copyright © Jan Stutz, In 20c
            //Lernziele:- Gruppen Generator                             |
	        //- Namen einlesen
            //- Entscheidung Anzahl Gruppen oder Gruppen grösse         x
            //- Anzahl Gruppen oder Gruppen grösse eingeben             x 
            //- Ausgabe von Gruppen
            //+ Einlesen der Namensliste (LP stellt Methode zur verfügung)
            //+ Speichern der Gruppen als Liste (LP stellt Methode zur verfügung)
            //+ Mitglieder definieren welche nicht zusammen in die Gruppe dürfen.

            //Input Output                                              x
            //Loops                                                     
            //IFs
            //Array
            //Try Catch                                                 X
            //Random / Math

            //Abgabe PAP am	    04.12.2020                                 x
            //Abgabe Code am	18.12.2020
            //Abgabe Portf. am	28.12.2020

            // Eingabe 3 Gruppen
            // x Gruppen
            // y Personen
            // z Personen pro Gruppe

            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Title = "Gruppengenerator";
            string title = @"
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMWXOxdoodkKNMMMMMMMMMMMMWKOxooooxOKWMMMMMMMMMMMMNKkdoodxOXWMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMNk:.       .,oKWMMMMMMMXx;.        .;dXMMMMMMMWKo,.       .:kNMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMW0;             .dNMMMMWk'              'kWMMMMNd.             ;0WMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMM0,               .oNMMWk.                .xWMMNo.               ,0MMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMNl                 '0MMX;                  ;XMM0'                 lNMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMNc                 .OMMK,                  ,KMMO.                 cNMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWd.                ;KMMNl                  lNMMK;                .dWMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMXl.              'OWMMMK:                :KMMMWO'              .lNMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMNx,           .lKWMMMMMXd'            'dXMMMMMWKl.           ,xNMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMNOo;'....,cxKWMMMMMMMMWXkl;'....';lkXMMMMMMMMMWKxc,....';oONMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMWNXXXNWMMMMMMMMMMMMMMMMWNXXXXNWMMMMMMMMMMMMMMMMWNXXXNWMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMXOxdddddddddddkNMMMMWKkddddodddddddddddddddddooddkKWMMMMNkdddddddddddxOXWMMMMMMMMMMMMM
MMMMMMMMMMMMXo'             ,KMMW0:.                            .:0WMMK,             'oXMMMMMMMMMMMM
MMMMMMMMMMMXc               ,KMMO'                                'OMMK,               cNMMMMMMMMMMM
MMMMMMMMMMM0'               ,KMWd                                  dWMK,               '0MMMMMMMMMMM
MMMMMMMMMMMO'               ,KMWo                                  oWMK,               'OMMMMMMMMMMM
MMMMMMMMMMMO.               ,KMWo                                  oWMK,               '0MMMMMMMMMMM
MMMMMMMMMMMO.               ,KMWo                                  oWMK,               '0MMMMMMMMMMM
MMMMMMMMMMMO.               ,KMWo                                  oWMK,               '0MMMMMMMMMMM
MMMMMMMMMMMO.               ,KMWo                                  oWMK,               '0MMMMMMMMMMM
MMMMMMMMMMMO.               ,KMWo                                  oWMK,               '0MMMMMMMMMMM
MMMMMMMMMMMO.               ,KMWo                                  oWMK,               '0MMMMMMMMMMM
MMMMMMMMMMMO.               ,KMWo                                  oWMK,               '0MMMMMMMMMMM
MMMMMMMMMMMO.               ,KMWo                                  oWMK,               '0MMMMMMMMMMM
MMMMMMMMMMM0'               ,KMWd.                                .dWMK,               '0MMMMMMMMMMM
MMMMMMMMMMMNd.              ,0MMK:                                :KMM0,              .dNMMMMMMMMMMM
MMMMMMMMMMMMWOc'.           .xWMMXd;..                        ..;dXMMWx.           .'cOWMMMMMMMMMMMM
MMMMMMMMMMMMMMWNKc           .oKWMMWXk,                      'kXWMMWKd.           cKNWMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWo             .;lOWMX;                      ;XMWOl;.             oWMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWo                lWMX;                      ;XMWl                oWMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWo                lWMX;                      ;XMWl                oWMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWo                lWMX;                      ;XMWl                oWMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWo                lWMX;                      ;XMWl                oWMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWo                lWMX;                      ;XMWl                oWMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWo                lWMX;                      ;XMWl                oWMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWo                lWMX;                      ;XMWl                oWMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWo                lWMX;                      ;XMWl                oWMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWo                lWMX;                      ;XMWl                oWMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWd.               lWMX:                      :XMWl               .dWMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMK;               lWMWk.                    .kWMWl               ;KMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMXd,.           .oWMMW0c'.              .'c0WMMWo.           .,dXMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMNK0OOOOOOOOOOOXMMMMMWNKOOOOOOOOOOOOOO0NWMMMMMX0OOOOOOOOOO0KNMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM";
            
            Console.WriteLine(title, Console.ForegroundColor);
            Console.Title = "GruppenGenerator";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            string GroupGen = @"
            
  ________                                                                                   __                
 /  _____/______ __ ________ ______   ____   ____    ____   ____   ____   ________________ _/  |_  ___________ 
/   \  __\_  __ \  |  \____ \\____ \_/ __ \ /    \  / ___\_/ __ \ /    \_/ __ \_  __ \__  \\   __\/  _ \_  __ \
\    \_\  \  | \/  |  /  |_> >  |_> >  ___/|   |  \/ /_/  >  ___/|   |  \  ___/|  | \// __ \|  | (  <_> )  | \/
 \______  /__|  |____/|   __/|   __/ \___  >___|  /\___  / \___  >___|  /\___  >__|  (____  /__|  \____/|__|   
        \/            |__|   |__|        \/     \//_____/      \/     \/     \/           \/                   


                            ";
            
            
            Console.WriteLine(GroupGen, Console.ForegroundColor);
            Console.WriteLine("Herzlich willkommen zum Gruppengenerator. Möchten sie eine Gruppe erstellen? Für ja, drücken sie bitte y und für nein drücken sie bitte n.");
            string Eingabe1 = Console.ReadLine();

            switch (Eingabe1)
            {
                case ("y"):
                Console.Clear();
                Console.WriteLine("Geben sie bitte die Anzahl Gruppen ein, die sie möchten:");
                string x = Console.ReadLine();

                try
                {
                    Convert.ToInt32(x);
                    Console.WriteLine("Es werden "+x+" Gruppen erstellt. ");
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Sie haben keine gültige Zahl eingegeben. Bitte starten sie das Programm erneut. ");
                    break;
                    // anstatt break könnte man auch throw ausgeben.
                }


                Thread.Sleep(1000);
                Console.WriteLine("Es wurden soeben "+x+ " Gruppen erstellt.");
                Console.WriteLine("");
                Console.WriteLine("Bitte geben sie die Anzahl Personen ein, die sie in "+x+" Gruppen einteilen möchten:");
                string y = Console.ReadLine();


                try
                {
                    Convert.ToInt32(y);
                    Console.WriteLine("Es wurden "+y+" Personen erstellt.");
                }
                catch (System.Exception)
                {
                Console.WriteLine("Sie haben keine gültige Zahl eingegeben. Bitte starten sie das Programm erneut. ");
                
                break;
                }

                    int xx = Convert.ToInt32(x);
                    int yy= Convert.ToInt32(y);
                    int z = (yy/xx);
                    //int zz = 
                
                if (xx>yy)
                {
                    Console.WriteLine("Die Anzahl von Gruppen ist grösser, als die Anzahl von gesamten Personen.");
                    Console.WriteLine("Die Anzahl von Personen beträgt: "+x+" aber es sind nur : "+y+" Gruppen. Daher wird das Programm nun abgebrochen.");
                    Thread.Sleep(8000);
                    Console.Clear();
                    return;
                }

                Console.WriteLine("");
                Console.WriteLine("Es wurden soeben "+y+" Variabeln für die Personen erstellt.");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Bitte geben sie nachfolgend den Namen jeder dieser " + y + " Personen ein:");



                while (yy !=0)
                {
                    //string (xx-1) =Console.ReadLine();
                    //Variabeln
                }

                break;

                




                case ("n"):
                Console.WriteLine("Programm wird beendet...");
                Thread.Sleep (1000);
                Console.Clear();
                break;

                default:
                Console.WriteLine("Ihre Eingabe ("+Eingabe1+") Ist nicht definiert, starten sie das Programm erneut und geben sie statdessen y oder n ein.");
                Console.WriteLine("");
                Console.ReadKey();
                Console.Clear();
                break;
            }

            


            
        }
    }
}
