namespace TemplatePattern.Classes
{
    public abstract class TextProcess
    {
        public string[] TextProcessing(string text)
        {
            var p1 = Process1(text);
            var p2 = Process2(p1);
            var p3 = Process3(p2);
            var p4 = Process4(p3);
            return Process5(p3);
        }
        public abstract string Process1(string text);
        public abstract string Process2(string text);
        public abstract string[] Process3(string text);
        public abstract string[] Process4(string[] text);
        public abstract string[] Process5(string[] text);
    }
}
