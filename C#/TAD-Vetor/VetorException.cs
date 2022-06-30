namespace Vetor{

    class VetorException : Exception
    {
        public VetorException(string msg) : base(msg)
        {
            Console.WriteLine(msg);
        }
    }    

}