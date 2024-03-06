namespace AATVV3_CJ3022641
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite sua nota");
            double nota =
                 Convert.ToDouble(Console.ReadLine());

            //verificação se a nota é maior de 6
            if (nota > +6)
            {
                Console.WriteLine("O aluno passou! ");
            }
            else
            {
                Console.WriteLine("O aluno não passou ");
            }
        }
    }
}
