// See https://aka.ms/new-console-template for more information
namespace UsingSample{
    class Program{
        static void Main(string[] args){
            // usingとは糖衣構文（シンタックスシュガー）であり以下のようにコンパイラにより展開される。
            // var disponseSample = new DisposeSample();
            // try
            // {
            //     disponseSample.DoThing();
            // }
            // finally
            // {
            //     if (disponseSample != null)
            //     {
            //          // IDisposableにキャストしてDisposeメソッドを実行し破棄を行う
            //         ((IDisposable)disponseSample).Dispose();
            //     }
            // }
            using(var disponseSample = new DisposeSample()){
                disponseSample.DoThing();
            }
        }
    }
}
