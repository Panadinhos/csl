using System;

public class Objc
{
	public string name = "Miguel", age = "24";
	public int pontos = 0;
	public static void Main()
	{
		string opt, opc;
		int on, subon, optint, optint16;
		string[] coisa = new string[1] {"Foi o Miguel"};
		Objc mano = new Objc();
		Console.WriteLine(coisa[0]);
		Console.WriteLine("Boas o meu nome é Bajuras e o teu qual é???");
		mano.name = Console.ReadLine();
		while (mano.name=="") {
			Console.WriteLine("Broh disse-te o meu nome e perguntei-te o teu...\nDiz lá qual é???");
			mano.name = Console.ReadLine();
		}
		Console.WriteLine("A minha idade é a que estiver no git, e a tua???");
		mano.age = Console.ReadLine();
		while (mano.age=="") {
			Console.WriteLine("Broh disse-te o meu nome e perguntei-te o teu...\nDiz lá qual é???");
			mano.age = Console.ReadLine();
		}
		on = 1;
		Console.WriteLine("Boas "+mano.name+"!!!");
		while (on!=0) {
			Console.WriteLine("**************************");
			Console.WriteLine("****       MENU       ****");
			Console.WriteLine("**************************");
			Console.WriteLine("* 1) Edit Mano           *");
			Console.WriteLine("* 2) Reset Pontos        *");
			Console.WriteLine("* 3) Print Mano          *");
			Console.WriteLine("* 7) Jogo do Sete        *");
			Console.WriteLine("* 0) Quit                *");
			Console.WriteLine("**************************");
			opc = Console.ReadLine();
			if (opc=="0") {
				on = 0;
				Console.WriteLine("Télogations "+mano.name+" espero que tenha pintado...\nBajuras out!!!1");
			} else if (opc=="1") {
				Console.WriteLine("Qual é o teu nome???");
				mano.name = Console.ReadLine();
				Console.WriteLine("Qual é a tua idade???");
				mano.age = Console.ReadLine();
			} else if (opc=="2") {
				mano.pontos = 0;
			} else if (opc=="3") {
				Console.WriteLine("O mano "+mano.name+", com "+mano.pontos.ToString()+" pontos, tem "+mano.age+"!!!");
			} else if (opc=="7") {
				Console.WriteLine("Será que consegues adivinhar???");
				subon = 1;
				while (subon!=0) {
					opt = Console.ReadLine();
					optint = int.Parse(opt);
					optint16 = Convert.ToInt16(opt);
					if (optint>7) {
						Console.WriteLine("Demasiado abaixo "+mano.name+" dá-lhe mais!!!");
					} else if (optint16<7) {
							Console.WriteLine("Táste a esticar "+mano.name+"!!!\nTenta lá com mais jeitinho...");
					} else {
						Console.WriteLine("Acertaste "+mano.name+"!!!");
						mano.pontos = mano.pontos+1;
						subon = 0;
					}
				}
			}
		}
	}
}
