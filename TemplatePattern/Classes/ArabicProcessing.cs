namespace TemplatePattern.Classes
{
    public class ArabicProcessing : TextProcess
    {
        public override string Process1(string text)
        {
            Console.WriteLine("Step 1");
            return text;
        }

        public override string Process2(string text)
        {
            Console.WriteLine("Step 2");
            return text;
        }

        public override string[] Process3(string text)
        {
            Console.WriteLine("Step 3");
            return text.Split(" ");
        }

        public override string[] Process4(string[] text)
        {
            Console.WriteLine("Step 4");
            return text;
        }

        public override string[] Process5(string[] text)
        {
            Console.WriteLine("Step 5");
            return text;
        }
    }
}
