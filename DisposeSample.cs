namespace UsingSample{
    public class DisposeSample : IDisposable{
        public void DoThing()
        {
            Console.WriteLine("何かの処理をする");
        }
        public void Dispose()
        {
            Console.WriteLine("Disposeが呼ばれました！");
        }
    }
}