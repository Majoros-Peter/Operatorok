namespace Operatorok
{
    internal class Kifejezes
    {
        public int ASzam { get; private set; }
        public string Operator { get; private set; }
        public int BSzam { get; private set; }

        public Kifejezes(string[] egyenlet)
        {
            ASzam = Convert.ToInt32(egyenlet[0]);
            Operator = egyenlet[1];
            BSzam = Convert.ToInt32(egyenlet[2]);
        }
        public static string[] HasznalhatoOperatorok { get => new string[] { "+", "-", "*", "/", "div", "mod" }; }

        public static string KifejezesMeghatarozasa(Kifejezes kifejezes)
        {
            string output;

            switch (kifejezes.Operator)
            {
                case "+":
                    output = $"{kifejezes.ASzam + kifejezes.BSzam}";
                    break;
                case "-":
                    output = $"{kifejezes.ASzam - kifejezes.BSzam}";
                    break;
                case "*":
                    output = $"{kifejezes.ASzam * kifejezes.BSzam}";
                    break;
                case "/":
                    output = kifejezes.ASzam == 0 || kifejezes.BSzam == 0 ? "Egyéb hiba" : $"{kifejezes.ASzam * 1.0 / kifejezes.BSzam}";
                    break;
                case "div":
                    output = kifejezes.ASzam == 0 || kifejezes.BSzam == 0 ? "Egyéb hiba" : $"{kifejezes.ASzam / kifejezes.BSzam}";
                    break;
                case "mod":
                    output = kifejezes.ASzam == 0 || kifejezes.BSzam == 0 ? "Egyéb hiba" : $"{kifejezes.ASzam % kifejezes.BSzam}";
                    break;
                default:
                    output = "Hibás operátor!";
                    break;
            }

            return $"{kifejezes} = {output}";
        }

        public override string ToString() => $"{ASzam} {Operator} {BSzam}";
    }
}