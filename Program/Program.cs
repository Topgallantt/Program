using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rodjendan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Srecan rodjendan ljubavi moja!♥";
            Console.WindowWidth = 160;
            var cestitka = "Ti si osoba koja je donela toliko radosti i srece u moj zivot i radujem se jos jednoj godini smejanja nasim salama i usrecivanja jedno drugog. ♥\n" +
                "Srecan rodjendan srodna duso! Mnogo te volim i zelim ti nista osim zdravlje, sreću i više godina provedenih zajedno.♥\n" +
                "Da nam se sve želje ispune, kako u poslovnom, tako i u porodičnom planu. Da uvek budes dobra osoba kakva si oduvek bio, ljubazan i voljen.♥\n" +
                "Zahvalna sam sto sam deo tvog zivota i hoću da zajedno provedemo ovaj dan. Da imam milion opcija na svetu i dalje bih izabrala tebe.♥\n" +
                "Zelim da provedem jos predstojecih rodjendana sa tobom, i da budem deo ludog sveta koji se odvija samo u našim glavama već 398 dana.♥\n" +
                "Uvek cu te volet' i sve najbolje u zivotu ti zelim,  i jos mnogo godina uspeha upkros svim okolnostima.♥\n" +
                "Toliko sam ponosna na to ko si i sta ces tek postati, ali nastavi da budes skroman i ljubazan i ne odustaj jer zasluzujes velike stvari.♥\n" +
                "Volim te♥♥♥♥♥";

            for (int i = 0; i < cestitka.Length; i++)
            {
                Console.Write(cestitka[i]);
                Thread.Sleep(TimeSpan.FromSeconds(0.08));

            }

            Console.ReadKey(true);
        }
    }
}
