using System;

namespace ExercicioMusica
{
    class Program
    { 
        static void Main(string[] args)
        {
            
            string titulo, versos1, versos2, versos3, refrao;

            titulo = "Lugar ao Sol"; 
            
            versos1 = @"Que bom viver, como é bom sonhar
E o que ficou pra trás passou e eu não me importei
Foi até melhor, tive que pensar em algo novo que fizesse sentido

Ainda vejo o mundo com os olhos de criança
Que só quer brincar e não tanta responsa
Mas a vida cobra sério e realmente não dá pra fugir";

            versos2 = @"Um dia eu espero te reencontrar numa bem melhor
Cada um tem seu caminho, eu sei foi até melhor
Irmãos do mesmo Cristo, eu quero e não desisto

Caro pai, como é bom ter por que se orgulhar
A vida pode passar, não estou sozinho
Eu sei se eu tiver fé eu volto até a sonhar";

            versos3 = @"O amor é assim, é a paz de Deus em sua casa
O amor é assim, é a paz de Deus que nunca acaba

O amor é assim, é a paz de Deus em sua casa
O amor é assim, é a paz de Deus, nunca acaba

Nossas vidas, nossos sonhos têm o mesmo valor
Nossas vidas, nossos sonhos têm o mesmo valor
Eu vou com você pra onde você for

Eu descobri que é azul a cor da parede da casa de Deus
E não há mais ninguém como você e eu";

            refrao = @"Livre pra poder sorrir, sim
Livre pra poder buscar o meu lugar ao Sol";
// Aqui eu queria ja configurar a cor do refrão mas não sabia como

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(titulo);
            Console.ResetColor();
            Console.WriteLine("");

            Console.WriteLine(versos1);
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine(refrao);
            Console.ResetColor();
            
            Console.WriteLine("");

            Console.WriteLine(versos2);
            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(refrao);
            Console.ResetColor();
            
            Console.WriteLine("");
            
            Console.WriteLine(versos3);
            Console.WriteLine("");
        }
    }
}
