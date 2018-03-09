using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class MainEuler
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            UserInterface.IUserInterface userInterface = new UserInterface.ConsoleUI();
            UserInterface.InputOutput IOManager = new UserInterface.InputOutput(userInterface);

            IOManager.WriteLine("Choisir défi à exécuter");
            int defiChoisi = IOManager.ReadInteger();

            try
            {
                long resultat = ExecuteDefi(defiChoisi);
                IOManager.WriteLine("Le résultat est :" + resultat);
            } catch (Exception e){
                IOManager.WriteLine("Erreur :" + e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        static long ExecuteDefi(int defiChoisi)
        {
            switch (defiChoisi)
            {
                case 1:
                    return Defi1.Execute();
                case 2:
                    return Defi2.Execute();
                case 3:
                    return Defi3.Execute();
                case 4:
                    return Defi4.Execute();
                default:
                    throw new ArgumentOutOfRangeException("Ce défi n'est pas implémenté");

            }
        }
    }
}
