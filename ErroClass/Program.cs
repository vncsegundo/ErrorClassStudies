namespace ClassError
{
    class Triangulo
    {
        private string b;
        private string h;

        public void setB(string _b) { b = _b; }
        public string getB() { return b; }
        public void setH(string _h) { h = _h; }
        public string getH() { return h; }
        public string getArea()
        {
            return ((float.Parse(b) * float.Parse(h)) / 2).ToString();
        }
    }
    class Erro
    {
        private static bool erro;
        private static string mens;

        public static void setErro(bool _erro) { erro = _erro; }
        public static void setErro(string _mens) { erro = true; mens = _mens; }
        public static bool getErro() { return erro; }
        public static string getMens() { return mens; }
    }
    class TrianguloBll
    {
        public static void validaDados(Triangulo umtriangulo)
        {
            Erro.setErro(false);
            if (umtriangulo.getB().Length == 0)
            {
                Erro.setErro("O campo Base é de preenchimento obrigatório...");
                return;
            }
            else
            {
                try
                {
                    float.Parse(umtriangulo.getB());
                }
                catch
                {
                    Erro.setErro("O campo base deve ser númerico...");
                    return;
                }
                if (float.Parse(umtriangulo.getB()) <= 0)
                {
                    Erro.setErro("O campo base deve ser maior que zero...");
                    return;
                }
            }

            if (umtriangulo.getH().Length == 0)
            {
                Erro.setErro("O campo altura é de preenchimento obrigatório...");
                return;
            }
            else
            {
                try
                {
                    float.Parse(umtriangulo.getH());
                }
                catch
                {
                    Erro.setErro("O campo altura deve ser númerico...");
                    return;
                }
                if (float.Parse(umtriangulo.getH()) <= 0)
                {
                    Erro.setErro("O campo altura deve ser maior que zero...");
                    return;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo meutriangulo = new Triangulo();

            Console.Write("Base do Triângulo: ");
            meutriangulo.setB(Console.ReadLine());
            Console.Write("Altura do Triângulo: ");
            meutriangulo.setH(Console.ReadLine());
            TrianguloBll.validaDados(meutriangulo);
            if (Erro.getErro())
            {
                Console.WriteLine(Erro.getMens());
            }
            else
            {
                Console.WriteLine($"Área do Triângulo: {meutriangulo.getArea()}");
            }
        }
    }
}